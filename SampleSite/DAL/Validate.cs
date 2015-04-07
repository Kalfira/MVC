using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;

namespace SampleSite.DAL
{
    public class Validate 
    {
        public static bool IsUser(string username, string password)
        {
            DatabaseContext db = new DatabaseContext();
            var users = from p in db.Users
                        where p.username == username
                        select p;
            var list = users.ToList();
            foreach (var entry in list)
            {
                if (username == entry.username && password == entry.password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Register(string user, string pass)
        {
            DatabaseContext db = new DatabaseContext();
         
            if (!db.Users.Any(u => u.username == user))
            {
                db.Users.Add(new Models.User()
                {
                    username = user,
                    password = pass,
                });
                db.SaveChanges();
                return true;
            }
            return false;
            
        }
    }
}