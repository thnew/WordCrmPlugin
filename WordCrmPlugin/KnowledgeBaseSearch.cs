using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace WordCrmPlugin
{
    public partial class KnowledgeBaseSearch : UserControl
    {
        #region Private attributes

        private Document _document;

        #endregion

        #region ctor

        public KnowledgeBaseSearch(Document doc)
        {
            _document = doc;

            InitializeComponent();

            wpfHost.Child = new KnowledgeSearch((string textToPaste) =>
            {
                PasteTextToDocument(textToPaste);
            });
        }

        #endregion

        #region Private methods

        private void PasteTextToDocument(string textToPaste)
        {
            Range currRange = Globals.ThisAddIn.Application.Selection.Range;
            currRange.InsertParagraph();
            currRange.Text = textToPaste;
        }

        #endregion
    }
}
