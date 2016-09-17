using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AddressBook.Abstractions.Interfaces;
using AddressBook.Entities;
using StructureMap;

namespace AddressBook.Abstractions
{
    public class Search : ISearch
    {
        private readonly IContactHandler _contactHandler = ObjectFactory.GetInstance<IContactHandler>();

        public List<Contact> SearchForContacts(string query)
        {
            var contacts = _contactHandler.GetContacts();
            var result = new List<Contact>();

            foreach (var contact in contacts)
            {
                var type = contact.GetType();
                var props = new List<PropertyInfo>(type.GetProperties());

                foreach (var property in props.Where(x => x.Name != "Id"))
                {
                    var textbox = property.GetValue(contact, null);
                    
                    if (textbox.ToString().ToLower().Contains(query.ToLower()))
                    {
                        result.Add(contact);
                        break;
                    }
                }
            }
            
            return result;
        }
    }
}