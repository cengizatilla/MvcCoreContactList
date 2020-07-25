using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CengizAtilla.ContactList.Models
{
    public class ContactCardDetail
    {
        public Guid contactCardDetailId { get; set; }
        public Guid contactCardId { get; set; }
        public ContactCardType contactCardType { get; set; }
        public string contactValue { get; set; }
        public DateTime createDate { get; set; }
    }
}
