using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace App.Data.DataAccess
{
    public class CustomerDA
    {
        public List<Customer> GetAll(string nombres)
        {
            var result = new List<Customer>();
            using(var db = new DBModel())
            {
                result = db.Customer
                    .Where(item=>String.Concat(item.FirstName," ",
                                        item.LastName).Contains(nombres))
                    .OrderBy(item=>item.LastName).ThenBy(item=>item.FirstName)
                    .ToList();
            }

            return result;
        }

        public Customer Get(int id)
        {
            var result = new Customer();
            using(var db = new DBModel())
            {
                result = db.Customer.Find(id);
            }
            return result;
        }

        public int Insert(Customer entity)
        {
            var result = 0;
            using(var db = new DBModel())
            {
                db.Customer.Add(entity);
                db.SaveChanges();

                result = entity.CustomerId;
            }
            return result;         
        }

        public bool Update(Customer entity)
        {
            var result = false;
            using(var db = new DBModel())
            {
                db.Customer.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;

            }
            return result;
        }

        public bool Delete(int id)
        {
            var result = false;

            using (var db = new DBModel())
            {
                var entity = new Customer();
                entity.CustomerId = id;

                db.Customer.Attach(entity);
                db.Customer.Remove(entity);
               
                db.SaveChanges();

                result = true;
            }

            return result;
        }

    }
}
