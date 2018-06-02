using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LNBServer.Pages
{
    public class AboutModel : PageModel
    {
        public string Subtitle { get; set; }
        public string MainParagraph { get; set; }

        public void OnGet()
        {
            Subtitle = "LNB: Light Novel Tracking Project";
            MainParagraph = "A project to make tracking your light novels easier and better than sites like Kitsu and MAL do.";
        }
    }
}
