using Pipseek.Model;

namespace Pipseek.Services
{
    public interface IDailyTaskRepository
    {
        Task CreateTaskAsync(Guid userId, DateTime date, TimeOfDay timeOfDay);
        Task DeleteTaskAsync(Guid userId, int taskId);
        Task<IEnumerable<DailyTask>> GetTasksAsync(Guid userId, DateTime date);

        Task CycleTimeOfDayAsync(Guid userId, int taskId);

        Task UpdateTaskNoteAsync(Guid userId, int taskId, string? note);
    }
}