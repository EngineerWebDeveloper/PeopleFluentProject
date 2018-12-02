using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFluentProject
{
    [TestFixture]
    class NunitTestCases
    {

        [TestCase]
        public void CheckoutSystem()
        {
            Assert.AreEqual(195, ShopCheckoutSystem.CheckoutSystem(new List<string>() { "Apple", "Orange", "Apple", "Orange", "Orange" }, new Dictionary<string, int>() { { "Apple", 60 }, { "Orange", 25 } }));

        }
    }
}
