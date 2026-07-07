namespace Repeating_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("Please Etner a Number: ");
            Console.WriteLine("Please choose a number: ");
            Console.WriteLine("1) hello");
            Console.WriteLine("2) Good evening");
            Console.WriteLine("3) Exist");
            int num;
            num = int.Parse(Console.ReadLine());
            //Console.Write(num);

            while (num != 3)
            {
                /* 
                Console.WriteLine("Please choose a number: ");
                Console.WriteLine("1) hello");
                Console.WriteLine("2) Good evening");
                Console.WriteLine("3) Exist"); 
                
                 */
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;


                    case 2:
                        Console.WriteLine("Good Evening!");
                        break;

                    case 3:
                        Console.WriteLine("Exist");
                        break;

                }
                Console.WriteLine("Please choose again: ");
                Console.WriteLine("1) hello");
                Console.WriteLine("2) Good evening");
                Console.WriteLine("3) Exist");

                //Console.Write("Please Enter the Correct Num: ");
                num = int.Parse(Console.ReadLine());

            }




            Console.WriteLine("Nice, you got it..");


        }
    }
}
