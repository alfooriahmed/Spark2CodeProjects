namespace Sum_Even_Numbers_Only
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a positive number: ");
            
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {

                int total = 0;
                for (int i = 1; i <= num; i += 1)
                {
                    

                    if (i % 2 == 0)
                    {

                        total = i + total;
                        

                    }


                }
                Console.WriteLine(total);


            }

            else
            {
                Console.WriteLine("you entered a negative number");
            }

        }
    }
}
