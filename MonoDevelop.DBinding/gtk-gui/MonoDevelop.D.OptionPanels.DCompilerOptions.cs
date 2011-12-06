
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D.OptionPanels
{
	public partial class DCompilerOptions
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox6;
		private global::Gtk.VBox vbox8;
		private global::Gtk.Table table6;
		private global::Gtk.Button btnDefaults;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Button btnDebugArguments;
		private global::Gtk.Button btnReleaseArguments;
		private global::Gtk.Label label28;
		private global::Gtk.Label label29;
		private global::Gtk.Label label30;
		private global::Gtk.Label label31;
		private global::Gtk.Label label32;
		private global::Gtk.Entry txtCompiler;
		private global::Gtk.Entry txtConsoleAppLinker;
		private global::Gtk.Entry txtGUIAppLinker;
		private global::Gtk.Entry txtSharedLibLinker;
		private global::Gtk.Entry txtStaticLibLinker;
		private global::Gtk.Notebook notebook2;
		private global::Gtk.Table table5;
		private global::Gtk.Button btnAddDefaultLib;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Entry txtDefaultLib;
		private global::Gtk.Button btnBrowseDefaultLib;
		private global::Gtk.Label label16;
		private global::Gtk.ScrolledWindow scrolledwindow12;
		private global::Gtk.TreeView tvDefaultLibs;
		private global::Gtk.VBox vbox10;
		private global::Gtk.Button btnRemoveDefaultLib;
		private global::Gtk.Label label12;
		private global::Gtk.Table table4;
		private global::Gtk.Button btnAddIncludePath;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Entry txtIncludePath;
		private global::Gtk.Button btnBrowseIncludePath;
		private global::Gtk.Label label15;
		private global::Gtk.ScrolledWindow scrolledwindow11;
		private global::Gtk.TreeView tvIncludePaths;
		private global::Gtk.VBox vbox9;
		private global::Gtk.Button btnRemoveIncludePath;
		private global::Gtk.Label label1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.OptionPanels.DCompilerOptions
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.D.OptionPanels.DCompilerOptions";
			// Container child MonoDevelop.D.OptionPanels.DCompilerOptions.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 3;
			// Container child vbox6.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table6 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table6.Name = "table6";
			this.table6.RowSpacing = ((uint)(6));
			this.table6.ColumnSpacing = ((uint)(6));
			// Container child table6.Gtk.Table+TableChild
			this.btnDefaults = new global::Gtk.Button ();
			this.btnDefaults.CanFocus = true;
			this.btnDefaults.Name = "btnDefaults";
			this.btnDefaults.UseUnderline = true;
			this.btnDefaults.Label = global::Mono.Unix.Catalog.GetString ("Defaults");
			this.table6.Add (this.btnDefaults);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table6 [this.btnDefaults]));
			w1.TopAttach = ((uint)(5));
			w1.BottomAttach = ((uint)(6));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnDebugArguments = new global::Gtk.Button ();
			this.btnDebugArguments.CanFocus = true;
			this.btnDebugArguments.Name = "btnDebugArguments";
			this.btnDebugArguments.UseUnderline = true;
			this.btnDebugArguments.Label = global::Mono.Unix.Catalog.GetString ("Debug Arguments");
			this.hbox8.Add (this.btnDebugArguments);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnDebugArguments]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnReleaseArguments = new global::Gtk.Button ();
			this.btnReleaseArguments.CanFocus = true;
			this.btnReleaseArguments.Name = "btnReleaseArguments";
			this.btnReleaseArguments.UseUnderline = true;
			this.btnReleaseArguments.Label = global::Mono.Unix.Catalog.GetString ("Release Arguments");
			this.hbox8.Add (this.btnReleaseArguments);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnReleaseArguments]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.table6.Add (this.hbox8);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox8]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("Static Lib Linker");
			this.table6.Add (this.label28);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table6 [this.label28]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label29 = new global::Gtk.Label ();
			this.label29.Name = "label29";
			this.label29.LabelProp = global::Mono.Unix.Catalog.GetString ("Shared Lib Linker");
			this.table6.Add (this.label29);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table6 [this.label29]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label30 = new global::Gtk.Label ();
			this.label30.Name = "label30";
			this.label30.LabelProp = global::Mono.Unix.Catalog.GetString ("Console app Linker");
			this.table6.Add (this.label30);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table6 [this.label30]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label31 = new global::Gtk.Label ();
			this.label31.Name = "label31";
			this.label31.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler");
			this.table6.Add (this.label31);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table6 [this.label31]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString ("GUI app Linker");
			this.table6.Add (this.label32);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table6 [this.label32]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtCompiler = new global::Gtk.Entry ();
			this.txtCompiler.CanFocus = true;
			this.txtCompiler.Name = "txtCompiler";
			this.txtCompiler.IsEditable = true;
			this.txtCompiler.InvisibleChar = '•';
			this.table6.Add (this.txtCompiler);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtCompiler]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtConsoleAppLinker = new global::Gtk.Entry ();
			this.txtConsoleAppLinker.CanFocus = true;
			this.txtConsoleAppLinker.Name = "txtConsoleAppLinker";
			this.txtConsoleAppLinker.IsEditable = true;
			this.txtConsoleAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtConsoleAppLinker);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtConsoleAppLinker]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtGUIAppLinker = new global::Gtk.Entry ();
			this.txtGUIAppLinker.CanFocus = true;
			this.txtGUIAppLinker.Name = "txtGUIAppLinker";
			this.txtGUIAppLinker.IsEditable = true;
			this.txtGUIAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtGUIAppLinker);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtGUIAppLinker]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtSharedLibLinker = new global::Gtk.Entry ();
			this.txtSharedLibLinker.CanFocus = true;
			this.txtSharedLibLinker.Name = "txtSharedLibLinker";
			this.txtSharedLibLinker.IsEditable = true;
			this.txtSharedLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtSharedLibLinker);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtSharedLibLinker]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtStaticLibLinker = new global::Gtk.Entry ();
			this.txtStaticLibLinker.CanFocus = true;
			this.txtStaticLibLinker.Name = "txtStaticLibLinker";
			this.txtStaticLibLinker.IsEditable = true;
			this.txtStaticLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtStaticLibLinker);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtStaticLibLinker]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox8.Add (this.table6);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.table6]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.notebook2 = new global::Gtk.Notebook ();
			this.notebook2.CanFocus = true;
			this.notebook2.Name = "notebook2";
			this.notebook2.CurrentPage = 0;
			this.notebook2.ShowBorder = false;
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.table5 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(10));
			this.table5.ColumnSpacing = ((uint)(10));
			this.table5.BorderWidth = ((uint)(3));
			// Container child table5.Gtk.Table+TableChild
			this.btnAddDefaultLib = new global::Gtk.Button ();
			this.btnAddDefaultLib.Sensitive = false;
			this.btnAddDefaultLib.CanFocus = true;
			this.btnAddDefaultLib.Name = "btnAddDefaultLib";
			this.btnAddDefaultLib.UseUnderline = true;
			this.btnAddDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table5.Add (this.btnAddDefaultLib);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table5 [this.btnAddDefaultLib]));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.txtDefaultLib = new global::Gtk.Entry ();
			this.txtDefaultLib.CanFocus = true;
			this.txtDefaultLib.Name = "txtDefaultLib";
			this.txtDefaultLib.IsEditable = true;
			this.txtDefaultLib.InvisibleChar = '?';
			this.hbox6.Add (this.txtDefaultLib);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtDefaultLib]));
			w17.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnBrowseDefaultLib = new global::Gtk.Button ();
			this.btnBrowseDefaultLib.CanFocus = true;
			this.btnBrowseDefaultLib.Name = "btnBrowseDefaultLib";
			this.btnBrowseDefaultLib.UseUnderline = true;
			this.btnBrowseDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.hbox6.Add (this.btnBrowseDefaultLib);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.btnBrowseDefaultLib]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.table5.Add (this.hbox6);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table5 [this.hbox6]));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Library:");
			this.table5.Add (this.label16);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table5 [this.label16]));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.scrolledwindow12 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow12.CanFocus = true;
			this.scrolledwindow12.Name = "scrolledwindow12";
			this.scrolledwindow12.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow12.Gtk.Container+ContainerChild
			this.tvDefaultLibs = new global::Gtk.TreeView ();
			this.tvDefaultLibs.CanFocus = true;
			this.tvDefaultLibs.Name = "tvDefaultLibs";
			this.scrolledwindow12.Add (this.tvDefaultLibs);
			this.table5.Add (this.scrolledwindow12);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table5 [this.scrolledwindow12]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			// Container child table5.Gtk.Table+TableChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.btnRemoveDefaultLib = new global::Gtk.Button ();
			this.btnRemoveDefaultLib.Sensitive = false;
			this.btnRemoveDefaultLib.CanFocus = true;
			this.btnRemoveDefaultLib.Name = "btnRemoveDefaultLib";
			this.btnRemoveDefaultLib.UseUnderline = true;
			this.btnRemoveDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox10.Add (this.btnRemoveDefaultLib);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.btnRemoveDefaultLib]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			this.table5.Add (this.vbox10);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table5 [this.vbox10]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.LeftAttach = ((uint)(2));
			w24.RightAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook2.Add (this.table5);
			// Notebook tab
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Default Libraries");
			this.notebook2.SetTabLabel (this.table5, this.label12);
			this.label12.ShowAll ();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.table4 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(10));
			this.table4.ColumnSpacing = ((uint)(10));
			this.table4.BorderWidth = ((uint)(3));
			// Container child table4.Gtk.Table+TableChild
			this.btnAddIncludePath = new global::Gtk.Button ();
			this.btnAddIncludePath.Sensitive = false;
			this.btnAddIncludePath.CanFocus = true;
			this.btnAddIncludePath.Name = "btnAddIncludePath";
			this.btnAddIncludePath.UseUnderline = true;
			this.btnAddIncludePath.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table4.Add (this.btnAddIncludePath);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4 [this.btnAddIncludePath]));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.txtIncludePath = new global::Gtk.Entry ();
			this.txtIncludePath.CanFocus = true;
			this.txtIncludePath.Name = "txtIncludePath";
			this.txtIncludePath.IsEditable = true;
			this.txtIncludePath.InvisibleChar = '?';
			this.hbox5.Add (this.txtIncludePath);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtIncludePath]));
			w27.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.btnBrowseIncludePath = new global::Gtk.Button ();
			this.btnBrowseIncludePath.CanFocus = true;
			this.btnBrowseIncludePath.Name = "btnBrowseIncludePath";
			this.btnBrowseIncludePath.UseUnderline = true;
			this.btnBrowseIncludePath.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.hbox5.Add (this.btnBrowseIncludePath);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.btnBrowseIncludePath]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.table4.Add (this.hbox5);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table4 [this.hbox5]));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Path:");
			this.table4.Add (this.label15);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table4 [this.label15]));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.scrolledwindow11 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow11.CanFocus = true;
			this.scrolledwindow11.Name = "scrolledwindow11";
			this.scrolledwindow11.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow11.Gtk.Container+ContainerChild
			this.tvIncludePaths = new global::Gtk.TreeView ();
			this.tvIncludePaths.CanFocus = true;
			this.tvIncludePaths.Name = "tvIncludePaths";
			this.scrolledwindow11.Add (this.tvIncludePaths);
			this.table4.Add (this.scrolledwindow11);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table4 [this.scrolledwindow11]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			// Container child table4.Gtk.Table+TableChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.btnRemoveIncludePath = new global::Gtk.Button ();
			this.btnRemoveIncludePath.Sensitive = false;
			this.btnRemoveIncludePath.CanFocus = true;
			this.btnRemoveIncludePath.Name = "btnRemoveIncludePath";
			this.btnRemoveIncludePath.UseUnderline = true;
			this.btnRemoveIncludePath.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox9.Add (this.btnRemoveIncludePath);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.btnRemoveIncludePath]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			this.table4.Add (this.vbox9);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table4 [this.vbox9]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.LeftAttach = ((uint)(2));
			w34.RightAttach = ((uint)(3));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook2.Add (this.table4);
			global::Gtk.Notebook.NotebookChild w35 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2 [this.table4]));
			w35.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Includes");
			this.notebook2.SetTabLabel (this.table4, this.label1);
			this.label1.ShowAll ();
			this.vbox8.Add (this.notebook2);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.notebook2]));
			w36.Position = 1;
			this.vbox6.Add (this.vbox8);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox8]));
			w37.Position = 0;
			this.hbox1.Add (this.vbox6);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox6]));
			w38.Position = 0;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.btnDebugArguments.Clicked += new global::System.EventHandler (this.btnDebugArguments_Clicked);
			this.btnReleaseArguments.Clicked += new global::System.EventHandler (this.btnReleaseArguments_Clicked);
			this.btnDefaults.Clicked += new global::System.EventHandler (this.btnDefaults_Clicked);
			this.btnRemoveDefaultLib.Clicked += new global::System.EventHandler (this.btnRemoveDefaultLib_Clicked);
			this.tvDefaultLibs.CursorChanged += new global::System.EventHandler (this.tvDefaultLibs_CursorChanged);
			this.txtDefaultLib.Changed += new global::System.EventHandler (this.txtDefaultLib_Changed);
			this.txtDefaultLib.Activated += new global::System.EventHandler (this.txtDefaultLib_Activated);
			this.btnBrowseDefaultLib.Clicked += new global::System.EventHandler (this.btnBrowseDefaultLib_Clicked);
			this.btnAddDefaultLib.Clicked += new global::System.EventHandler (this.btnAddDefaultLib_Click);
			this.btnRemoveIncludePath.Clicked += new global::System.EventHandler (this.btnRemoveIncludePath_Clicked);
			this.tvIncludePaths.CursorChanged += new global::System.EventHandler (this.tvIncludePaths_CursorChanged);
			this.txtIncludePath.Changed += new global::System.EventHandler (this.txtIncludePath_Changed);
			this.txtIncludePath.Activated += new global::System.EventHandler (this.txtIncludePath_Activated);
			this.btnBrowseIncludePath.Clicked += new global::System.EventHandler (this.btnBrowseIncludePath_Clicked);
			this.btnAddIncludePath.Clicked += new global::System.EventHandler (this.btnAddIncludePath_Clicked);
		}
	}
}