namespace Todo.Infrastructure.Persistence.Entities
{
    public class Users : BaseAuditableEntity
    {
        public string FullName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}