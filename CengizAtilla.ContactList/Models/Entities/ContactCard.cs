using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CengizAtilla.ContactList.Models
{
    public class ContactCard
    {
        public ContactCard()
        {
            contactCardDetails = new List<ContactCardDetail>();
        }
        public Guid contactId { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string description { get; set; }
        public List<ContactCardDetail> contactCardDetails { get; set; }
        public DateTime createDate { get; set; }

    }
}
