using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotSoFunnyPage
{
    public class SubsModel : PageModel
    {
        public static List<string> listOfSubs = new List<string>();
        public void OnGet()
        {

        }
    }
}