using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CengizAtilla.ContactList.Models.Context
{
    public static partial class StaticDatabase
    {
        public static void addNewContactCardDetail(ContactCardDetail contactCardDetailDataItem)
        {
            ContactCard contactCard = contactCards.Where(I => I.contactId == contactCardDetailDataItem.contactCardId).FirstOrDefault();
            if(contactCard != null)
            {
                contactCard.contactCardDetails.Add(contactCardDetailDataItem);
            }
        }

        public static void removeContactCardDetail(ContactCardDetail contactCardDetailDataItem)
        {
            ContactCard contactCard = contactCards.Where(I => I.contactId == contactCardDetailDataItem.contactCardId).FirstOrDefault();
            if (contactCard != null)
            {
                contactCard.contactCardDetails.Remove(contactCardDetailDataItem);
            }
        }
    }
}
