using System.Collections.Generic;

namespace DarkstarCrm.Data
{
    public class Account : BaseEntity
    {
        public override int Id { get => AccountId; set => AccountId = value; }

        public int AccountId { get; set; }

        public string Name { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}