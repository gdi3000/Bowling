using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKeepItSimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple.Tests
{
    [TestClass()]
    public class Tests
    {


        [TestMethod]
        [ExpectedException(typeof(UriFormatException))]
        public void MakeRequestURITest()
        {
            RestClient TestClient = new RestClient();

            TestClient.MakeRequest("Gibberish");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MakeRequestNoDataTest()
        {
            RestClient TestClient = new RestClient();

            Assert.AreEqual(TestClient.MakeRequest("http://13.74.31.101/api/pgdsfdss"), "No Data Found");

        }

        [TestMethod]
       
        public void MakeRequestSucess()
        {
            RestClient TestClient = new RestClient();

            TestClient.MakeRequest("http://13.74.31.101/api/points");

        }


        [TestMethod()]
        public void rulesSTRIKETest()
        {            
            Assert.IsTrue(Calculator.rules(10, 0) == 30);
        }

        
        [TestMethod()]
        public void rulesSpareTest()
        {
            Assert.IsTrue(Calculator.rules(5, 5) == 15);
        }
        [TestMethod()]
        public void rulesTest()
        {
            Assert.IsTrue(Calculator.rules(5, 0) == 5);
        }
    }
}