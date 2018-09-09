using System.Collections.Generic;

namespace DarkstarCrm.Core.Model
{
    public class Account
    {
        public int AccountId { get; set; }

        public string Name { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}