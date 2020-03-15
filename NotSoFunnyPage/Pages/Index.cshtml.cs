using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NotSoFunnyPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost([FromForm(Name ="mail")]string mail)
        {
            if(!SubsModel.listOfSubs.Contains(mail))
            {
                SubsModel.listOfSubs.Add(mail);
            }
            Response.Redirect("Subs");
        }
    }
}
