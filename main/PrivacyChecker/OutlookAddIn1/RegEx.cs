using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookAddIn1
{
    internal class RegEx
    {
        /* Was wird mit Regex gemacht?
         * Es werden Muster erkannt in Texten
         */

        // Regular Expressions -> Static! Damit man keinen einen Konstrukter braucht!
        public RegEx() { }



        #region Betreff überprüfen
        //TODO: Email-Betreff prüfen auf Bestimmten Keywörtern
        public static bool ContainsSubjectKeyword(string emailSubject) { return false; }
        #endregion

        #region Inhalt überprüfen

        //TODO: Regual Expression um Kreditkarte herrauszufinden
        public static bool ContainsCreditCard(string emailBody) { return false; }
        
        //TODO: Namen bzw. Vornamen
        public static bool ContainsName(string emailBody) { return false; }

        //TODO: Geburtsort / Stadt
        public static bool ContainsCity(string emailBody) { return false; }
        
        //TODO: Straße + Hausnummer
        public static bool ContainsStreet(string emailBody) { return false; }
        #endregion



    }
}
