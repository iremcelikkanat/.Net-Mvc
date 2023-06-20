//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
            this.Likes = new HashSet<Like>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Nullable<bool> IsDraft { get; set; }
        public Nullable<short> LikeCount { get; set; }
        public Nullable<int> TagId { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string ModifyUsername { get; set; }
        public Nullable<int> SocialMediaUser_Id { get; set; }
        public string PostImage { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual SocialMediaUser SocialMediaUser { get; set; }
        public virtual Tag Tag { get; set; }
    }
}