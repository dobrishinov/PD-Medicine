namespace DataAccess.Entity
{
    public class AdminEntity : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool AdminStatus { get; set; }
    }
}
