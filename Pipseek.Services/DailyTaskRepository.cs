using Microsoft.EntityFrameworkCore;
using Pipseek.Model;

namespace Pipseek.Services
{
    public class DailyTaskRepository : IDailyTaskRepository
    {
        private readonly IDbContextFactory<PipseekContext> contextFactory;

        public DailyTaskRepository(IDbContextFactory<PipseekContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task CreateTaskAsync(Guid userId, DateTime date, TimeOfDay timeOfDay)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                var task = new DailyTask
                {
                    Date = date.Date,
                    Note = "New Task",
                    TimeOfDay = timeOfDay,
                    UserId = userId
                };

                await context.DailyTasks.AddAsync(task);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DailyTask>> GetTasksAsync(Guid userId, DateTime date)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                return await context.DailyTasks.Where(x => x.UserId == userId && !x.IsCompleted).ToListAsync();
            }
        }

        public async Task DeleteTaskAsync(Guid userId, int taskId)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                var task = await context.DailyTasks.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == taskId);

                if (task != null)
                {
                    _ = context.DailyTasks.Remove(task);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task CycleTimeOfDayAsync(Guid userId, int taskId)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                var task = await context.DailyTasks.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == taskId);

                if (task != null)
                {
                    if (task.TimeOfDay == TimeOfDay.Night)
                    {
                        task.TimeOfDay = TimeOfDay.Morning;
                    }
                    else
                    {
                        task.TimeOfDay = (TimeOfDay)((int)task.TimeOfDay + 1);
                    }
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateTaskNoteAsync(Guid userId, int taskId, string? note)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                var task = await context.DailyTasks.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == taskId);

                if (task != null)
                {
                    task.Note = note;
                    await context.SaveChangesAsync();
                }
            }

        }

        public async Task CompleteTaskAsync(Guid userId, int taskId)
        {
            using (var context = await this.contextFactory.CreateDbContextAsync())
            {
                var task = await context.DailyTasks.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == taskId);

                if (task != null)
                {
                    task.IsCompleted = true;
                    await context.SaveChangesAsync();
                }
            }
        }
    }

}