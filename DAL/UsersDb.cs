using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class UsersDb
    {
        private MovieMonsterEntities db;

        public UsersDb()
        {
            db = new MovieMonsterEntities();
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public void Insert(User user)
        {
            db.Users.Add(user);
            Save();
        }

        public void Delete(int id)
        {
            var user = db.Users.Find(id);
            db.Users.Remove(user);
            Save();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
