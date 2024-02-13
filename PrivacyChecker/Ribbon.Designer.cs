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
            this.Execute = this.Factory.CreateRibbonGroup();
            this.EMailVerschieben = this.Factory.CreateRibbonButton();
            this.Personendaten = this.Factory.CreateRibbonGroup();
            this.SteuerID = this.Factory.CreateRibbonCheckBox();
            this.Sozialverischerungsnr = this.Factory.CreateRibbonCheckBox();
            this.Geburtsdatum = this.Factory.CreateRibbonCheckBox();
            this.Bankdaten = this.Factory.CreateRibbonGroup();
            this.IBAN = this.Factory.CreateRibbonCheckBox();
            this.KreditkartenNr = this.Factory.CreateRibbonCheckBox();
            this.Zusatz = this.Factory.CreateRibbonGroup();
            this.Anhaenge = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.Execute.SuspendLayout();
            this.Personendaten.SuspendLayout();
            this.Bankdaten.SuspendLayout();
            this.Zusatz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Execute);
            this.tab1.Groups.Add(this.Personendaten);
            this.tab1.Groups.Add(this.Bankdaten);
            this.tab1.Groups.Add(this.Zusatz);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // Execute
            // 
            this.Execute.Items.Add(this.EMailVerschieben);
            this.Execute.Name = "Execute";
            // 
            // EMailVerschieben
            // 
            this.EMailVerschieben.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.EMailVerschieben.Image = global::PrivacyChecker.Properties.Resources.eye_tracking;
            this.EMailVerschieben.Label = "Inhalt der Mails prüfen";
            this.EMailVerschieben.Name = "EMailVerschieben";
            this.EMailVerschieben.ScreenTip = "E-Mails mit den ausgewählten Attributen verschieben";
            this.EMailVerschieben.ShowImage = true;
            this.EMailVerschieben.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMoveEmail_click);
            // 
            // Personendaten
            // 
            this.Personendaten.Items.Add(this.SteuerID);
            this.Personendaten.Items.Add(this.Sozialverischerungsnr);
            this.Personendaten.Items.Add(this.Geburtsdatum);
            this.Personendaten.Label = "Personendaten";
            this.Personendaten.Name = "Personendaten";
            // 
            // SteuerID
            // 
            this.SteuerID.Label = "SteuerID";
            this.SteuerID.Name = "SteuerID";
            this.SteuerID.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_SteuerID);
            // 
            // Sozialverischerungsnr
            // 
            this.Sozialverischerungsnr.Label = "Sozialversicherungsnummer";
            this.Sozialverischerungsnr.Name = "Sozialverischerungsnr";
            this.Sozialverischerungsnr.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_SozialID);
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.Label = "Geburtsdatum";
            this.Geburtsdatum.Name = "Geburtsdatum";
            this.Geburtsdatum.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_Geburtstag);
            // 
            // Bankdaten
            // 
            this.Bankdaten.Items.Add(this.IBAN);
            this.Bankdaten.Items.Add(this.KreditkartenNr);
            this.Bankdaten.Label = "Bankdaten";
            this.Bankdaten.Name = "Bankdaten";
            // 
            // IBAN
            // 
            this.IBAN.Label = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_IBAN);
            // 
            // KreditkartenNr
            // 
            this.KreditkartenNr.Label = "Kreditkartennummer";
            this.KreditkartenNr.Name = "KreditkartenNr";
            this.KreditkartenNr.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_Kreditkartennummer);
            // 
            // Zusatz
            // 
            this.Zusatz.Items.Add(this.Anhaenge);
            this.Zusatz.Label = "Zusatz";
            this.Zusatz.Name = "Zusatz";
            // 
            // Anhaenge
            // 
            this.Anhaenge.Label = "Anhaenge";
            this.Anhaenge.Name = "Anhaenge";
            this.Anhaenge.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkbox_Anhaenge);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Execute.ResumeLayout(false);
            this.Execute.PerformLayout();
            this.Personendaten.ResumeLayout(false);
            this.Personendaten.PerformLayout();
            this.Bankdaten.ResumeLayout(false);
            this.Bankdaten.PerformLayout();
            this.Zusatz.ResumeLayout(false);
            this.Zusatz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Personendaten;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Bankdaten;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox IBAN;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox KreditkartenNr;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Execute;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Sozialverischerungsnr;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox SteuerID;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EMailVerschieben;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Zusatz;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Anhaenge;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Geburtsdatum;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
