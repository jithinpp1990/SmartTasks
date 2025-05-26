namespace SmartTasks.Data.Interface;

/// <summary>
/// ITaskRepository interface defines the contract for task-related data access operations.
/// It provides a method to retrieve all tasks.
/// </summary>
internal interface ITaskRepository
{
    /// <summary>
    /// Asynchronously retrieves all tasks.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of tasks.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    public Task<IEnumerable<string>> GetAllTasks();
}
