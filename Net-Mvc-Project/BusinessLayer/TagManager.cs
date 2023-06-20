using DataAccessLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class TagManager
    {
        Repository<Tag> repotag = new Repository<Tag>();
        public List<Tag> GetTag()
        {
            return repotag.List();
        }
        //veritabanına bak ordaki id ile benim id'm aynı ise geri döner
        public Tag GetTag(int id)
        {
            return repotag.Find(x=> x.Id == id);
        }

    }
}
