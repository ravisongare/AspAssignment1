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
    public class SignUpModel : PageModel
    {
        private readonly IData data;
        [BindProperty]
        public User user1 { get; set; }

        public SignUpModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {
            user1 = new User();
        }
        public IActionResult OnPost()
        {
            data.AddUser(user1);
            data.commit();
            return RedirectToPage("./Post");
        }
    }
}