using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class RepositoryBase {

    protected static MvcProjectEntities db;
    private static object obje =new object();
    
        protected RepositoryBase()
        {
            CreateEntities();
        }
        private static void CreateEntities()
        {
       
            if (db == null)
            {
               
                lock (obje)
                {
                    db = new MvcProjectEntities();  
                }
            }
        }







    }


}