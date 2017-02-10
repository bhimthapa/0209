using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Data;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertDataInToEmployments()
        {
            WebApiDbContext dat = new WebApiDbContext();
            dat.Employments.Add(new WebApi.Data.Entities.Employment
            {
                //EmploymentId = 1,
                FirstName = "Barun",
                LastName = "Paudel",
                Salary = 21345,
                Address = "Virginia",
                PhoneNo = "7045678976"

                //EmploymentId = 2,
                //FirstName = "Arun",
                //LastName = "Gaudel",
                //Salary = 5213453,
                //Address = "California",
                //PhoneNo = "704548706"
            });
            dat.SaveChanges();
            var ActObj = dat.Employments.ToList().Where(x=>x.FirstName=="Barun").ToList().FirstOrDefault();
            Assert.AreEqual(ActObj.FirstName, "Barun");
        }
    }
}
