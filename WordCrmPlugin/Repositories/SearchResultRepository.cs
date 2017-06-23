using System;
using System.Collections.Generic;
using WordCrmPlugin.Models;

namespace WordCrmPlugin.Repositories
{
    class SearchResultRepository
    {
        #region Internal methods

        /// <summary>
        /// Returns search results for given search text and folder
        /// </summary>
        internal IEnumerable<SearchResult> GetSearchResults(string searchText, string folder)
        {
            // TODO: Replace with real data
            return GenerateExampleSearchResults();
        }

        /// <summary>
        /// Returns all folder names
        /// </summary>
        internal IEnumerable<string> GetFolderNames()
        {
            // TODO: Replace with real data
            return GenerateExampleFolderNames();
        }

        #endregion

        // TODO: Remove / Replace with real data
        #region Example data

        /// <summary>
        /// Just some fake data as long as addin is not connected to CRM
        /// </summary>
        private IEnumerable<SearchResult> GenerateExampleSearchResults()
        {
            return new List<SearchResult> {
                new SearchResult
                {
                    Title = "Wie funktioniert der Bestellvorgang?",
                    Content = "Möchten Sie Ihre ausgewählten Produkte bestellen, so klicken Sie auf „In den Warenkorb“. Durch einen Klick auf das Warenkorbsymbol öffnet sich Ihr Warenkorb und die von Ihnen ausgewählten Produkte werden angezeigt. Jetzt trennen Sie nur noch wenige Schritte vom Abschluss Ihrer Bestellung.Zunächst müssen Sie sich registrieren oder anmelden.Sie haben ebenfalls die Möglichkeit als „Gast“ zu bestellen.Anschließend werden Sie durch den Bestellvorgang geleitet - von der Angabe Ihrer persönlichen Daten, Ihrer gewünschten Lieferoption / Abholoption sowie die Wahl Ihres gewünschten Zahlmittels",
                    Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/6306")
                },
                new SearchResult
                {
                    Title = "Welche Zahlart kann ich auswählen?",
                    Content = "Die folgenden Zahlarten bieten wir Ihnen zur Bezahlung Ihrer Bestellung an: Vorkasse Kreditkarte Geschenkkarte Sofortüberweisung Finanzierung Masterpass Kauf auf Rechnung PayPal Finanzierung",
                    Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/7486")
                },
                new SearchResult
                {
                    Title = "Wie schließe ich meine Bestellung/ Kaufvertrag ab?",
                    Content = "Sofern alle Angaben richtig sind, schließen Sie Ihre Bestellung über den Button „Jetzt kaufen“ ab. Im Anschluss an den Bestellvorgang erhalten Sie eine automatisch generierte Auftragsbestätigung per E - Mail, in der Ihre Bestellung nochmals aufgeführt ist.Diese Auftragsbestätigung dokumentiert lediglich, dass Ihre Bestellung eingegangen ist, stellt aber noch keine Annahme Ihres Angebots dar.Ein Vertrag kommt erst durch unsere Annahmeerklärung, die wir mit einer gesonderten E - Mail versenden, oder durch den Versand der Ware zustande.",
                    Link = new Uri("https://faq.mediamarkt.de/app/answers/detail/a_id/7484")
                }
            };
        }

        /// <summary>
        /// Just some fake data as long as addin is not connected to CRM
        /// </summary>
        private IEnumerable<string> GenerateExampleFolderNames()
        {
            return new List<string> {
                "--All--",
                "HR",
                "IT",
                "Travelcosts"
            };
        }

        #endregion
    }
}
