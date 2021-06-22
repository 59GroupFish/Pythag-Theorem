using System;

namespace Pythagorous_s_theorum
{
    class Program
    {
        public static double ans;

        static void Main(string[] args)
        {
            UserInformation();
            FindUserChoice();
            Console.WriteLine("The answer is " + ans);
            Console.ReadKey();
        }

        static void UserInformation()
        {
            Console.WriteLine("Select wether you are trying to solve for the hypotenuse or a side.");
            Console.WriteLine("Type \"Hypotenuse\" or \"Side\"");
        }

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

        public static double CalculateHypotenuse()
        {
            Console.WriteLine("Enter value for side a and then side b");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }

        public static double CalculateSide()
        {
            Console.WriteLine("Enter value for side a and then hypotenuse c");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(c * c - a * a);
            return b;
        }
    }
}
