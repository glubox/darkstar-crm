using System.Collections.Generic;

namespace DarkstarCrm.Data
{
    public class Client : BaseEntity
    {
        public override int Id { get => ClientId; set => ClientId = value; }

        public int ClientId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}