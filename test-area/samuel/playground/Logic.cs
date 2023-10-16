using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace playground
{
    public class Logic
    {
        //Wird im Konstruktor zugewiesen
        public Outlook.Application app;

        //Der Konstruktor von Logic bekommt die Outlook-App übergeben
        public Logic(Outlook.Application a)
        {
            app = a;
        }

        //Methode um eine Nachricht mit dem Inhalt "message" anzuzeigen
        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        //Methode iteriert durch alle E-Mails im Ordner Posteingang und kann auf den E-Mails Aktionen ausführen (aktuell nonsens) 
        public void iterateEmails()
        {
            Outlook.MAPIFolder inbox = app.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items items = inbox.Items;

            int c = 0;

            foreach (object item in items)
            {
                if (item is Outlook.MailItem mailItem)
                {
                    if (c > 3)
                        break;

                    c++;

                    // Zugriff auf die E-Mail-Eigenschaften
                    string subject = mailItem.Subject;
                    string senderName = mailItem.SenderName;
                    DateTime receivedTime = mailItem.ReceivedTime;
                    string body = mailItem.Body;

                    // Führe hier weitere Aktionen mit den E-Mail-Daten aus
                    // ...

                    // Beispiel: Drucke die E-Mail-Informationen
                    showMessage(subject);
                    //Console.WriteLine("Subject: " + subject);
                    //Console.WriteLine("Sender: " + senderName);
                    //Console.WriteLine("Received Time: " + receivedTime);
                    //Console.WriteLine("Body: " + body);
                    //Console.WriteLine("=============================");
                }
            }
        }

        //Methode verschiebt die aktuell in Outlook ausgewählte E-Mail in einen spezifizierten "targetFolder"
        //Wenn der Target-Folder nicht existiert wird eine Fehler-Meldung ausgegeben
        public void moveEmail(string targetFolder)
        {
            Outlook.Explorer explorer = app.ActiveExplorer();

            //Prüft, ob aktuell eine E-Mail ausgewählt ist
            if (explorer.Selection.Count > 0 && explorer.Selection[1] is Outlook.MailItem selectedMail)
            {
                Outlook.NameSpace outlookNamespace = app.GetNamespace("MAPI");

                //Prüft, ob ein korrkter Target-Folder übergeben wurde und ob dieser Target-Folder existiert
                if (targetFolder != null && FolderExists(outlookNamespace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox).Parent, targetFolder))
                {
                    Outlook.MAPIFolder targetFolderName = outlookNamespace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox).Parent.Folders[targetFolder];
                
                    selectedMail.Move(targetFolderName);
                    showMessage("Email moved to folder: " + targetFolder);
                }

                else
                {
                    showMessage("Specified Target-Folder not found.");
                }
            }
            else
            {
                showMessage("No email selected.");
            }

        }

        //Methode prüft ob ein Ordnername "folderName" in einem Ordner "parentFolder" existiert
        private static bool FolderExists(Outlook.MAPIFolder parentFolder, string folderName)
        {
            foreach (Outlook.MAPIFolder folder in parentFolder.Folders)
            {
                if (folder.Name == folderName)
                {
                    return true;
                }
            }
            return false;
        }

        //Methode um einen Ordner mit Name "newFolderName" auf der selben Ebene wie Inbox zu erstellen
        //Es wird geprüft ob der Ordner bereits existiert
        public void createNewFolder(string newFolderName)
        {
            //Der Ordner wird auf der selben Ebene wie Inbox, also im Parent-Ordner von Inbox erstellt
            Outlook.NameSpace outlookNamespace = app.GetNamespace("MAPI");
            Outlook.MAPIFolder parentFolder = outlookNamespace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox).Parent as Outlook.MAPIFolder;

            if (parentFolder != null)
            {
                //Wenn Ordner bereits existiert: Fehler ausgeben
                if (FolderExists(parentFolder, newFolderName))
                {
                    showMessage("This folder already exists: " + newFolderName);
                }

                //Ansonsten Erfolg melden
                else
                {
                    parentFolder.Folders.Add(newFolderName, Outlook.OlDefaultFolders.olFolderInbox);
                    showMessage("Custom folder created: " + newFolderName);
                }
            }
            else
            {
                showMessage("Parent folder not found.");
            }
        }
    }
}

