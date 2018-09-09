using System.Collections.Generic;

namespace DarkstarCrm.Core.Model
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}