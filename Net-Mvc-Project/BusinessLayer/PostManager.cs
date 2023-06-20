using DataAccessLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PostManager
    {
        Repository<Post> repositorypost = new Repository<Post>();
        public List<Post> GetPosts()
        {
            return repositorypost.List();
        }
    }
}
