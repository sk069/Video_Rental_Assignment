using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_Assignment;

namespace UnitTest_VedioRntal
{
   
    [TestClass]
    public class UnitTest1
    {
        Database_class Obj_Data = new Database_class();
        [TestMethod]
        public void TestMethod1()
        {
            string Connection = Obj_Data.ConnString;
            Assert.AreEqual(@"Data Source=LAPTOP-QI9DM23C\SQLEXPRESS;Initial Catalog=VideoRental_SQL;Integrated Security=True", Connection);
        }
        [TestMethod]
        public void Test_deleteMovie()
        {
            string Message = Obj_Data.CustomerDelete();
            Assert.AreEqual("customer Details are filled completely", Message);
        }
    }
}
