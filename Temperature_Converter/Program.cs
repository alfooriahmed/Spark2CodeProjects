
namespace Temperature_Conventer
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            Console.Write("Enter The Tempreture in celecis: ");
            double temp = double.Parse(Console.ReadLine());
            //Console.WriteLine(temp);


            double feher = (temp * 9 / 5) + 32;
            Console.WriteLine("The tempreture in fehrnhiet is: "+ feher);

            if (temp < 10)
            {
                Console.WriteLine("Cold");
            }

            else if (temp >= 10 && temp <= 30)
            {
                Console.WriteLine("Mild");

            }

           /* else if (temp > 30)
            {
                Console.WriteLine("Hot");

            } */

            else
            {
                Console.WriteLine("Hot");
            }

    }



}
}


