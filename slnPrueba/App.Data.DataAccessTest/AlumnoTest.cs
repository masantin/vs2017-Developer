using System;
using App.Data.Access;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using App.Entities.Base;

namespace App.Data.DataAccessTest
{
    [TestClass]
    public class AlumnoTest
    {
        [TestMethod]
        public void GetAll()
        {
            var da = new AlumnoDA();
            var result = da.GetAll();
            Assert.IsTrue(result.Count()>0);
        }
        [TestMethod]
        public void GetAll2()
        {
            var da = new AlumnoDA();
            var result = da.GetAll2();
            Assert.IsTrue(result.Count() > 0);
        }
        [TestMethod]
        public void Insert()
        {
            var da = new AlumnoDA();

            var alumno = new AlumnoADO();
            alumno.Nombres = "Luis";
            alumno.Apellidos = "Perez";

            var id = da.Insert(alumno);
            Assert.IsTrue(id > 0);
        }
    }
}
