using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LNBServer
{
    public class AmazonInfoScraper
    {
        private ISBN _isbn;
        private string _url;
        private HttpClient _client;
        private string _html;
        
        public AmazonInfoScraper(ISBN isbn)
        {
            _isbn = isbn;
            _url = "https://www.amazon.co.jp/dp/" + _isbn.getIsbn();
            _client = new HttpClient();
            _html = _client.GetStringAsync(_url).Result;
            
        }

        public string getImageURL()
        {
            var searchString = "id=\"imgBlkFront\" data-a-dynamic-image=\"{&quot;";

            var index = _html.IndexOf(searchString) + searchString.Length;
            var lastIndex = _html.IndexOf("&quot;", index);

            var url = _html.Substring(index, lastIndex - index);

            index = url.IndexOf('.', url.LastIndexOf('/'));
            lastIndex = url.LastIndexOf('.');

            var trimmedURL = url.Substring(0, index) + url.Substring(lastIndex);
            return trimmedURL;
        }


        public string getDescription()
        {
            var enterDivSearchString = "<div id=\"productDescription\"";
            var leaveDivSearchString = "</div>";
            var leaveH3SearchString = "</h3>";
            var enterPSearchString = "<p>";
            var leavePSearchString = "</p>";

            var productDescIndex = _html.IndexOf(enterDivSearchString);
            var productDescEndex = _html.IndexOf(leaveDivSearchString, productDescIndex);

            var fullDescription = _html.Substring(productDescIndex, productDescEndex - productDescIndex);

            var h3Index = fullDescription.IndexOf(leaveH3SearchString) + leaveH3SearchString.Length;
            h3Index = fullDescription.IndexOf(leaveH3SearchString, h3Index); // Find the 2nd "</h3>"

            var lastParagraphIndex = fullDescription.IndexOf(enterPSearchString, h3Index) + enterPSearchString.Length;
            var lastParagraphEndex = fullDescription.IndexOf(leavePSearchString, lastParagraphIndex);

            var description = fullDescription.Substring(lastParagraphIndex, lastParagraphEndex - lastParagraphIndex).Trim();
            return description;
        }



    }
}
