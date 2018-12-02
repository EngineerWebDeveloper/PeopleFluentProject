using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFluentProject
{
    class ShopCheckoutSystem
    {
        /// <summary>
        /// CheckoutSystem: returns the total price based on fruitNames
        /// </summary>
        /// <param name="fruitNames">list of fruits to be check out</param>
        /// <param name="fruitPrices">Contains the price of each fruit</param>
        /// <returns>the total price</returns>

        public static float CheckoutSystem(List<string> fruitNames, Dictionary<string, int> fruitPrices)
        {
            return fruitNames.Select(x => fruitPrices[x]).Sum();

        }

        static void Main(string[] args)
        {

        }
    }
}
