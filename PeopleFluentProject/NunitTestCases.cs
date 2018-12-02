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
            Assert.AreEqual(1.95, Math.Round(ShopCheckoutSystem.CheckoutSystem(new List<string>() { "Apple", "Orange", "Apple", "Orange", "Orange" }, new Dictionary<string, int>() { { "Apple", 60 }, { "Orange", 25 } })),2);

        }
        [TestCase]
        public void CheckoutSystemWithOffers()
        {
            Assert.AreEqual(1.10, Math.Round(ShopCheckoutSystem.CheckoutSystem(new List<string>() { "Apple", "Orange", "Apple", "Orange", "Orange" }, new Dictionary<string, int>() { { "Apple", 60 }, { "Orange", 25 } }, new Dictionary<string, Deal>() { { "Apple", new Deal(1, 2) }, { "Orange", new Deal(2, 3) } }), 2));

        }
    }
}
