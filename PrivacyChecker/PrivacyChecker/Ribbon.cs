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
        List<bool> CheckboxenListe;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            myLogic = new Logic(Globals.ThisAddIn.Application);

            CheckboxenListe = new List<bool>
            {
                Adresse.Checked,
                Sozialverischerungsnr.Checked,
                Geburtsdatum.Checked,
                SteuerID.Checked,
                IBAN.Checked,
                Kontonummer.Checked,
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

        private void checkbox_Adresse(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[0] = Adresse.Checked;
        }

        private void checkbox_SozialID(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[1] = Sozialverischerungsnr.Checked;
        }

        private void checkbox_Geburtstag(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[2] = Geburtsdatum.Checked;
        }

        private void checkbox_SteuerID(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[3] = SteuerID.Checked;
        }

        private void checkbox_IBAN(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[4] = IBAN.Checked;
        }

        private void checkbox_Kontonummer(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[5] = Kontonummer.Checked;
        }

        private void checkbox_Kreditkartennummer(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[6] = KreditkartenNr.Checked;
        }

        private void checkbox_Anhaenge(object sender, RibbonControlEventArgs e)
        {
            CheckboxenListe[7] = Anhaenge.Checked;
        }
        #endregion
    }
}
