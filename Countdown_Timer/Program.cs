namespace Countdown_Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Number: ");
            int user_num = int.Parse(Console.ReadLine());

            //Console.WriteLine(user_num);
            for(int i = 1;  user_num >= i; user_num--)
            {
                Console.WriteLine(user_num);
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
