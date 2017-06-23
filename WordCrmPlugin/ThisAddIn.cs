using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace WordCrmPlugin
{
    public partial class ThisAddIn
    {
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler((Word.Document doc) => {
                KnowledgeBaseSearch ctrl = new KnowledgeBaseSearch(doc);
                string title = "Knowledge";
                CustomTaskPane ctp = Globals.ThisAddIn.CustomTaskPanes.Add(ctrl, title);
                ctp.Visible = true;
                ctp.DockPositionRestrict = Office.MsoCTPDockPositionRestrict.msoCTPDockPositionRestrictNoHorizontal;
                ctp.Width = 330;
                ctp.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
            });
        }

        #endregion
    }
}
