namespace Movie_Ticket_Pricing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello, your age is: " + age);

            

                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("You are eligible for a child ticket. The price is: 2.000 omr.");
                }
                else if (age > 12 && age < 60)
                {
                    Console.WriteLine("You are eligible for a adult ticket. The price is: 5.000 omr.");
                }

                else if (age >= 60)
                {
                    Console.WriteLine("You are eligible for a Senior ticket. The price is: 3.000 omr.");
                }
                else
                {
                    Console.WriteLine("You Enterd an Invalid Age.");

                }
            
        }
}
}
