using Microsoft.Office.Tools.Ribbon;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrivacyChecker
{
    public partial class Ribbon
    {
        private Logic myLogic;
        List<bool> CheckboxenListe;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            myLogic = new Logic(Globals.ThisAddIn.Application);

            CheckboxenListe = new List<bool>
            {
                Sozialverischerungsnr.Checked,
                Geburtsdatum.Checked,
                SteuerID.Checked,
                IBAN.Checked,
                KreditkartenNr.Checked,
                Anhaenge.Checked,
            };
        }

        private void buttonMoveEmail_click(object sender, RibbonControlEventArgs e)
        {
            bool nothingSelected = true;
            foreach (bool c in CheckboxenListe)
            {
                if (c) { nothingSelected = false; break; }
            }

            if(nothingSelected)
            {
                MessageBox.Show("Bitte wählen Sie zuerst nach welchen Daten gesucht werden soll und probieren Sie es nochmal", "Keine Auswahl");
            }
            else
            {
                myLogic.iterateEmails(CheckboxenListe);
            }
        }

        //Region:
        #region Checkboxen in Liste setzen

        private void checkbox_SozialID(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[0] = Sozialverischerungsnr.Checked;
        }

        private void checkbox_Geburtstag(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[1] = Geburtsdatum.Checked;
        }

        private void checkbox_SteuerID(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[2] = SteuerID.Checked;
        }

        private void checkbox_IBAN(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[3] = IBAN.Checked;
        }

        private void checkbox_Kreditkartennummer(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[4] = KreditkartenNr.Checked;
        }

        private void checkbox_Anhaenge(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[5] = Anhaenge.Checked;
        }
        #endregion
    }
}
