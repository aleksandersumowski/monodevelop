
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MonoDroid.Gui
{
	public partial class DeviceChooserDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment bannerPlaceholder;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView deviceListTreeView;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button startEmulatorButton;
		private global::Gtk.Button createEmulatorButton;
		private global::Gtk.Alignment statusPlaceholder;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.MonoDroid.Gui.DeviceChooserDialog
			this.Name = "MonoDevelop.MonoDroid.Gui.DeviceChooserDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Select Device");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child MonoDevelop.MonoDroid.Gui.DeviceChooserDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.bannerPlaceholder = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.bannerPlaceholder.Name = "bannerPlaceholder";
			this.vbox2.Add (this.bannerPlaceholder);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.bannerPlaceholder]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.deviceListTreeView = new global::Gtk.TreeView ();
			this.deviceListTreeView.CanFocus = true;
			this.deviceListTreeView.Name = "deviceListTreeView";
			this.GtkScrolledWindow.Add (this.deviceListTreeView);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w4.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.startEmulatorButton = new global::Gtk.Button ();
			this.startEmulatorButton.CanFocus = true;
			this.startEmulatorButton.Name = "startEmulatorButton";
			this.startEmulatorButton.UseUnderline = true;
			this.startEmulatorButton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child startEmulatorButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w6 = new global::Gtk.HBox ();
			w6.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-play", global::Gtk.IconSize.Menu);
			w6.Add (w7);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w9 = new global::Gtk.Label ();
			w9.LabelProp = global::Mono.Unix.Catalog.GetString ("Start Emulator");
			w9.UseUnderline = true;
			w6.Add (w9);
			w5.Add (w6);
			this.startEmulatorButton.Add (w5);
			this.hbox1.Add (this.startEmulatorButton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.startEmulatorButton]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.createEmulatorButton = new global::Gtk.Button ();
			this.createEmulatorButton.CanFocus = true;
			this.createEmulatorButton.Name = "createEmulatorButton";
			this.createEmulatorButton.UseUnderline = true;
			this.createEmulatorButton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child createEmulatorButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w15 = new global::Gtk.HBox ();
			w15.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w16 = new global::Gtk.Image ();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w15.Add (w16);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w18 = new global::Gtk.Label ();
			w18.LabelProp = global::Mono.Unix.Catalog.GetString ("Create Emulator");
			w18.UseUnderline = true;
			w15.Add (w18);
			w14.Add (w15);
			this.createEmulatorButton.Add (w14);
			this.hbox1.Add (this.createEmulatorButton);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.createEmulatorButton]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.statusPlaceholder = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.statusPlaceholder.Name = "statusPlaceholder";
			this.vbox2.Add (this.statusPlaceholder);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusPlaceholder]));
			w24.Position = 3;
			w24.Expand = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w25.Position = 0;
			// Internal child MonoDevelop.MonoDroid.Gui.DeviceChooserDialog.ActionArea
			global::Gtk.HButtonBox w26 = this.ActionArea;
			w26.Name = "dialog1_ActionArea";
			w26.Spacing = 10;
			w26.BorderWidth = ((uint)(5));
			w26.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonCancel]));
			w27.Expand = false;
			w27.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonOk]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 407;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}