using System.Collections.Generic;
using AddressBook.Entities;

namespace AddressBook.Abstractions.Interfaces
{
    public interface ICacheHandler
    {
        void SetCacheForContacts(List<Contact> contacts);

        List<Contact> GetCacheForContacts();
    }
}