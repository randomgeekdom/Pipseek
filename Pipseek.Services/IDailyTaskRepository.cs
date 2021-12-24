using Pipseek.Model;

namespace Pipseek.Services
{
    public interface IDailyTaskRepository
    {
        Task CreateTaskAsync(Guid userId, DateTime date, TimeOfDay timeOfDay);
        Task DeleteTaskAsync(Guid userId, int taskId);
        Task CompleteTaskAsync(Guid userId, int taskId, string note);
        Task<IEnumerable<DailyTask>> GetTasksAsync(Guid userId);

        Task CycleTimeOfDayAsync(Guid userId, int taskId);

        Task UpdateTaskNoteAsync(Guid userId, int taskId, string? note);
        Task UpdateDateAsync(Guid userId, int taskId, DateTime dateTime);
    }
}