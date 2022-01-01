namespace RealEstateAgency.Database
{
    public class UserProperties
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PropertyId { get; set; }
        public virtual User User { get; set; }
        public virtual Property Property { get; set; }
    }
}