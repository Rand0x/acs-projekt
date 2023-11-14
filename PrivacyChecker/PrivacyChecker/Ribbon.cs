using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivacyChecker
{
    public partial class Ribbon
    {
        private Logic myLogic;
        List<bool> Checkboxen;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            myLogic = new Logic(Globals.ThisAddIn.Application);
            Checkboxen = new List<bool>
            {
                Adresse.Checked,
                Sozialverischerungsnr.Checked,
                Geburtsdatum.Checked,
                SteuerID.Checked,
                IBAN.Checked,
                Kontonummer.Checked,
                KreditkartenNr.Checked
            };
        }

        private void buttonMoveEmail_click(object sender, RibbonControlEventArgs e)
        {
            myLogic.iterateEmails();
        }



        //Region:
        #region Checkboxen in Liste setzen

        private void checkbox_Adresse(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[0] = Adresse.Checked;
        }

        private void checkbox_SozialID(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[1] = Sozialverischerungsnr.Checked;
        }

        private void checkbox_Geburtstag(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[2] = Geburtsdatum.Checked;
        }

        private void checkbox_SteuerID(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[3] = SteuerID.Checked;
        }

        private void checkbox_IBAN(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[4] = IBAN.Checked;
        }

        private void checkbox_Kontonummer(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[5] = Kontonummer.Checked;
        }

        private void checkbox_Kreditkartennummer(object sender, RibbonControlEventArgs e)
        {
            Checkboxen[6] = KreditkartenNr.Checked;
        }
        #endregion
    }
}
