using System;
using DevFramework.Northwind.DataAccess.Concrete.Entityframework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(77,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filter_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(x => x.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
