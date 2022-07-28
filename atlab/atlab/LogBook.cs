using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    
    public interface ILogBook
    {
        void Message(string message);
    }

    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DummyLogBook : ILogBook
    {
        public void Message(string message)
        {
            // Created DummyLogBook equivalent as a null object or null entity to have a NUnit test on BankAccount without LogBook."
            // In a real world project we should use Mock as an alternative to expensive Dummy code.
        }
    }
}
