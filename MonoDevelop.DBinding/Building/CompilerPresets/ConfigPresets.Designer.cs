﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18034
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonoDevelop.D.Building.CompilerPresets {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ConfigPresets {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigPresets() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MonoDevelop.D.Building.CompilerPresets.ConfigPresets", typeof(ConfigPresets).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Compiler&gt;
        ///	&lt;VersionId&gt;DigitalMars&lt;/VersionId&gt;
        ///	&lt;CompilerCommand&gt;dmd&lt;/CompilerCommand&gt;
        ///	
        ///	&lt;Patterns&gt;
        ///		&lt;obj&gt;&quot;{0}&quot;&lt;/obj&gt;
        ///		&lt;include&gt;&quot;-I{0}&quot;&lt;/include&gt;
        ///		&lt;version&gt;-version&lt;/version&gt;
        ///		&lt;debug&gt;-debug&lt;/debug&gt;
        ///		&lt;unittest&gt;-unittest&lt;/unittest&gt;
        ///		&lt;profile&gt;-profile&lt;/profile&gt;
        ///		&lt;ddFlag&gt;-D&lt;/ddFlag&gt;
        ///		&lt;ddMacroDefinition&gt;&quot;{0}&quot;&lt;/ddMacroDefinition&gt;
        ///		&lt;ddDir&gt;&quot;-Dd{0}&quot;&lt;/ddDir&gt;
        ///		&lt;linkerRedirectFlag&gt;-L&lt;/linkerRedirectFlag&gt;
        ///	&lt;/Patterns&gt;
        ///
        ///	&lt;TargetConfiguration Target=&quot;Exec [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        public static string dmd {
            get {
                return ResourceManager.GetString("dmd", resourceCulture);
            }
        }
    }
}
