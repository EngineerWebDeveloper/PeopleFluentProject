using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFluentProject
{
    class Deal
    {
        private int currentQuantity;
        private int priceOf;
        public Deal(int currentQuantity, int priceOf)
        {
            this.currentQuantity = currentQuantity;
            this.priceOf = priceOf;
        }
        public int GetCurrentQuantity()
        {
            return this.currentQuantity;
        }
        public int GetPriceOf()
        {
            return this.priceOf;
        }
    }
}
