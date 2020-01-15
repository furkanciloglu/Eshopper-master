using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshopper.Areas.Admin.Models.AppDbContext;
using Eshopper.Areas.Admin.Models.Interface;
using Eshopper.Areas.Admin.Models.Entites;

namespace Eshopper.Areas.Admin.Models.Repositories
{
    public class brandRepository:IRepository<Brand>
    {
        private Context db;
        public brandRepository(Context _db)
        {
            db = _db;
        }

        public void Delete(Brand entity)
        {
            db.Brand.Remove(entity);
            db.SaveChanges();
        }

        public Brand Get(int Id)
        {
            return db.Brand.Find(Id);
        }

        public List<Brand> getAll()
        {
            return db.Brand.ToList();
        }

        public void Save(Brand entity)
        {
            db.Brand.Add(entity);
            db.SaveChanges();
        }

        public void Update(Brand entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}