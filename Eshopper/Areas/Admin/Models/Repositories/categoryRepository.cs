using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshopper.Areas.Admin.Models.AppDbContext;
using Eshopper.Areas.Admin.Models.Interface;
using Eshopper.Areas.Admin.Models.Entites;

namespace Eshopper.Areas.Admin.Models.Repositories
{
    public class categoryRepository:IRepository<category>
    {
        private Context db;
        public categoryRepository(Context _db)
        {
            db = _db;
        }

        public void Delete(category entity)
        {
            db.Category.Remove(entity);
            db.SaveChanges();
        }

        public category Get(int Id)
        {
            return db.Category.Find(Id);
        }

        public List<category> getAll()
        {
            return db.Category.ToList();
        }

        public void Save(category entity)
        {
            db.Category.Add(entity);
            db.SaveChanges();
        }

        public void Update(category entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}