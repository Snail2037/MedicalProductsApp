using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages
{
    public class DatabaseModel : PageModel
    {

        public void OnGet()
        {
           
        }
        public class Products
        {
            public string Medication { get; set; }
            public string Symptom { get; set; }
            public string Date { get; set; }
        }

    }
}
