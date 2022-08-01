using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Insert Customer
        /// </summary>
        /// <param name="customer">customer</param>
        /// <returns>The price with discount if applicable</returns>
        public double GetPrice(Customer customer)
        {
            if (customer.IsPremium)
            {
                return Price * 0.8;
            }
            return Price;
        }        
        
        public double GetPrice(ICustomer customer)
        {
            if (customer.IsPremium)
            {
                return Price * 0.8;
            }
            return Price;
        }
    }
}
