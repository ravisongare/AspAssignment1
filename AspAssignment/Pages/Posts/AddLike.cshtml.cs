using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspAssignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspAssignment.Pages.Posts
{
    public class AddLikeModel : PageModel
    {
        private readonly IData data;

        public AddLikeModel(IData data)
        {
            this.data = data;
        }
        public IActionResult OnGet(int PostId)
        {
            data.AddLike(PostId);
            data.commit();
            return RedirectToPage("./Post");
           
        }
    }
}