namespace DarkstarCrm.Data
{
    public class Country : BaseEntity
    {
        public override int Id { get => CountryId; set => CountryId = value; }

        public int CountryId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}