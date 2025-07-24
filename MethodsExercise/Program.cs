namespace MethodsExercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var running = true;
            while (running == true)
            {
                Console.WriteLine("Welcome to my application!\nPlease select one of the options below by typing the letter on your keyboard:");
                Console.WriteLine("1) Story mode\n2) Calculator mode\n3) Quit");
                var keyInput = Console.ReadKey(true);
                switch (keyInput.Key)
                {
                    case ConsoleKey.D1:
                        Program.Story();
                        break;
                    case ConsoleKey.D2:
                        Program.Calculator();
                        break;
                    case ConsoleKey.D3:
                        running = false;
                        Console.Clear();
                        Console.WriteLine("Thank you, goodbye.");
                        break;
                    default:
                        Console.Beep();
                        Console.WriteLine("Invalid key. Please try again.");
                        Console.Clear();
                        break;
                }
            }
        }

        private static void Story()
        {
            Console.Clear();
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();
            
            Console.Write("Enter your favorite animal: ");
            string favoriteAnimal = Console.ReadLine();
            
            Console.Write("Enter your favorite band: ");
            string favoriteBand = Console.ReadLine();
            
            string story = $"STORY GENERATED:\n{name} walked through a {favoriteColor} forest and found a {favoriteAnimal} dancing to {favoriteBand}. It was the best day ever.";
            Console.Clear();
            Console.WriteLine(story);
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void Calculator()
        {
            Console.Clear();
            
            Console.WriteLine("What kind of calculation would you like to do?");
            Console.WriteLine("1) Addition\n2) Multiplication");
            
            var keyInput = Console.ReadKey(true);
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Please enter the numbers you would like to add separated by commas, Example: 1,2,3");
                    var addNumbers = Console.ReadLine().Split(',');
                    Console.WriteLine("ANSWER: " + Program.Add(addNumbers));
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Please enter the numbers you would like to multiply separated by commas, Example: 1,2,3");
                    var multiplyNumbers = Console.ReadLine().Split(',');
                    Console.WriteLine("ANSWER: " + Program.Multiply(multiplyNumbers));
                    break;
                default:
                    Console.WriteLine("invalid key. Please try again.");
                    break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static int Add(string[] numbers)
        {
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += int.Parse(x);
            }
            return sum;
        }

        private static int Multiply(string[] numbers)
        {
            int sum = 1;
            foreach (var x in numbers)
            {
                sum *= int.Parse(x);
            }
            return sum;
        }
    }
}
