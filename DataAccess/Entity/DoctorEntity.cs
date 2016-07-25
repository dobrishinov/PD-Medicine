namespace DataAccess.Entity
{
    public class DoctorEntity : UserEntity
    {
        public int DoctorId { get; set; }
        public string DoctorType { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
