namespace SmartTasks.Data.Implimentation;

using SmartTasks.Data.Interface;

/// <summary>
/// TaskRepository class implements ITaskRepository interface.
/// It is responsible for data access related to tasks.
/// This class can be used to fetch tasks from a database or any other data source.
/// It contains methods to perform CRUD operations on tasks.
/// </summary>
public class TaskRepository : ITaskRepository
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TaskRepository"/> class.
    /// </summary>
    public TaskRepository()
    {
        // Constructor logic can be added here if needed
    }

    /// <summary>
    /// Asynchronously retrieves all tasks.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of tasks.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    public async Task<IEnumerable<string>> GetAllTasks()
    {
        // Simulate fetching tasks from a database or other data source
        var tasks = new List<string>
        {
            "Task 1",
            "Task 2",
            "Task 3",
        };
        await Task.Delay(1000); // Simulate async operation
        return tasks;
    }
}
