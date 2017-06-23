using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools;

namespace WordCrmPlugin
{
    public partial class ThisAddIn
    {
        //private void ThisAddIn_Startup(object sender, System.EventArgs e)
        //{
        //}

        //private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        //{
        //}

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler((Word.Document doc) => {
                KnowledgeBaseSearch ctrl = new KnowledgeBaseSearch(doc);
                string title = "Knowledgebase Articles";
                CustomTaskPane ctp = Globals.ThisAddIn.CustomTaskPanes.Add(ctrl, title);
                ctp.Visible = true;
                ctp.Width = 220;
                ctp.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
            });

            //Startup += new EventHandler(ThisAddIn_Startup);
            //Shutdown += new EventHandler(ThisAddIn_Shutdown);
            Application.DocumentBeforeSave += new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler((Word.Document Doc, ref bool SaveAsUI, ref bool Cancel) =>
            {
                Doc.Paragraphs[1].Range.InsertParagraphBefore();
                Doc.Paragraphs[1].Range.Text = "Thomas.";

            });
        }

        #endregion
    }
}
