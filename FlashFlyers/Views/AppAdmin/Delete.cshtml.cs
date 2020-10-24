using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FlashFlyers.Views.AppAdmin
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public EventModel Event { get; set; }
        public void OnGet()
        {
        }
    }
}
