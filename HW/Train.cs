using System;

namespace HW
{
    class UserDefineException : Exception
    {
        public UserDefineException(string me) : base(me)
        {

        }
    }

    class Passenger
    {
        string name;
        int age;

        public void TicketBooking(int nooftickets)
        {
            try
            {
                if (nooftickets<0 && nooftickets > 2)
                {
                    throw new UserDefineException("Cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("Ticket  booked Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Used to close open Connection");
            }

        }
    }

    class Test
    { 
        static void Main()
        {
            string name;
            int age, nooftickets;

            Console.Write("Enter the name: ");
            name = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of tickets to booked: ");
            nooftickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: {0}||Age:{1}|| No of Tickets:{2}", name, age, nooftickets);

            Passenger p = new Passenger();
            p.TicketBooking(nooftickets);
            Console.Read();
        }
    }
    
    class Train
    {
        
        

    }
}
