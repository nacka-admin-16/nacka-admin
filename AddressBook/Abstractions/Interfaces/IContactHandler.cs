using System.Collections.Generic;
using AddressBook.Entities;

namespace AddressBook.Abstractions.Interfaces
{
    public interface IContactHandler
    {
        List<Contact> GetContacts();

        bool SaveContact(Contact contact);

        bool UpdateContact(string id);

        void ValidateContact(Contact contact);
    }
}