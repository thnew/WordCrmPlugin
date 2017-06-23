using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace WordCrmPlugin
{
    public partial class KnowledgeBaseSearch : UserControl
    {
        private Document _document;
        private ListViewItem SelectedItem {
            get
            {
                foreach(ListViewItem item in listView1.Items)
                {
                    if (item.Selected)
                    {
                        return item;
                    }
                }

                return null;
            }
        }

        public KnowledgeBaseSearch(Document doc)
        {
            _document = doc;

            InitializeComponent();

            var item = new ListViewItem("Thema A");
            var item2 = new ListViewItem("Thema B");

            listView1.Items.Add(item);
            listView1.Items.Add(item2);
        }
        
        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            var item = SelectedItem;
            if(item == null)
            {
                return;
            }

            _document.Paragraphs[1].Range.InsertParagraphBefore();
            _document.Paragraphs[1].Range.Text = item.Text;
        }
    }
}
