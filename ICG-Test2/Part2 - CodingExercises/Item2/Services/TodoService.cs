using ICG_Test2.Part2___CodingExercises.Item2.Models;

namespace ICG_Test2.Part2___CodingExercises.Item2.Services;

public class TodoService
{
    private readonly List<TodoTask> _tasks = new();

    public bool AddTask(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            return false;

        _tasks.Add(new TodoTask
        {
            Description = description.Trim()
        });

        return true;
    }

    public List<TodoTask> GetAllTasks()
    {
        return _tasks;
    }

    public bool RemoveTask(int taskNumber)
    {
        if (taskNumber < 1 || taskNumber > _tasks.Count)
            return false;

        _tasks.RemoveAt(taskNumber - 1);
        return true;
    }

    public bool HasTasks()
    {
        return _tasks.Count > 0;
    }
}