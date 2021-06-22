using System;

namespace Pythagorous_theorem
{
    class Program
    {
        public static double ans;
        public static double a;
        public static double b;
        public static double c;

        //Calls methods and outputs and answer.
        static void Main(string[] args)
        {
            UserInformation();
            FindUserChoice();
            Console.WriteLine("The answer is " + ans);
            Console.ReadKey();
        }

        //Provides user with information on how to use program.
        static void UserInformation()
        {
            Console.WriteLine("Select wether you are trying to solve for the hypotenuse or a side.");
            Console.WriteLine("Type \"Hypotenuse\" or \"Side\"");
        }

        //Calls method based on type of solution required by user.
        static double FindUserChoice()
        {

            string userInput;
            userInput = Console.ReadLine();

            if (userInput == "Hypotenuse")
            {
                ans = CalculateHypotenuse();
                return ans;
            }
            if (userInput == "Side")
            {
                ans = CalculateSide();
                return ans;
            }
            else
            {
                Console.WriteLine("Error, please try again.");
                UserInformation();
                return FindUserChoice();
            }
        }

        //Asks user for two side inputs and calculates the hypotenuse.
        public static double CalculateHypotenuse()
        {
            Console.WriteLine("Enter value for side a and then side b");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            return c;
        }

        //Asks user for 1 side input and hypotenuse then calculates the unknown side.
        public static double CalculateSide()
        {
            Console.WriteLine("Enter value for side a and then hypotenuse c");
            a = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            b = Math.Sqrt(c * c - a * a);
            return b;
        }
    }
}
