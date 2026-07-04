namespace Restaurant_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Total Bill Amount: ");
            int TotalBill = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello, your Total is: " + age);

            Console.Write("Are You a Loyality Member?(Yes/NO) ");
            string isloyal = Console.ReadLine().ToLower();
            double Discount = 0.15;
            double Dis_Amount = Discount * TotalBill;
            if (isloyal != "yes" || isloyal != "no")
            {
                Console.WriteLine("Please answer with only yes/no.");
            }

            else if ( isloyal == "yes" && TotalBill > 20)
            {
                Console.WriteLine("Your Orignal bill is: " + TotalBill +" And Your Discount Amount: " + Dis_Amount + " .Your Final Price is: " + (TotalBill - Dis_Amount));

            }
            else if(isloyal == "yes" && TotalBill <= 20)
            {
                Console.WriteLine("Your Orignal bill is: " + TotalBill + " And Your Discount Amount is: 0. Your Final Price is: " + TotalBill);
            }
             else
             {
                 Console.WriteLine("Your Orignal bill is: " + TotalBill + " And Your Discount Amount: 0 .Your Final Price is: " + TotalBill);
             } 


        }
    }
}
