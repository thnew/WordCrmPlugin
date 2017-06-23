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
using WordCrmPlugin.Models;

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

            PreFillFolderSelect();
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
            var button = sender as Button;

            // TODO: Load real searchResult
            var textToPaste = button.Tag as string;

            _searchResultClickHandler.Invoke(textToPaste);
        }

        #endregion

        #region Private methods

        private void PreFillFolderSelect()
        {
            FolderSelect.Items.Add("--All--");
            FolderSelect.Items.Add("HR");
            FolderSelect.Items.Add("IT");
            FolderSelect.Items.Add("Travelcosts");

            FolderSelect.SelectedIndex = 0;
        }

        private void AddExampleSearchResult()
        {
            SearchResults.Items.Add(new SearchResult
            {
                Title = "What are the high level features included in Contoso Business Solutions?",
                Content = "Contoso Business Solutions has these features included:Social listeing Social media analytics Workflows and approvals Sales automations Cutomer experience",
                Link = new Uri("http://google.de")
            });
        }

        #endregion
    }
}
