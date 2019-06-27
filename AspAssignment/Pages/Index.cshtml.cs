using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspAssignment.Core;
using AspAssignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IData data;

        [BindProperty]
        public IEnumerable<User> user1 { get; set; }
        [BindProperty]
       public string Name { get; set; }
        [BindProperty]
       public string Password { get; set; }

        public IndexModel(IData data)
        {
            this.data = data;
        }
        //public void OnGet()
        //{
            
        //}
        public IActionResult OnPost()
        {
            user1 = data.GetAllUser();
            foreach (var temp in user1)
            {
                if (temp.Email == Name && temp.Password == Password)
                   return RedirectToPage("/Posts/Post");
            }  
            return RedirectToPage("./Error");

        }
    }
}
