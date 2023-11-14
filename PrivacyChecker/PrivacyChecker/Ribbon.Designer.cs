namespace PrivacyChecker
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Personendaten = this.Factory.CreateRibbonGroup();
            this.Adresse = this.Factory.CreateRibbonCheckBox();
            this.Geburtsdatum = this.Factory.CreateRibbonCheckBox();
            this.Geburtsort = this.Factory.CreateRibbonCheckBox();
            this.Telefonnummer = this.Factory.CreateRibbonCheckBox();
            this.Sozialverischerungsnr = this.Factory.CreateRibbonCheckBox();
            this.SteuerID = this.Factory.CreateRibbonCheckBox();
            this.Bankdaten = this.Factory.CreateRibbonGroup();
            this.IBAN = this.Factory.CreateRibbonCheckBox();
            this.Kontonummer = this.Factory.CreateRibbonCheckBox();
            this.KreditkartenNr = this.Factory.CreateRibbonCheckBox();
            this.Anhang = this.Factory.CreateRibbonGroup();
            this.AnhaengeAnzeigen = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Personendaten.SuspendLayout();
            this.Bankdaten.SuspendLayout();
            this.Anhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Personendaten);
            this.tab1.Groups.Add(this.Bankdaten);
            this.tab1.Groups.Add(this.Anhang);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // Personendaten
            // 
            this.Personendaten.Items.Add(this.Adresse);
            this.Personendaten.Items.Add(this.Geburtsdatum);
            this.Personendaten.Items.Add(this.Geburtsort);
            this.Personendaten.Items.Add(this.Telefonnummer);
            this.Personendaten.Items.Add(this.Sozialverischerungsnr);
            this.Personendaten.Items.Add(this.SteuerID);
            this.Personendaten.Label = "Personendaten";
            this.Personendaten.Name = "Personendaten";
            // 
            // Adresse
            // 
            this.Adresse.Label = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.Label = "Geburtsdatum";
            this.Geburtsdatum.Name = "Geburtsdatum";
            // 
            // Geburtsort
            // 
            this.Geburtsort.Label = "Geburtsort";
            this.Geburtsort.Name = "Geburtsort";
            // 
            // Telefonnummer
            // 
            this.Telefonnummer.Label = "Telefonnummer";
            this.Telefonnummer.Name = "Telefonnummer";
            // 
            // Sozialverischerungsnr
            // 
            this.Sozialverischerungsnr.Label = "Sozialversicherungsnummer";
            this.Sozialverischerungsnr.Name = "Sozialverischerungsnr";
            // 
            // SteuerID
            // 
            this.SteuerID.Label = "SteuerID";
            this.SteuerID.Name = "SteuerID";
            // 
            // Bankdaten
            // 
            this.Bankdaten.Items.Add(this.IBAN);
            this.Bankdaten.Items.Add(this.Kontonummer);
            this.Bankdaten.Items.Add(this.KreditkartenNr);
            this.Bankdaten.Label = "Bankdaten";
            this.Bankdaten.Name = "Bankdaten";
            // 
            // IBAN
            // 
            this.IBAN.Label = "IBAN";
            this.IBAN.Name = "IBAN";
            // 
            // Kontonummer
            // 
            this.Kontonummer.Label = "Kontonummer";
            this.Kontonummer.Name = "Kontonummer";
            // 
            // KreditkartenNr
            // 
            this.KreditkartenNr.Label = "Kreditkartennummer";
            this.KreditkartenNr.Name = "KreditkartenNr";
            // 
            // Anhang
            // 
            this.Anhang.Items.Add(this.AnhaengeAnzeigen);
            this.Anhang.Label = "Anhang";
            this.Anhang.Name = "Anhang";
            // 
            // AnhaengeAnzeigen
            // 
            this.AnhaengeAnzeigen.Label = "Anhänge anzeigen";
            this.AnhaengeAnzeigen.Name = "AnhaengeAnzeigen";
            this.AnhaengeAnzeigen.ScreenTip = "E-Mails mit Anhang anzeigen";
            this.AnhaengeAnzeigen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Personendaten.ResumeLayout(false);
            this.Personendaten.PerformLayout();
            this.Bankdaten.ResumeLayout(false);
            this.Bankdaten.PerformLayout();
            this.Anhang.ResumeLayout(false);
            this.Anhang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Personendaten;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Geburtsort;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Adresse;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Bankdaten;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Geburtsdatum;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Telefonnummer;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox IBAN;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Kontonummer;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox KreditkartenNr;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Anhang;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Sozialverischerungsnr;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox SteuerID;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AnhaengeAnzeigen;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
