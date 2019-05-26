using System;
using App.Data.Access;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
    }
}
