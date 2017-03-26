using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MoviesDb
    {
        private MovieMonsterEntities db;

        public MoviesDb()
        {
            db = new MovieMonsterEntities();
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies1.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies1.Find(id);
        }

        public void Insert(Movie movie)
        {
            db.Movies1.Add(movie);
            Save();
        }

        public void Delete(int id)
        {
            var movie = db.Movies1.Find(id);
            db.Movies1.Remove(movie);
            Save();
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
