using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class AgenotvalidException : Exception
    {
        public AgenotvalidException(string me) : base(me)
        {

        }
    }

    class Customer
    {
        string name;
        int age;
        internal Customer(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetAge()
        {
            try
            {
                if (age > 18)
                {
                    Console.WriteLine("Regitered!!!");
                }
                else
                {
                    throw new AgenotvalidException("Age should be greater than 18!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    class CustomException
    {
        static void Main()
        {
            Customer customer = new Customer("aa", 17);
            customer.GetAge();
            Console.Read();
        }
    }
}
