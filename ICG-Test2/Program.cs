using ICG_Test2.Part2___CodingExercises.Item1;
using ICG_Test2.Part2___CodingExercises.Item2;

namespace ICG_Test2;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.Clear(); 

            MenuOptions.ShowMenu();

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (option)
            {
                case 1:
                    LogAnalyzer.Analyze();
                    break;
                case 2:
                    ToDoListCore.ToDoApp();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            if (option != 0)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (option != 0);
    }
}