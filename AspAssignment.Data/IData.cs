using AspAssignment.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspAssignment.Data
{
    public interface IData
    {
        void Add(Post post);
        IEnumerable<Post> GetAll();
        void AddComment(Comment comment);
        void AddLike(int id);
        IEnumerable<Comment> GetComment(int id);
        IEnumerable<User>GetAllUser();
        void AddUser(User user);
        void  commit();
    }
}
