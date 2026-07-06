namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleas Enter a Number: ");
            int user_num = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i <= user_num; i += 1)
            {
                //Console.WriteLine(i);
                total = total + i;

            }
            Console.WriteLine(total);


           



        }


    }
}
