using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        //Q2 #6 update the code
        public void AddQuiz2()
        {
            var newTodo = new TodoItem
            {
                Id = 3,  
                Name = "quiz#2",  
                IsComplete = false 
            };

            TodoItems.Add(newTodo);  
            SaveChanges();  
        }
    }
}
