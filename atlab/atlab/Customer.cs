using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    public class Customer
    {
        public int Discount = 5;
        public string GreetMessage { get; set; }

        /// <summary>
        /// Takes two string inputs, firstName and secondName
        /// </summary>
        /// <param name="firstName">First string</param>
        /// <param name="secondName">Second string</param>
        /// <returns>firstName, secondName combined with a greeting</returns>
        public string CombineCustomerName(string firstName, string secondName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("firstName is empty or null");
            }

            GreetMessage = $@"Hello, {firstName} {secondName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}
