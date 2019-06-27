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
    public class CommentPageModel : PageModel
    {   
        [BindProperty]
        public Comment comment { get; set; }
        
        private readonly IData data;

        public CommentPageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet(int Postid)
        {
            comment = new Comment();
            comment.PostId = Postid;
           
        }
        public IActionResult OnPost()
        {
           
            data.AddComment(comment);
            data.commit();
            return RedirectToPage("./Post");
        }
    }
}