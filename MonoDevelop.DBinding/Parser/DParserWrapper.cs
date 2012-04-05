﻿using System.IO;
using D_Parser.Dom;
using D_Parser.Parser;
using ICSharpCode.NRefactory.TypeSystem;
using MonoDevelop.Ide.Tasks;
using MonoDevelop.Ide.TypeSystem;
using MonoDevelop.Projects;

namespace MonoDevelop.D.Parser
{
	/// <summary>
	/// Parses D code.
	/// 
	/// Note: For natively parsing the code, the D_Parser engine will be used. 
	/// To make it compatible to the MonoDevelop.Dom, its output will be wrapped afterwards!
	/// </summary>
	public class DParserWrapper : ITypeSystemParser
	{
		public ParsedDocument Parse(bool storeAst, string file, TextReader content, Project prj = null)
		{
			var doc = new ParsedDModule(file);

			var parser = DParser.Create(content);

			// Also put attention on non-ddoc comments; These will be used to generate foldable comment regions then
			parser.Lexer.OnlyEnlistDDocComments = false;

			// Parse the code
			var ast = parser.Parse();

			ast.FileName = file;
			doc.DDom = ast;

			// Update project owner information
			if (prj is DProject)
			{
				var pf = prj.GetProjectFile(file);

				// Build appropriate module name
				if (pf != null)
					ast.ModuleName = BuildModuleName(pf);
			}

			// Add parser errors to the parser output
			foreach (var parserError in parser.ParseErrors)
				doc.ErrorList.Add(new Error(
					ErrorType.Error, 
					parserError.Message, 
					parserError.Location.Line, 
					parserError.Location.Column));

			#region Provide comment fold support by addin them to the IDE document object
			foreach (var cm in parser.TrackerVariables.Comments)
			{
				var c = new MonoDevelop.Ide.TypeSystem.Comment(cm.CommentText);

				c.CommentType = cm.CommentType.HasFlag(D_Parser.Parser.Comment.Type.Block) ? CommentType.Block : CommentType.SingleLine;
				c.IsDocumentation = cm.CommentType.HasFlag(D_Parser.Parser.Comment.Type.Documentation);

				if (c.CommentType == CommentType.SingleLine)
				{
					if (c.IsDocumentation)
						c.OpenTag = "///";
					else
						c.OpenTag = "//";
				}
				else
				{
					if (c.IsDocumentation)
					{
						c.OpenTag = "/**";
						c.ClosingTag = "*/";
					}
					else
					{
						c.OpenTag = "/*";
						c.ClosingTag = "*/";
					}
				}

				c.Region = new DomRegion(cm.StartPosition.Line, cm.StartPosition.Column - 2, cm.EndPosition.Line, cm.EndPosition.Column);

				doc.Comments.Add(c);

				// Enlist TODO/FIXME/HACK etc. stuff in the IDE's project task list
				foreach (var sct in CommentTag.SpecialCommentTags)
					if (c.Text.StartsWith(sct.Tag))
					{
						doc.Add(new Tag(sct.Tag, c.Text, c.Region));
						break;
					}
			}
			#endregion

			#region Serialize to NRefactory Dom structure
			/*
			var cu = new CompilationUnit(file);
			doc.CompilationUnit = cu;
			
			var global = new DomType(cu, ClassType.Class,
				Modifiers.Public | Modifiers.Partial,
				"(global)",
				new DomLocation(),
				ast.ModuleName,
				new DomRegion());
			cu.Add(global);

			foreach (var n in ast)
			{
				var ch = ConvertDParserToDomNode(n, doc);
				
				if (ch is DomField || ch is DomMethod)
					global.Add(ch as IMember);
				else
					cu.Add(ch as IType);
			}
			*/
			#endregion

			return doc;
		}

		public static string BuildModuleName(ProjectFile pf)
		{
			return pf.ProjectVirtualPath.ChangeExtension(null).ToString().Replace(Path.DirectorySeparatorChar, '.');
		}

		#region Converter methods
		/*
		public static INode ConvertDParserToDomNode(D_Parser.Dom.INode n, ParsedDocument doc)
		{
			//TODO: DDoc comments!

			if (n is DMethod)
			{
				var dm = n as DMethod;

				var domMethod = new DomMethod(
					n.Name,
					GetNodeModifiers(dm),
					dm.SpecialType == DMethod.MethodType.Constructor ? MethodModifier.IsConstructor : MethodModifier.None,
					FromCodeLocation(n.StartLocation),
					GetBlockBodyRegion(dm),
					GetReturnType(n));

				foreach (var pn in dm.Parameters)
					domMethod.Add(new DomParameter(domMethod, pn.Name, GetReturnType(pn)));


				domMethod.AddTypeParameter(GetTypeParameters(dm));

				foreach (var subNode in dm) domMethod.AddChild(ConvertDParserToDomNode(subNode, doc));

				return domMethod;
			}
			else if (n is DEnum)
			{
				var de = n as DEnum;

				var domType = new DomType(
					doc.CompilationUnit,
					ClassType.Enum,
					GetNodeModifiers(de),
					n.Name,
					FromCodeLocation(n.StartLocation),
					BuildTypeNamespace(n), GetBlockBodyRegion(de));

				foreach (var subNode in de)
					domType.Add(ConvertDParserToDomNode(subNode, doc) as IMember);
				return domType;
			}
			else if (n is DClassLike)
			{
				var dc = n as DClassLike;

				ClassType ct = ClassType.Unknown;

				switch (dc.ClassType)
				{
					case DTokens.Template:
					case DTokens.Class:
						ct = ClassType.Class;
						break;
					case DTokens.Interface:
						ct = ClassType.Interface;
						break;
					case DTokens.Union:
					case DTokens.Struct:
						ct = ClassType.Struct;
						break;
				}

				var domType = new DomType(
					doc.CompilationUnit,
					ct,
					GetNodeModifiers(dc),
					n.Name,
					FromCodeLocation(n.StartLocation),
					BuildTypeNamespace(n),
					GetBlockBodyRegion(dc));

				domType.AddTypeParameter(GetTypeParameters(dc));
				foreach (var subNode in dc)
					domType.Add(ConvertDParserToDomNode(subNode, doc) as IMember);
				return domType;
			}
			else if (n is DVariable)
			{
				var dv = n as DVariable;
				return new DomField(n.Name, GetNodeModifiers(dv), FromCodeLocation(n.StartLocation), GetReturnType(n));
			}
			return null;
		}
		*/
		public static string BuildTypeNamespace(D_Parser.Dom.INode n)
		{
			return (n.NodeRoot as IAbstractSyntaxTree).ModuleName;
		}

		/// <summary>
		/// Converts D template parameters to Dom type parameters
		/// </summary>
		/*public static IEnumerable<ITypeParameter> GetTypeParameters(DNode n)
		{
			if (n.TemplateParameters != null)
				foreach (var tpar in n.TemplateParameters)
					yield return new TypeParameter(tpar.Name); //TODO: Constraints'n'Stuff
		}

		public static IReturnType GetReturnType(D_Parser.Dom.INode n)
		{
			return ToDomType(n.Type);
		}

		public static IReturnType ToDomType(ITypeDeclaration td)
		{
			return td == null ? null : new DomReturnType(td.ToString());
		}

		public static IEnumerable<IAttribute> TransferAttributes(DNode n)
		{
			foreach (var attr in n.Attributes)
				yield return new DomAttribute() { Role = DomAttribute.Roles.Attribute, Name = DTokens.GetTokenString(attr.Token) };
		}*/

		/*public static DomLocation FromCodeLocation(CodeLocation loc)
		{
			return new DomLocation(loc.Line, loc.Column);
		}

		public static Modifiers GetNodeModifiers(DNode dn)
		{
			Modifiers m = Modifiers.None;

			if (dn.ContainsAttribute(DTokens.Abstract)) m |= Modifiers.Abstract;
			if (dn.ContainsAttribute(DTokens.Const)) m |= Modifiers.Const;
			if (dn.ContainsAttribute(DTokens.Extern)) m |= Modifiers.Extern;
			if (dn.ContainsAttribute(DTokens.Package)) m |= Modifiers.Internal;
			if (dn.ContainsAttribute(DTokens.Override)) m |= Modifiers.Override;
			if (dn.ContainsAttribute(DTokens.Private)) m |= Modifiers.Private;
			if (dn.ContainsAttribute(DTokens.Protected)) m |= Modifiers.Protected;
			if (dn.ContainsAttribute(DTokens.Public)) m |= Modifiers.Public;
			if (dn.ContainsAttribute(DTokens.Final)) m |= Modifiers.Sealed;
			if (dn.ContainsAttribute(DTokens.Static)) m |= Modifiers.Static;
			if (dn.ContainsAttribute(DTokens.Volatile)) m |= Modifiers.Volatile;

			return m;
		}*/

		#endregion
	}
}
