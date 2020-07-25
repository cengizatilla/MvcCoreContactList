using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CengizAtilla.ContactList.Models.Context
{
    public static partial class StaticDatabase
    {
        public static List<ContactCard> contactCards;

        static StaticDatabase()
        {
            contactCards = new List<ContactCard>();
        }

       

    }
}
