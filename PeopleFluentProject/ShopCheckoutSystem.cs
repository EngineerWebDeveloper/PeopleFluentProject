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
            return (float)fruitNames.Select(name => fruitPrices[name]).Sum()/100;

        }
               /// <summary>
        /// CheckoutSystem: returns the total price based on fruitNames and deals 
        /// </summary>
        /// <param name="fruitNames">list of fruits to be check out</param>
        /// <param name="fruitPrices">Contains the price of each fruit</param>
        /// <param name="deals">offers to be applied while checking out</param>
        /// <returns>total price</returns>
        public static float CheckoutSystem(List<string> fruitNames, Dictionary<string, int> fruitPrices, Dictionary<string, Deal> deals)
        {
            Dictionary<string, int> fruitQuantity = new Dictionary<string, int>();
            foreach (string fruit in fruitNames)
            {
                if (fruitQuantity.ContainsKey(fruit))
                {
                    fruitQuantity[fruit]++;
                }
                else
                {
                    fruitQuantity.Add(fruit, 1);
                }

            }
            
            return _ApplyOffer(fruitQuantity, fruitPrices, deals);
        }
  
        static float _ApplyOffer(Dictionary<string,int> fruitQuantity, Dictionary<string, int> fruitPrices, Dictionary<string, Deal> deals)
        {
            float total = 0;
            foreach (var fruit in fruitQuantity.Keys)
            {
                total += deals[fruit].GetCurrentQuantity() *(fruitQuantity[fruit] / deals[fruit].GetPriceOf()) * fruitPrices[fruit];
                int remaining = fruitQuantity[fruit] >= deals[fruit].GetPriceOf() ? fruitQuantity[fruit] - (deals[fruit].GetPriceOf() * fruitQuantity[fruit]) / deals[fruit].GetPriceOf() : fruitQuantity[fruit];
                total += (remaining - remaining / deals[fruit].GetPriceOf()) * fruitPrices[fruit];
            }
            return total/100;
        }

        static void Main(string[] args)
        {

        }
    }
}
