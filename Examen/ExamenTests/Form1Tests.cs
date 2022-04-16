using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void IsValidFIOTest()
        {
            string fio = "qwertyuiopasdfg";

            bool expected;

            expected = true;

            bool actual = Examen.Form1.IsValidFIO(fio);


            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void IsValidEmailTest()
        {

            string email = "qwerty@mail.ru";

            bool actual = Examen.Form1.IsValidEmail(email);

            bool expected = true;


            Assert.AreEqual(expected,actual);
        }
    }
}