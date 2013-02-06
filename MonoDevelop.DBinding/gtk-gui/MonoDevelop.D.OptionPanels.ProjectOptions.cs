
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D.OptionPanels
{
	public partial class ProjectOptions
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.Table table4;
		private global::Gtk.ComboBox combo_ProjectType;
		private global::Gtk.Label label10;
		private global::Gtk.Label label13;
		private global::Gtk.Label label3;
		private global::Gtk.Label label6;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.ScrolledWindow scrolledwindow3;
		private global::Gtk.TextView text_Libraries;
		private global::Gtk.ScrolledWindow scrolledwindow5;
		private global::Gtk.TextView extraLinkerTextView;
		private global::Gtk.Entry text_BinDirectory;
		private global::Gtk.Entry text_TargetFile;
		private global::Gtk.Label label2;
		private global::Gtk.Table table1;
		private global::Gtk.CheckButton cbPreferOneStepCompilation;
		private global::Gtk.CheckButton cbUseDefaultCompiler;
		private global::Gtk.ComboBox cmbCompiler;
		private global::Gtk.Label label11;
		private global::Gtk.Label label17;
		private global::Gtk.Label label18;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label7;
		private global::Gtk.ScrolledWindow scrolledwindow4;
		private global::Gtk.TextView extraCompilerTextView;
		private global::Gtk.SpinButton spin_debugLevel;
		private global::Gtk.Entry text_DDocDir;
		private global::Gtk.Entry text_debugConstants;
		private global::Gtk.Entry text_ObjectsDirectory;
		private global::Gtk.Entry text_versionConstants;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label16;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.VBox vbox_ProjectDeps;
		private global::Gtk.Label label12;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Table table2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView text_Includes;
		private global::Gtk.Label label14;
		private global::Gtk.Table table3;
		private global::Gtk.Button button_AddInclude;
		private global::Gtk.Label label15;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.OptionPanels.ProjectOptions
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.D.OptionPanels.ProjectOptions";
			// Container child MonoDevelop.D.OptionPanels.ProjectOptions.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 3;
			this.notebook1.ShowBorder = false;
			this.notebook1.Scrollable = true;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table4 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(4));
			this.table4.ColumnSpacing = ((uint)(4));
			this.table4.BorderWidth = ((uint)(4));
			// Container child table4.Gtk.Table+TableChild
			this.combo_ProjectType = global::Gtk.ComboBox.NewText ();
			this.combo_ProjectType.Name = "combo_ProjectType";
			this.table4.Add (this.combo_ProjectType);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table4 [this.combo_ProjectType]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Extra Linker Options");
			this.table4.Add (this.label10);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table4 [this.label10]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Compile target");
			this.table4.Add (this.label13);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4 [this.label13]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Output file");
			this.table4.Add (this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4 [this.label3]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Output directory");
			this.table4.Add (this.label6);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table4 [this.label6]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Libraries\n(one per line)");
			this.table4.Add (this.label8);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table4 [this.label8]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Note: Relative paths will be related to the project\'s base directory!");
			this.table4.Add (this.label9);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4 [this.label9]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.scrolledwindow3 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow3.HeightRequest = 100;
			this.scrolledwindow3.CanFocus = true;
			this.scrolledwindow3.Name = "scrolledwindow3";
			this.scrolledwindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow3.Gtk.Container+ContainerChild
			this.text_Libraries = new global::Gtk.TextView ();
			this.text_Libraries.CanFocus = true;
			this.text_Libraries.Name = "text_Libraries";
			this.scrolledwindow3.Add (this.text_Libraries);
			this.table4.Add (this.scrolledwindow3);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4 [this.scrolledwindow3]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.scrolledwindow5 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow5.HeightRequest = 100;
			this.scrolledwindow5.CanFocus = true;
			this.scrolledwindow5.Name = "scrolledwindow5";
			this.scrolledwindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow5.Gtk.Container+ContainerChild
			this.extraLinkerTextView = new global::Gtk.TextView ();
			this.extraLinkerTextView.TooltipMarkup = "A newline-separated list of extra options to send to the compiler.\nOne option can" +
				" be in more than one line.\nExample:\n\t`--pkg\n\tcairo`";
			this.extraLinkerTextView.CanFocus = true;
			this.extraLinkerTextView.Name = "extraLinkerTextView";
			this.scrolledwindow5.Add (this.extraLinkerTextView);
			this.table4.Add (this.scrolledwindow5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table4 [this.scrolledwindow5]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.text_BinDirectory = new global::Gtk.Entry ();
			this.text_BinDirectory.CanFocus = true;
			this.text_BinDirectory.Name = "text_BinDirectory";
			this.text_BinDirectory.IsEditable = true;
			this.text_BinDirectory.InvisibleChar = '●';
			this.table4.Add (this.text_BinDirectory);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table4 [this.text_BinDirectory]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.text_TargetFile = new global::Gtk.Entry ();
			this.text_TargetFile.CanFocus = true;
			this.text_TargetFile.Name = "text_TargetFile";
			this.text_TargetFile.IsEditable = true;
			this.text_TargetFile.InvisibleChar = '●';
			this.table4.Add (this.text_TargetFile);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table4 [this.text_TargetFile]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table4);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Linking");
			this.notebook1.SetTabLabel (this.table4, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table (((uint)(10)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(4));
			this.table1.ColumnSpacing = ((uint)(4));
			this.table1.BorderWidth = ((uint)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cbPreferOneStepCompilation = new global::Gtk.CheckButton ();
			this.cbPreferOneStepCompilation.CanFocus = true;
			this.cbPreferOneStepCompilation.Name = "cbPreferOneStepCompilation";
			this.cbPreferOneStepCompilation.Label = global::Mono.Unix.Catalog.GetString ("Perform a one-step compilation if the compiler allows it to do that");
			this.cbPreferOneStepCompilation.DrawIndicator = true;
			this.cbPreferOneStepCompilation.UseUnderline = true;
			this.table1.Add (this.cbPreferOneStepCompilation);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.cbPreferOneStepCompilation]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cbUseDefaultCompiler = new global::Gtk.CheckButton ();
			this.cbUseDefaultCompiler.CanFocus = true;
			this.cbUseDefaultCompiler.Name = "cbUseDefaultCompiler";
			this.cbUseDefaultCompiler.Label = global::Mono.Unix.Catalog.GetString ("Use Default Compiler");
			this.cbUseDefaultCompiler.Active = true;
			this.cbUseDefaultCompiler.DrawIndicator = true;
			this.cbUseDefaultCompiler.UseUnderline = true;
			this.table1.Add (this.cbUseDefaultCompiler);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.cbUseDefaultCompiler]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cmbCompiler = global::Gtk.ComboBox.NewText ();
			this.cmbCompiler.Name = "cmbCompiler";
			this.table1.Add (this.cmbCompiler);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.cmbCompiler]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Note: Relative paths will be related to the project\'s base directory!");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Debug constants");
			this.table1.Add (this.label17);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.label17]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("Version constants");
			this.table1.Add (this.label18);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.label18]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Debug level");
			this.table1.Add (this.label19);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.label19]));
			w21.TopAttach = ((uint)(5));
			w21.BottomAttach = ((uint)(6));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("DDoc directory");
			this.table1.Add (this.label20);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.label20]));
			w22.TopAttach = ((uint)(8));
			w22.BottomAttach = ((uint)(9));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Objects directory");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w24.TopAttach = ((uint)(7));
			w24.BottomAttach = ((uint)(8));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Extra Compiler Options");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w25.TopAttach = ((uint)(9));
			w25.BottomAttach = ((uint)(10));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.scrolledwindow4 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow4.HeightRequest = 150;
			this.scrolledwindow4.CanFocus = true;
			this.scrolledwindow4.Name = "scrolledwindow4";
			this.scrolledwindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow4.Gtk.Container+ContainerChild
			this.extraCompilerTextView = new global::Gtk.TextView ();
			this.extraCompilerTextView.TooltipMarkup = "A newline-separated list of extra options to send to the compiler.\nOne option can" +
				" be in more than one line.\nExample:\n\t`--pkg\n\tcairo`";
			this.extraCompilerTextView.CanFocus = true;
			this.extraCompilerTextView.Name = "extraCompilerTextView";
			this.scrolledwindow4.Add (this.extraCompilerTextView);
			this.table1.Add (this.scrolledwindow4);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.scrolledwindow4]));
			w27.TopAttach = ((uint)(9));
			w27.BottomAttach = ((uint)(10));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spin_debugLevel = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spin_debugLevel.TooltipMarkup = "The debug level the program is built in.\nA value of zero (0) will not emit a -deb" +
				"ug flag to the compilation argument string!";
			this.spin_debugLevel.CanFocus = true;
			this.spin_debugLevel.Name = "spin_debugLevel";
			this.spin_debugLevel.Adjustment.PageIncrement = 10D;
			this.spin_debugLevel.ClimbRate = 1D;
			this.spin_debugLevel.Numeric = true;
			this.table1.Add (this.spin_debugLevel);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.spin_debugLevel]));
			w28.TopAttach = ((uint)(5));
			w28.BottomAttach = ((uint)(6));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.text_DDocDir = new global::Gtk.Entry ();
			this.text_DDocDir.CanFocus = true;
			this.text_DDocDir.Name = "text_DDocDir";
			this.text_DDocDir.IsEditable = true;
			this.text_DDocDir.InvisibleChar = '●';
			this.table1.Add (this.text_DDocDir);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.text_DDocDir]));
			w29.TopAttach = ((uint)(8));
			w29.BottomAttach = ((uint)(9));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.text_debugConstants = new global::Gtk.Entry ();
			this.text_debugConstants.TooltipMarkup = "Semicolon (;) separated list of debug constants to define for debug-build compila" +
				"tion.\nImportant: May affect code completion if omitted/written into extra compil" +
				"er options field!";
			this.text_debugConstants.CanFocus = true;
			this.text_debugConstants.Name = "text_debugConstants";
			this.text_debugConstants.IsEditable = true;
			this.text_debugConstants.InvisibleChar = '●';
			this.table1.Add (this.text_debugConstants);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.text_debugConstants]));
			w30.TopAttach = ((uint)(4));
			w30.BottomAttach = ((uint)(5));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.text_ObjectsDirectory = new global::Gtk.Entry ();
			this.text_ObjectsDirectory.CanFocus = true;
			this.text_ObjectsDirectory.Name = "text_ObjectsDirectory";
			this.text_ObjectsDirectory.IsEditable = true;
			this.text_ObjectsDirectory.InvisibleChar = '●';
			this.table1.Add (this.text_ObjectsDirectory);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.text_ObjectsDirectory]));
			w31.TopAttach = ((uint)(7));
			w31.BottomAttach = ((uint)(8));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.text_versionConstants = new global::Gtk.Entry ();
			this.text_versionConstants.TooltipMarkup = "Semicolon (;) separated list of version constants to define for compilation.\nImpo" +
				"rtant: May affect code completion if omitted/written into extra compiler options" +
				" field!";
			this.text_versionConstants.CanFocus = true;
			this.text_versionConstants.Name = "text_versionConstants";
			this.text_versionConstants.IsEditable = true;
			this.text_versionConstants.InvisibleChar = '●';
			this.table1.Add (this.text_versionConstants);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.text_versionConstants]));
			w32.TopAttach = ((uint)(6));
			w32.BottomAttach = ((uint)(7));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table1);
			global::Gtk.Notebook.NotebookChild w33 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.table1]));
			w33.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiling");
			this.notebook1.SetTabLabel (this.table1, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Checking a project in this list will add an include (that points to the respectiv" +
				"e project\'s base directory) to this project automatically.");
			this.label16.Wrap = true;
			this.vbox2.Add (this.label16);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label16]));
			w34.Position = 0;
			w34.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w35 = new global::Gtk.Viewport ();
			w35.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox_ProjectDeps = new global::Gtk.VBox ();
			this.vbox_ProjectDeps.Name = "vbox_ProjectDeps";
			this.vbox_ProjectDeps.Spacing = 6;
			w35.Add (this.vbox_ProjectDeps);
			this.scrolledwindow2.Add (w35);
			this.vbox2.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow2]));
			w38.Position = 1;
			this.notebook1.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w39 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox2]));
			w39.Position = 2;
			// Notebook tab
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Project Dependencies");
			this.notebook1.SetTabLabel (this.vbox2, this.label12);
			this.label12.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			this.vbox7.BorderWidth = ((uint)(3));
			// Container child vbox7.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.TooltipMarkup = "Line-separated list of paths where the compiler (and the code completion engine!)" +
				" shall look in to resolve imports.";
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.text_Includes = new global::Gtk.TextView ();
			this.text_Includes.CanFocus = true;
			this.text_Includes.Name = "text_Includes";
			this.GtkScrolledWindow1.Add (this.text_Includes);
			this.table2.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow1]));
			w41.TopAttach = ((uint)(1));
			w41.BottomAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Note: Relative paths will be related to the project\'s base directory!");
			this.table2.Add (this.label14);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table2 [this.label14]));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.button_AddInclude = new global::Gtk.Button ();
			this.button_AddInclude.CanFocus = true;
			this.button_AddInclude.Name = "button_AddInclude";
			this.button_AddInclude.UseUnderline = true;
			this.button_AddInclude.Label = global::Mono.Unix.Catalog.GetString ("Browse & Add");
			this.table3.Add (this.button_AddInclude);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table3 [this.button_AddInclude]));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table2.Add (this.table3);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table2 [this.table3]));
			w44.TopAttach = ((uint)(1));
			w44.BottomAttach = ((uint)(2));
			w44.LeftAttach = ((uint)(1));
			w44.RightAttach = ((uint)(2));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox7.Add (this.table2);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.table2]));
			w45.Position = 0;
			this.notebook1.Add (this.vbox7);
			global::Gtk.Notebook.NotebookChild w46 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox7]));
			w46.Position = 3;
			// Notebook tab
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Includes");
			this.notebook1.SetTabLabel (this.vbox7, this.label15);
			this.label15.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.cbUseDefaultCompiler.Clicked += new global::System.EventHandler (this.cbUseDefaultCompiler_Clicked);
			this.button_AddInclude.Clicked += new global::System.EventHandler (this.OnButtonAddIncludeClicked);
		}
	}
}
