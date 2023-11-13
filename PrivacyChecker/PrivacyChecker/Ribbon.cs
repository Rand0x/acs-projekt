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
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            Geburtsort.Checked = true;

        }


        private void button1_Click(object sender, RibbonControlEventArgs e) // Button Anhänge anzeigen
        {
            Microsoft.Office.Interop.Outlook.Application outlookApp = Globals.ThisAddIn.Application;
            Microsoft.Office.Interop.Outlook.NameSpace outlookNameSpace = outlookApp.GetNamespace("MAPI");
            Microsoft.Office.Interop.Outlook.MAPIFolder inbox = outlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

            StringBuilder emailList = new StringBuilder(); // Instanz

            foreach (object item in inbox.Items) // geht alle E-Mails im Posteingang durch
            {
                if (item is Microsoft.Office.Interop.Outlook.MailItem email) // wenn E-Mails gefunden wurde
                {
                    if (email.Attachments.Count > 0) // zählt alle E-Mails mit Anhang
                    {
                        emailList.AppendLine($"Betreff: {email.Subject}"); // nimmt den Betreff der E-Mails mit Anhang
                    }

                }

            }

            if (emailList.Length > 0)
            {
                MessageBox.Show(emailList.ToString(), "E-Mails mit Anhängen"); // Objekt gibt Liste mit Betreffzeilen der E-Mails aus, die einen Anhang haben
            }
            else
            {
                MessageBox.Show("Es wurden keine E-Mails mit Anhängen gefunden.", "E-Mails mit Anhängen");
            }


        }

    }
}
