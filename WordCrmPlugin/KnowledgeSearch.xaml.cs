using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordCrmPlugin
{
    /// <summary>
    /// Interaction logic for KnowledgeSearch.xaml
    /// </summary>
    public partial class KnowledgeSearch : UserControl
    {
        #region Properties

        public delegate void OnSearchResultPaste(string textToPaste);
        private OnSearchResultPaste _searchResultClickHandler;

        #endregion

        #region ctor

        public KnowledgeSearch(OnSearchResultPaste searchResultClickHandler)
        {
            InitializeComponent();

            _searchResultClickHandler = searchResultClickHandler;

            AddExampleSearchResult();
        }

        #endregion

        #region Click handlers

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            AddExampleSearchResult();
        }

        private void PasteIntoDocument(object sender, RoutedEventArgs e)
        {
            // TODO: Load real searchResult
            var textToPaste = "Test";

            _searchResultClickHandler.Invoke(textToPaste);
        }

        #endregion

        #region Private methods

        private void AddExampleSearchResult()
        {
            FolderSelect.Items.Add("--All--");
            FolderSelect.Items.Add("HR");
            FolderSelect.Items.Add("IT");
            FolderSelect.Items.Add("Travelcosts");

            FolderSelect.SelectedIndex = 0;

            SearchResults.Items.Add("dffgd");
        }

        #endregion
    }
}
