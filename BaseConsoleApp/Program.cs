using System.Net.Sockets;

namespace BaseConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Please select a ticket type:");
            Console.WriteLine("1. Child's Ticket (under 12 years old)");
            Console.WriteLine("2. Adult Ticket (12–64 years old)");
            Console.WriteLine("3. Senior Ticket (65 years and older)");


            int ticketChoice = 0;
            string ticketType = "";
            int ticketPrice = 0;

            while (true)
            {
                Console.Write("Enter the number of your choice: ");
                string ticketString = Console.ReadLine();
                ticketChoice = int.Parse(ticketString);

                ticketType = ticketChoice switch
                {
                    1 when age < 12 => "Child Ticket",
                    2 when age >= 12 && age <= 64 => "Adult Ticket",
                    3 when age >= 65 => "Senior Ticket",
                    _ => null
                };


                if (ticketType == "Child Ticket")
                {
                    Console.WriteLine($"You selected {ticketType}. It costs €5");
                    ticketPrice = 5;
                    break;
                }
                else if (ticketType == "Adult Ticket")
                {
                    Console.WriteLine($"You selected {ticketType}. It costs €10");
                    ticketPrice = 10;
                    break;
                }
                else if (ticketType == "Senior Ticket")
                {
                    Console.WriteLine($"You selected {ticketType}. It costs €7");
                    ticketPrice = 7;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection for your age.");
                }

            
            }

            Console.WriteLine("Do you have a discount code? Yes/No");
            string discountResponse = Console.ReadLine().ToLower();

        while (true) { 
                if (discountResponse == "yes")
            {
                Console.WriteLine("Please enter your discount code:");
                string discountCode = Console.ReadLine();
                if (discountCode == "SALE20")
                {
                    Console.WriteLine("Discount code applied! You get 20% off.");
                    int newTicketPrice = (int)(ticketPrice * 0.8);
                    Console.WriteLine($"{name}, you have chosen {ticketType}. Original price {ticketPrice}, discounted price {newTicketPrice}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid discount code.");
                }
            }
            else if (discountResponse == "no")
            {
                Console.WriteLine("No discount code applied.");
                Console.WriteLine($"{name}, you have chosen {ticketType}. It costs {ticketPrice}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid response. Please answer Yes or No.");
            }
        }


    }
}
}
