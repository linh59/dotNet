using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.EF;


namespace ClassLibrary1.Dao
{
    public class UserDao
    {
        OnlineShop db = null;
        public UserDao()
        {
            db = new OnlineShop();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public int Login (string userName, string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);

            if (result == null)
            {
                
                return 0;
            }
            else
            {
                if (result.Password == passWord)
                {
                    return 1;
                }
                else
                {
                    Console.Write(result);
                    return -2;
                }
            }
        }
  
    }
}
