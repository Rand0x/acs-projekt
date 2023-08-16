namespace OutlookAddIn1
{
    partial class PrivacyCheckerMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PrivacyCheckerMenu()
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
            this.group1 = this.Factory.CreateRibbonGroup();
            this.checkBox_CreditCard = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Privacy Checker";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.checkBox_CreditCard);
            this.group1.Label = "Einstellungen";
            this.group1.Name = "group1";
            // 
            // checkBox_CreditCard
            // 
            this.checkBox_CreditCard.Label = "Kreditkarte";
            this.checkBox_CreditCard.Name = "checkBox_CreditCard";
            // 
            // PrivacyCheckerMenu
            // 
            this.Name = "PrivacyCheckerMenu";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PrivacyCheckerMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox_CreditCard;
    }

    partial class ThisRibbonCollection
    {
        internal PrivacyCheckerMenu PrivacyCheckerMenu
        {
            get { return this.GetRibbon<PrivacyCheckerMenu>(); }
        }
    }
}
