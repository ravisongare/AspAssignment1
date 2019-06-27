using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspAssignment.Core;
using AspAssignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspAssignment.Pages.Posts
{
    public class AddModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public Post post2 { get; set; }
        
        private readonly IData data;

        public AddModel(IData data)
        {
            this.data = data;
        }
        public IActionResult OnGet()
        {
            post2 = new Post();
            return Page();
        }
        public IActionResult OnPost()
        {
            data.Add(post2);
            data.commit();
            return RedirectToPage("./Post");
        }
       
    }
}