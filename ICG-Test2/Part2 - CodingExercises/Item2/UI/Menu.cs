namespace ICG_Test2.Part2___CodingExercises.Item2.UI;

public class Menu
{
    public static void Show()
    {
        Console.WriteLine("--- Simple To-Do List ---");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. List Tasks");
        Console.WriteLine("3. Remove Task");
        Console.WriteLine("4. Exit");
        Console.Write("Choose option: ");
    }

    public static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public static void ShowInvalidInput()
    {
        Console.WriteLine("Invalid input.");
    }

    public static void ShowInvalidOption()
    {
        Console.WriteLine("Invalid option.");
    }
}