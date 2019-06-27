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
    public class PostModel : PageModel
    {
       public IEnumerable<Post> post5;
        readonly IData data;

        public PostModel(IData data)
        {
            this.data = data;
        }

        public void OnGet()
        {
            post5 = data.GetAll();

        }

      

       
    }
}