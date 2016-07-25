namespace DataAccess.Entity
{
    public class UserEntity : BaseEntity
    {
        public int Username { get; set; }
        public int Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
