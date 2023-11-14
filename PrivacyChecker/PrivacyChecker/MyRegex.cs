using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrivacyChecker
{
    static public class MyRegex
    {
        static public bool ContainsCreditCard(string emailBody)
        {
            Regex regexCreditCards = new Regex(
                @"(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|3[47][0-9]{13})",
                RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.IgnoreCase);
            string replacedString = Regex.Replace(emailBody, @"(?<=\d)[\s-](?=\d)", "");
            return regexCreditCards.IsMatch(replacedString);
        }

        static public bool ContainsVersicherungsnummer(string emailBody)
        {
            Regex regexSozialRentenversicherungsnummer = new Regex(
                @"(:?0[2-4|8-9]|1[0-9]|2[01]|2[3-6]|2[89]|3[89]|40|4[2-9]|[5-7][0-9]|8[0-2]|89)(:?0[1-9]|[1-2][0-9]|3[0-1])(:?0[1-9]|1[0-2])(:?[0-9][0-9])(:?[A-Z])(:?[0-9][0-9])([0-9])",
                RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.IgnoreCase);
            string replacedString = Regex.Replace(emailBody, @"(?<=\d)[\s-](?=\d)", "");
            replacedString = Regex.Replace(replacedString, @"(?<=\w)[\s-](?=\w)", "");
            return regexSozialRentenversicherungsnummer.IsMatch(replacedString);
        }

        static public bool ContainsIdNr(string emailBody)
        {
            Regex regexSteuerIdNr = new Regex(
                @"(:?[0-9]{11})",
                RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

            string replacedString = Regex.Replace(emailBody, @"(?<=\d)[\s-\.](?=\d)", "");
            Match currentMatch = regexSteuerIdNr.Match(replacedString);

            // von der idNr die Prüfziffer prüfen nach ISO/IEC 7064
            string idNr = currentMatch.Value;
            int produkt = 10;
            int checkNum = 0;
            int summe = 0;

            while (currentMatch.Value != "")
            {
                for (int i = 0; i < idNr.Length - 1; i++)
                {
                    summe = (idNr[i] - 48 + produkt) % 10;
                    if (summe == 0) { summe = 10; }
                    produkt = (summe * 2) % 11;
                }
                checkNum = 11 - produkt;
                if (checkNum == 10) { checkNum = 0; }
                if (idNr[10] - 48 == checkNum) { return true; } // IdNr gefunden
                else
                {
                    //Werte neu setzen
                    currentMatch = currentMatch.NextMatch();
                    idNr = currentMatch.Value;
                    checkNum = 0;
                    summe = 0;
                    produkt = 10;
                }
            }
            return false;
        }

        static public bool ContainsDate(string emailBody)
        {
            Regex regexDatum = new Regex(
                @"(?:(:?0{0,1}[1-9])|(:?[12][0-9])|(:?3[01]))[-\./](:?(:?0[1-9])|(:?(1[0-2])))[-\./](:?\d{2,4})",
                RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            return regexDatum.IsMatch(emailBody);
        }

        static public bool ContainsIBAN(string emailBody)
        {
            Regex regexIBAN = new Regex(
                @"(:?(?:DE[0-9]{20})|(?:AT[0-9]{18})|(?:CH[0-9]{19}))",
                RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            string replacedString = Regex.Replace(emailBody, @"(?<=\d)[\s-](?=\d)", "");
            replacedString = Regex.Replace(replacedString, @"(?<=\w)[\s-](?=\w)", "");
            return regexIBAN.IsMatch(replacedString);
        }

        static public bool ContainsAddress(string emailBody) //Funktioniert glaube ich nicht
        {
            Regex regexAddress = new Regex(
                @"((Ober|Unter den|An |Im |Platz |Berg |Am |Alt\\-).+|(?:([A-Z][a-zäüö-]+){1,2})).([Cc]haussee|[Aa]llee|[sS]tr(\\.|(a(ss|ß)e))|[Rr]ing|berg|gasse|grund|hörn| Nord|graben|[mM]arkt|[Uu]fer|[Ss]tieg|[Ll]inden|[Dd]amm|[pP]latz|brücke|Steinbüchel|Burg|stiege|[Ww]eg|rain|park|[Ww]eide|[Hh][oö]f|pfad|garten|bogen).+?(\\d{1,4})([a-zäöüß]+)?(\\-?\\d{1,4}[a-zäöüß]?)?",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return regexAddress.IsMatch(emailBody);
        }
    }
}
