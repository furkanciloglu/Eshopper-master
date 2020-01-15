using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshopper.Areas.Admin.Models.AppDbContext;
using Eshopper.Areas.Admin.Models.Interface;
using Eshopper.Areas.Admin.Models.Entites;

namespace Eshopper.Areas.Admin.Models.Repositories
{
    public class productRepository : IRepository<Product>
    {
        private Context db;
        public productRepository(Context _db)
        {
            db = _db;
        }

        public void Delete(Product entity)
        {
            db.Product.Remove(entity);
            db.SaveChanges();
        }

        public Product Get(int Id)
        {
            return db.Product.Find(Id);
        }

        public List<Product> getAll()
        {
            return db.Product.ToList();
        }

        public void Save(Product entity)
        {
            db.Product.Add(entity);
            db.SaveChanges();
        }

        public void Update(Product entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}