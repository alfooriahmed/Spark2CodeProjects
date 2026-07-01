namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("please Enter a number: ");
            double numb = double.Parse(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }

            else
            {
                Console.WriteLine("the number is odd");
            }
           

        }
    }
}
