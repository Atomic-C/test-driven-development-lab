using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public string CombineCustomerName(string firstName, string secondName)
        {
            GreetMessage = $@"Hello, {firstName} {secondName}";
            return GreetMessage;
        }
    }
}
