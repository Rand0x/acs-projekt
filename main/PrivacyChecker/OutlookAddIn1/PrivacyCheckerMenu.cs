using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutlookAddIn1
{
    public partial class PrivacyCheckerMenu
    {
        private void PrivacyCheckerMenu_Load(object sender, RibbonUIEventArgs e)
        {
            checkBox_CreditCard.Enabled = false;
        }

        //TODO: Button hinzufügen, der das prüfen aktiviert, basierend auf den Einstellungen.

    }
}
