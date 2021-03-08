using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesUI.Pages
{
    public class ListModel : PageModel
    {
        private readonly ILogger<ListModel> _logger;

        public ListModel(ILogger<ListModel> logger)
        {
            _logger = logger;
        }
        public static void OnGet()
        {


        }
    }
}

