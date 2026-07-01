namespace GradeLetterLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


           Console.Write("Please Enter Your Grade (A, B, C, D, F): ");
            char grade = char.Parse(Console.ReadLine().ToUpper());
            //Console.Write(grade);

            switch(grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                    Console.WriteLine("Good");
                    break;

                case 'D':
                    Console.WriteLine("Pass");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;






            }

        }
    }
}
