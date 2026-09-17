using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infrastructure.Persistence.Entities
{
    public class TodoAppDbcontext(DbContextOptions<TodoAppDbcontext>options) : DbContext(options)
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Activity> ActivityLogs { get; set; }
        public DbSet<TodoItem> todoItems { get; set; }
        public DbSet<TodoItemTag> todoItemTags { get; set; }
        public DbSet<Comments> comments { get; set; }


    }
}
