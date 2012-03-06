
// This file has been generated by the GUI designer. Do not modify.

public partial class SignatureInformationWidget
{
	private global::Gtk.VBox SignatureInformationContainer;
	private global::Gtk.Label lbl_SignatureType;
	private global::Gtk.ComboBox SignatureTypeComboBox;
	private global::Gtk.VBox PgpInfoContainer;
	private global::Gtk.Label lbl_PgpSecretKeyRingLocation;
	private global::Gtk.FileChooserButton PgpSecretKeyRingLocationFileChooser;
	private global::Gtk.Label lbl_PgpSecKeyUsername;
	private global::Gtk.Entry PgpSecKeyUsernameTextBox;
	private global::Gtk.Label lbl_PgpSecretKeyPassphrase;
	private global::Gtk.Entry PgpSecretKeyPassphraseTextBox;
	private global::Gtk.Label lbl_PgpPublicKeyLocations;
	private global::Gtk.Entry PgpPublicKeyLocationsTextBox;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget SignatureInformationWidget
		global::Stetic.BinContainer.Attach (this);
		this.Name = "SignatureInformationWidget";
		// Container child SignatureInformationWidget.Gtk.Container+ContainerChild
		this.SignatureInformationContainer = new global::Gtk.VBox ();
		this.SignatureInformationContainer.Name = "SignatureInformationContainer";
		this.SignatureInformationContainer.Spacing = 6;
		this.SignatureInformationContainer.BorderWidth = ((uint)(9));
		// Container child SignatureInformationContainer.Gtk.Box+BoxChild
		this.lbl_SignatureType = new global::Gtk.Label ();
		this.lbl_SignatureType.Name = "lbl_SignatureType";
		this.lbl_SignatureType.Xalign = 0F;
		this.lbl_SignatureType.LabelProp = global::Mono.Unix.Catalog.GetString ("*Signature Type:");
		this.SignatureInformationContainer.Add (this.lbl_SignatureType);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.SignatureInformationContainer [this.lbl_SignatureType]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child SignatureInformationContainer.Gtk.Box+BoxChild
		this.SignatureTypeComboBox = global::Gtk.ComboBox.NewText ();
		this.SignatureTypeComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("None"));
		this.SignatureTypeComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("LR-PGP 1.0"));
		this.SignatureTypeComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("Sign with CAC Card"));
		this.SignatureTypeComboBox.Name = "SignatureTypeComboBox";
		this.SignatureTypeComboBox.Active = 0;
		this.SignatureInformationContainer.Add (this.SignatureTypeComboBox);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.SignatureInformationContainer [this.SignatureTypeComboBox]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child SignatureInformationContainer.Gtk.Box+BoxChild
		this.PgpInfoContainer = new global::Gtk.VBox ();
		this.PgpInfoContainer.Name = "PgpInfoContainer";
		this.PgpInfoContainer.Spacing = 6;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.lbl_PgpSecretKeyRingLocation = new global::Gtk.Label ();
		this.lbl_PgpSecretKeyRingLocation.Name = "lbl_PgpSecretKeyRingLocation";
		this.lbl_PgpSecretKeyRingLocation.Xalign = 0F;
		this.lbl_PgpSecretKeyRingLocation.LabelProp = global::Mono.Unix.Catalog.GetString ("*Secret Keyring Location:");
		this.PgpInfoContainer.Add (this.lbl_PgpSecretKeyRingLocation);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.lbl_PgpSecretKeyRingLocation]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.PgpSecretKeyRingLocationFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select A File"), ((global::Gtk.FileChooserAction)(0)));
		this.PgpSecretKeyRingLocationFileChooser.Name = "PgpSecretKeyRingLocationFileChooser";
		this.PgpInfoContainer.Add (this.PgpSecretKeyRingLocationFileChooser);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.PgpSecretKeyRingLocationFileChooser]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.lbl_PgpSecKeyUsername = new global::Gtk.Label ();
		this.lbl_PgpSecKeyUsername.Name = "lbl_PgpSecKeyUsername";
		this.lbl_PgpSecKeyUsername.Xalign = 0F;
		this.lbl_PgpSecKeyUsername.LabelProp = global::Mono.Unix.Catalog.GetString ("*User Name:");
		this.PgpInfoContainer.Add (this.lbl_PgpSecKeyUsername);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.lbl_PgpSecKeyUsername]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.PgpSecKeyUsernameTextBox = new global::Gtk.Entry ();
		this.PgpSecKeyUsernameTextBox.CanFocus = true;
		this.PgpSecKeyUsernameTextBox.Name = "PgpSecKeyUsernameTextBox";
		this.PgpSecKeyUsernameTextBox.IsEditable = true;
		this.PgpSecKeyUsernameTextBox.InvisibleChar = '●';
		this.PgpInfoContainer.Add (this.PgpSecKeyUsernameTextBox);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.PgpSecKeyUsernameTextBox]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.lbl_PgpSecretKeyPassphrase = new global::Gtk.Label ();
		this.lbl_PgpSecretKeyPassphrase.Name = "lbl_PgpSecretKeyPassphrase";
		this.lbl_PgpSecretKeyPassphrase.Xalign = 0F;
		this.lbl_PgpSecretKeyPassphrase.LabelProp = global::Mono.Unix.Catalog.GetString ("*Secret Key Passphrase:");
		this.PgpInfoContainer.Add (this.lbl_PgpSecretKeyPassphrase);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.lbl_PgpSecretKeyPassphrase]));
		w7.Position = 4;
		w7.Expand = false;
		w7.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.PgpSecretKeyPassphraseTextBox = new global::Gtk.Entry ();
		this.PgpSecretKeyPassphraseTextBox.CanFocus = true;
		this.PgpSecretKeyPassphraseTextBox.Name = "PgpSecretKeyPassphraseTextBox";
		this.PgpSecretKeyPassphraseTextBox.IsEditable = true;
		this.PgpSecretKeyPassphraseTextBox.InvisibleChar = '●';
		this.PgpInfoContainer.Add (this.PgpSecretKeyPassphraseTextBox);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.PgpSecretKeyPassphraseTextBox]));
		w8.Position = 5;
		w8.Expand = false;
		w8.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.lbl_PgpPublicKeyLocations = new global::Gtk.Label ();
		this.lbl_PgpPublicKeyLocations.Name = "lbl_PgpPublicKeyLocations";
		this.lbl_PgpPublicKeyLocations.Xalign = 0F;
		this.lbl_PgpPublicKeyLocations.LabelProp = global::Mono.Unix.Catalog.GetString ("*Public Key Location(s) (separated by commas):");
		this.PgpInfoContainer.Add (this.lbl_PgpPublicKeyLocations);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.lbl_PgpPublicKeyLocations]));
		w9.Position = 6;
		w9.Expand = false;
		w9.Fill = false;
		// Container child PgpInfoContainer.Gtk.Box+BoxChild
		this.PgpPublicKeyLocationsTextBox = new global::Gtk.Entry ();
		this.PgpPublicKeyLocationsTextBox.CanFocus = true;
		this.PgpPublicKeyLocationsTextBox.Name = "PgpPublicKeyLocationsTextBox";
		this.PgpPublicKeyLocationsTextBox.IsEditable = true;
		this.PgpPublicKeyLocationsTextBox.InvisibleChar = '●';
		this.PgpInfoContainer.Add (this.PgpPublicKeyLocationsTextBox);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.PgpInfoContainer [this.PgpPublicKeyLocationsTextBox]));
		w10.Position = 7;
		w10.Expand = false;
		w10.Fill = false;
		this.SignatureInformationContainer.Add (this.PgpInfoContainer);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.SignatureInformationContainer [this.PgpInfoContainer]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.Add (this.SignatureInformationContainer);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.PgpInfoContainer.Hide ();
		this.Hide ();
		this.SignatureTypeComboBox.Changed += new global::System.EventHandler (this.UpdateSubcontainerVisibility);
	}
}
