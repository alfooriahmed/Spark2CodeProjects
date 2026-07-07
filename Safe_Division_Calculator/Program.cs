namespace Safe_Division_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Console.Write("Pleas Enter The First Number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.Write("Pleas Enter The Second Number: ");
                int input2 = int.Parse(Console.ReadLine());

                Console.WriteLine(input1 / input2);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero: " + ex.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("You Enter a not valid integer. Please enter numbers only.");
            }

            /*
             *  Console.Write("Pleas Enter The First Number: ");
                if(!int.TryParse(Console.ReadLine(), out int number)) 
                {
                    // message
                    return
                }
                Console.Write(number);
             */


        }
    }
}
