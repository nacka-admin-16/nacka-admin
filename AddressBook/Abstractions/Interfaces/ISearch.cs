using System.Collections.Generic;
using AddressBook.Entities;

namespace AddressBook.Abstractions.Interfaces
{
    public interface ISearch
    {
        List<Contact> SearchForContacts(string query);
    }
}