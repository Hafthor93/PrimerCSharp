/*namespace PrimerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number. Press enter to exit.");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("No numbers were entered, try again.");
                    continue;
                }    
                numbers.Add(number);
            }

            if (numbers != numbers)
            {
                Console.WriteLine("No numbers were entered, try again.");
                return;
            }

            int min = numbers.Min();
            int max = numbers.Max();

            Console.WriteLine($"The smallest number is: {min} and the largest is: {max}");
            }
        }
    }