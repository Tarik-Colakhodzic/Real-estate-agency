namespace RealEstateAgency.Model
{
    public class PropertyPhoto
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public byte[] Photo { get; set; }
    }
}
