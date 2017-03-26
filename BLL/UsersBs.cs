using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class UsersBs
    {
        private UsersDb db;

        public UsersBs()
        {
            db = new UsersDb();
        }

        public IEnumerable<User> GetAll()
        {
            return db.GetAll();
        }

        public User GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(User user)
        {
            db.Insert(user);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(User user)
        {
            db.Update(user);
        }
    }
}
