using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WordCrmPlugin.Models;
using WordCrmPlugin.Repositories;

namespace WordCrmPlugin
{
    /// <summary>
    /// Interaction logic for KnowledgeSearch.xaml
    /// </summary>
    public partial class KnowledgeSearch : UserControl
    {
        #region Properties and attributes

        public delegate void OnSearchResultPaste(string textToPaste);

        private OnSearchResultPaste _searchResultClickHandler;
        private SearchResultRepository _searchResultRepository = new SearchResultRepository();

        #endregion

        #region ctor

        public KnowledgeSearch(OnSearchResultPaste searchResultClickHandler)
        {
            InitializeComponent();

            _searchResultClickHandler = searchResultClickHandler;

            PreFillFolderSelect();
        }

        #endregion

        #region Click handlers

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var searchText = SearchTerm.Text;
            var selectedFolder = FolderSelect.SelectedValue as string;
            var searchResults = _searchResultRepository.GetSearchResults(searchText, selectedFolder);
            AddSearchResultsToUi(searchResults);
        }

        private void PasteIntoDocument(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var textToPaste = button.Tag as string;

            _searchResultClickHandler.Invoke(textToPaste);
        }

        #endregion

        #region Private methods

        private void PreFillFolderSelect()
        {
            var folderNames = _searchResultRepository.GetFolderNames();
            AddFolderNamesToFolderDropdown(folderNames);

            FolderSelect.SelectedIndex = 0;
        }

        private void AddFolderNamesToFolderDropdown(IEnumerable<string> folderNames)
        {
            foreach (var folderName in folderNames)
            {
                FolderSelect.Items.Add(folderName);
            }
        }

        private void AddSearchResultsToUi(IEnumerable<SearchResult> results)
        {
            foreach (var result in results)
            {
                SearchResults.Items.Add(result);
            }
        }

        #endregion
    }
}
