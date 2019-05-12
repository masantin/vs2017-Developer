using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Data.DataAccess;
using App.Entities.Base;

namespace App.Data.DataAccessTest
{
    
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void GetAll()
        {
            var da = new CustomerDA();

            var lista = da.GetAll("Artista Update Test Correa");

            Assert.IsTrue(lista.Count > 0);

        }
      
        [TestMethod]
        public void Insert()
        {
            var da = new CustomerDA();

            var entity = new Customer();
            entity.FirstName = "Luis Artista Test";
            entity.LastName = "Correa";
            entity.Company = "Nestle";
            entity.Address = "Ad.jasa";
            entity.City = "Lima";
            entity.State = "Lima";
            entity.Country = "Perú";
            entity.PostalCode = "1234";
            entity.Phone = "232345";
            entity.Fax = "34343";
            entity.Email = "aksjaksj@fmaks.com";
            entity.SupportRepId = null;

            var id = da.Insert(entity);

            Assert.IsTrue(id > 0);

        }

        [TestMethod]
        public void Update()
        {
            var da = new CustomerDA();

            var entity = new Customer();
            entity.CustomerId = 60;
            entity.FirstName = "Artista Update Test";
            entity.LastName = "Correa";
            entity.Company = "Nestle";
            entity.Address = "Ad.jasa";
            entity.City = "Lima";
            entity.State = "Lima";
            entity.Country = "Perú";
            entity.PostalCode = "1234";
            entity.Phone = "232345";
            entity.Fax = "34343";
            entity.Email = "aksjaksj@fmaks.com";
            entity.SupportRepId = null;

            var result = da.Update(entity);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Delete()
        {
            var da = new CustomerDA();

            //Agregando un registro
            var entity = new Customer();
            entity.FirstName = "Artista Test";
            entity.LastName = "Correa";
            entity.Company = "Nestle";
            entity.Address = "Ad.jasa";
            entity.City = "Lima";
            entity.State = "Lima";
            entity.Country = "Perú";
            entity.PostalCode = "1234";
            entity.Phone = "232345";
            entity.Fax = "34343";
            entity.Email = "aksjaksj@fmaks.com";
            entity.SupportRepId = null;
            var id = da.Insert(entity);

            //Eliminando el registro
            var result = da.Delete(id);

            Assert.IsTrue(result);
        }
    }
}
