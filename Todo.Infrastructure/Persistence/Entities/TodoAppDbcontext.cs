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
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoItemTag> TodoItemTags { get; set; }
        public DbSet<Comments> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoAppDbcontext).Assembly);


            // Users -> TodoLists
            modelBuilder.Entity<TodoList>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // TodoList -> TodoItems
            modelBuilder.Entity<TodoItem>()
                .HasOne(x => x.TodoList)
                .WithMany(x => x.TodoItems)
                .HasForeignKey(x => x.TodoListId)
                .OnDelete(DeleteBehavior.Cascade);

            // TodoItem -> Comments
            modelBuilder.Entity<Comments>()
                .HasOne(x => x.TodoItem)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.TodoItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Users -> Comments
            modelBuilder.Entity<Comments>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // TodoItem -> TodoItemTags
            modelBuilder.Entity<TodoItemTag>()
                .HasOne(x => x.TodoItem)
                .WithMany(x => x.TodoItemTags)
                .HasForeignKey(x => x.TodoItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // Tag -> TodoItemTags
            modelBuilder.Entity<TodoItemTag>()
                .HasOne(x => x.Tag)
                .WithMany(x => x.TodoItemTags)
                .HasForeignKey(x => x.TagId)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
