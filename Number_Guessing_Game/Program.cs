namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 23;
            int user_num;
            int total_attempts = 0;
            do
            {
                Console.Write("Please gauss a number: ");
                user_num = int.Parse(Console.ReadLine());

                if (user_num > num)
                {
                    Console.Write("Too High");
                    Console.WriteLine();
                }
                else if (user_num < num)
                {
                    Console.Write("Too Low");
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("You are correct!");
                    Console.WriteLine();
                }

                total_attempts = total_attempts + 1;
            }
            while (user_num != num);
           // total_attempts = total_attempts + 1;
            Console.WriteLine(total_attempts);
        }
    }
}
