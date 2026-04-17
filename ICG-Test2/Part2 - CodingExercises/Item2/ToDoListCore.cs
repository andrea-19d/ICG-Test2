using ICG_Test2.Part2___CodingExercises.Item2.Services;
using ICG_Test2.Part2___CodingExercises.Item2.UI;

namespace ICG_Test2.Part2___CodingExercises.Item2;

public class ToDoListCore
{
    public static void ToDoApp()
    {
        var todoService = new TodoService();
        int option;

        do
        {
            Console.Clear();
            Menu.Show();

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Menu.ShowInvalidInput();
                Menu.Pause();
                continue;
            }

            Console.Clear();

            switch (option)
            {
                case 1:
                    AddTaskFlow(todoService);
                    break;
                case 2:
                    ListTasksFlow(todoService);
                    break;
                case 3:
                    RemoveTaskFlow(todoService);
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Menu.ShowInvalidOption();
                    break;
            }

            if (option != 4) Menu.Pause();
        } while (option != 4);
    }

    static void AddTaskFlow(TodoService todoService)
    {
        Console.Write("Enter task description: ");
        string? input = Console.ReadLine();

        bool added = todoService.AddTask(input ?? string.Empty);

        Console.WriteLine(added ? "Task added." : "Task description cannot be empty.");
    }

    static void ListTasksFlow(TodoService todoService)
    {
        var tasks = todoService.GetAllTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
            return;
        }

        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].Description}");
        }
    }

    static void RemoveTaskFlow(TodoService todoService)
    {
        if (!todoService.HasTasks())
        {
            Console.WriteLine("No tasks to remove.");
            return;
        }

        Console.Write("Enter task number to remove: ");

        if (!int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        bool removed = todoService.RemoveTask(taskNumber);

        Console.WriteLine(removed ? "Task removed." : "Task number out of range.");
    }
}