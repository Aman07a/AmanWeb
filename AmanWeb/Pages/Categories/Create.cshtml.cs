using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmanWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmanWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }

        public void OnGet()
        {
        }
    }
}
