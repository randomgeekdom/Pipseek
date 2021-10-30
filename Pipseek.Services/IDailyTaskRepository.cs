using Pipseek.Model;

namespace Pipseek.Services
{
    public interface IDailyTaskRepository
    {
        Task CreateTaskAsync(Guid userId, DateTime date, string note, TimeOfDay timeOfDay);
        Task DeleteTask(Guid userId, int taskId);
        Task<IEnumerable<DailyTask>> GetTasksAsync(Guid userId, DateTime date);
    }
}