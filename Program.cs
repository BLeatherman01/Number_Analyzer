namespace Number_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, What is your name? \n");
            string name = Console.ReadLine();

            bool keepgoing = true;

            while (keepgoing)
            {

                Console.WriteLine("Please entered a number between 1 and 100");
                int num = int.Parse(Console.ReadLine());

                if (num <= 0 || num > 100)
                {
                    Console.WriteLine($"{name} that is not a valid number in the range");
                }
                else if (num % 2 != 0 && num < 60)
                {
                    Console.WriteLine($"{name} the number is odd and less than 60");
                }
                else if (num % 2 != 0 && num >= 60 && num <= 100)
                {
                    Console.WriteLine($"{name} the number is odd and greater than 60");
                }
                else if (num % 2 == 0 && num > 61 && num <= 100)
                {
                    Console.WriteLine($"{name} the number is even and greater than 60");
                }
                else if (num % 2 == 0 && num >= 2 && num < 25)
                {
                    Console.WriteLine($"{name} the number is even and less than 25");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine($"{name} the number is even and between 26 and 60 inclusive");
                }

                Console.WriteLine($"{name}, would you like to continue? Y/N");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    continue;
                }
                else if (input == "n")
                {
                    keepgoing = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that let's try that again");
                }

            }
        }
    }
}