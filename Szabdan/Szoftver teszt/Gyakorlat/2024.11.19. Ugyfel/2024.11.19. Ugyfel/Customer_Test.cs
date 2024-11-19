using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024._11._19.Ugyfel
{
    [TestFixture]
    internal class Customer_Test
    {
        Customer customer;
        [SetUp]
        public void Setup()
        {
            Customer customer = new Customer("Jhon", "Doe", "1990.05.15", "nigga@gmail.com", "nigga streat");
        }

        [Test]
        public void GetAge_ReturnsCorrectAge()
        {
            int output = customer.GetAge();

            ClassicAssert.AreEqual(34 , output);
        }
    }
}
