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
                Title = "Wie funktioniert der Bestellvorgang?",
                Content = "Möchten Sie Ihre ausgewählten Produkte bestellen, so klicken Sie auf „In den Warenkorb“. Durch einen Klick auf das Warenkorbsymbol öffnet sich Ihr Warenkorb und die von Ihnen ausgewählten Produkte werden angezeigt. Jetzt trennen Sie nur noch wenige Schritte vom Abschluss Ihrer Bestellung.Zunächst müssen Sie sich registrieren oder anmelden.Sie haben ebenfalls die Möglichkeit als „Gast“ zu bestellen.Anschließend werden Sie durch den Bestellvorgang geleitet - von der Angabe Ihrer persönlichen Daten, Ihrer gewünschten Lieferoption / Abholoption sowie die Wahl Ihres gewünschten Zahlmittels",
                Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/6306")
            });
            SearchResults.Items.Add(new SearchResult
            {
                Title = "Welche Zahlart kann ich auswählen?",
                Content = "Die folgenden Zahlarten bieten wir Ihnen zur Bezahlung Ihrer Bestellung an: Vorkasse Kreditkarte Geschenkkarte Sofortüberweisung Finanzierung Masterpass Kauf auf Rechnung PayPal Finanzierung",
                Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/7486")
            });
            SearchResults.Items.Add(new SearchResult
            {
                Title = "Wie schließe ich meine Bestellung/ Kaufvertrag ab?",
                Content = "Sofern alle Angaben richtig sind, schließen Sie Ihre Bestellung über den Button „Jetzt kaufen“ ab. Im Anschluss an den Bestellvorgang erhalten Sie eine automatisch generierte Auftragsbestätigung per E - Mail, in der Ihre Bestellung nochmals aufgeführt ist.Diese Auftragsbestätigung dokumentiert lediglich, dass Ihre Bestellung eingegangen ist, stellt aber noch keine Annahme Ihres Angebots dar.Ein Vertrag kommt erst durch unsere Annahmeerklärung, die wir mit einer gesonderten E - Mail versenden, oder durch den Versand der Ware zustande.",
                Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/7484")
            });
        }

        #endregion
    }
}
