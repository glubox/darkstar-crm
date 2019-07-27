namespace DarkstarCrm.Data
{
    public class Contact : BaseEntity
    {
        public override int Id { get => ContactId; set => ContactId = value; }

        public int ContactId { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int? ClientId { get; set; }

        public int? AccountId { get; set; }

        public bool IsDefault { get; set; }

        public int? CountryId { get; set; }

        public int? StateId { get; set; }

        public Client Client { get; set; }

        public Account Account { get; set; }

        public Country Country { get; set; }

        public State State { get; set; }
    }
}