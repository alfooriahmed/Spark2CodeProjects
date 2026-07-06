namespace Loan_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Your Montly Income: ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Do You Have a Loan?(Yes/No) ");
            string have_load = Console.ReadLine();
            Console.WriteLine(have_load);


            Console.WriteLine("your age is :" + age + " ,And your income is: " + salary);


        }
    }
}
