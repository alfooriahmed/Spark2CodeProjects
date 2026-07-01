namespace Rectangle_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());

            int area = length * width;
            int perimeter = 2 * (length + width);

            Console.WriteLine("The Area of the rectangle is: " + area + " and the permitr is: " + perimeter);
            
        }
    }
}
