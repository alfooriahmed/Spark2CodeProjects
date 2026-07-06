namespace Password_Retry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user_input = "";                     // identify and empty string variable to store the user input
            while (user_input != "Spark2026")             // while the user input is not equal to the password, keep running the while loop

            {
                // Console.WriteLine(i);
                Console.Write("please enter your password: ");       // asking the user to enter the password
                user_input = Console.ReadLine();                     // make the user able to enter a password and store it in varibale: "user_input"
                if (user_input != "Spark2026")                       // check if the user enter the correct passowrd, if not, print the message.
                { 
                Console.WriteLine("Incorrect password, try again");
                    Console.WriteLine();                             
                }
                
            }
            Console.Write("Access Granted");                          // if the user enter the correct password, the loop will end and then print this
        }
    }
}
