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
    public class PostWithCommentModel : PageModel
    {
        private readonly IData data;
        public IEnumerable<Post> post5;
        public IEnumerable<Comment> comments1;
        [BindProperty(SupportsGet =true)]
        public int id12 { get; set; }
        public PostWithCommentModel(IData data )
        {
            this.data = data;
        }
        public void OnGet(int Postid)
        {
            id12 = Postid;
            post5 = data.GetAll();
            comments1 = data.GetComment(Postid);
        }
    }
}