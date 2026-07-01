namespace Voting_Eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            Console.Write("Do you have a vaild Nationl ID card (only Yes/ No)?");
            string ID = Console.ReadLine();

            if (age >= 18 && ID == "Yes" || ID == "yes" && age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }

            else
            {
                Console.WriteLine("You are not eligible to vote");
            }



          
            /*if( ID == true)
            {
                Console.WriteLine("yes he has an ID");
            }  */  



        }
    }
}
