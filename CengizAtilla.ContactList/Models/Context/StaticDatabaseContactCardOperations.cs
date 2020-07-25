using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CengizAtilla.ContactList.Models.Context
{
    public static partial class StaticDatabase
    {
        public static void addNewContact(ContactCard contactCardDataItem)
        {
            contactCards.Add(contactCardDataItem);
        }

        public static ContactCard findContactByFirstnameLastname(string firstName, string lastName) => contactCards.Count(I => I.firstName.ToLower() == firstName.ToLower() && I.lastName.ToLower() == lastName.ToLower()) > 0 ? contactCards.Find(I => I.firstName.ToLower() == firstName.ToLower() && I.lastName.ToLower() == lastName.ToLower()) : null;

        public static List<ContactCard> getAllRecord() => contactCards.ToList();

        public static ContactCard getRecordById(Guid recordId) => contactCards.Count(I => I.contactId == recordId) > 0 ? contactCards.Find(I => I.contactId == recordId) : null;

        public static void updateContactCard(ContactCard contactCardDataItem)
        {
            if (contactCards.Count(I => I.contactId == contactCardDataItem.contactId) > 0)
                contactCards[contactCards.FindIndex(I => I.contactId == contactCardDataItem.contactId)] = contactCardDataItem;
        }

        public static void deleteContactCard(ContactCard contactCardDataItem)
        {
            if (contactCards.Count(I => I.contactId == contactCardDataItem.contactId) > 0)
                contactCards.Remove(contactCards.Find(I => I.contactId == contactCardDataItem.contactId));
        }
    }
}
