using Microsoft.Office.Tools.Outlook;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System.Xml.Linq;

namespace playground
{
    public partial class Menu
    {
        public ThisAddIn addin;

        private void Menu_Load(object sender, RibbonUIEventArgs e)
        {
            addin = Globals.ThisAddIn;
        }

        //Methoden hinter den Buttons werden hier hinterlegt:

        private void Iterate_Click(object sender, RibbonControlEventArgs e)
        { 
            addin.l.iterateEmails();
        }

        private void Move_Click(object sender, RibbonControlEventArgs e)
        {
            addin.l.moveEmail("ToDelete");
        }

        private void CreateFolder_Click(object sender, RibbonControlEventArgs e)
        {
            addin.l.createNewFolder("ToDelete");
        }
    }
}
