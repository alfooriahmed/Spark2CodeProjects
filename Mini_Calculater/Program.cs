namespace Mini_Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter The First Number: ");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The Second Number: ");
            int second_num = int.Parse(Console.ReadLine());

           // Console.WriteLine(first_num + second_num);

            //Enter an operator
            //f
            Console.Write("Please Enter an Operator: ");
            char Operator = char.Parse(Console.ReadLine());
           // Console.WriteLine(Operator);

            switch (Operator)
            {
                case '+':
                    Console.WriteLine(first_num + second_num);
                    break;

                case '-':
                    Console.WriteLine(first_num - second_num);
                    break;

                case '*':
                    Console.WriteLine(first_num * second_num);
                    break;

                case '/':
                    if (second_num == 0)
                    {
                        Console.WriteLine("Can not divide by zero");
                    }
                    else
                    {
                        Console.WriteLine(first_num / second_num);
                    }
                    break;

                case '%':
                    if (second_num == 0)
                    {
                        Console.WriteLine("Can not divide by zero");
                    }
                    else
                    {
                        Console.WriteLine(first_num % second_num);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;



            }
        }
    }
}
