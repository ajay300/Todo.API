using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infrastructure.Persistence.Entities
{
    public class Comments : BaseAuditableEntity
    {
        public Guid TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; } //TodoItem is a class

        public Guid UserId { get; set; }
        public Users User { get; set; }

        public string Message { get; set; }
    }
}
