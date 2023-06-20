using DataAccessLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Test
{
    public class Test
    {
        Repository<Tag> tagRepository = new Repository<Tag>();
        Repository<SocialMediaUser> socialMediaUserRepository = new Repository<SocialMediaUser>();  
        Repository<Post> postRepository = new Repository<Post>();
        Repository<Comment> commentRepository = new Repository<Comment>();
        public void List()
        {
            List<Tag> liste = tagRepository.List();
        }
        public void Insert()
        {
           int result= tagRepository.Insert(new Tag()
            {
                Title = "Yemek",
                Description = "Acıkan var mı ?",
                CreatedTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                ModifyUsername = "iremcelikkanat"
,
            });
        }
        public void CommentTest()
        {
            SocialMediaUser socialMediaUser = socialMediaUserRepository.Find(x => x.Id == 1);
            Post post= postRepository.Find(x => x.Id==1);
            Comment comment = new Comment()
            {
                Text = "Yorum",
                CreatedTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                ModifyUsername = "iremcelikkanat",
                Post = post,
                SocialMediaUser = socialMediaUser
            };
            commentRepository.Insert(comment);

        }
    }
}
