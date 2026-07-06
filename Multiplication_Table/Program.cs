namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number: ");
            int user_num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine(user_num + " * " + i + " = " + user_num * i);
                //Console.WriteLine(i);
            }

            //Console.WriteLine(user_num);
        }
    }
}
