using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AddressBook.Abstractions.Interfaces;
using AddressBook.Entities;
using StructureMap;

namespace AddressBook.Abstractions
{
    public class ContactHandler : IContactHandler
    {
        private readonly ILogHandler _logHandler = ObjectFactory.GetInstance<ILogHandler>();
        private readonly IConstants _constants = ObjectFactory.GetInstance<IConstants>();

        public List<Contact> GetContacts()
        {
            using (var reader = new StreamReader(_constants.PathToAddressFile))
            {
                var contacts = new List<Contact>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (line != null)
                    {
                        var values = line.Split(',');
                        var contact = new Contact
                        {
                            Name = values[0],
                            Address = values[1],
                            Zip = values[2],
                            City = values[3],
                            Phone = values[4],
                            Email = values[5]
                        };
                        
                        contacts.Add(contact);
                    }
                }

                return contacts;
            }            
        }

        public void ValidateContact(Contact contact)
        {
            
        }


        public bool SaveContact(Contact contact)
        {
            try
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.Append(contact.Name);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.Address);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.Zip);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.City);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.Phone);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.Email);
                stringBuilder.Append(",");
                stringBuilder.Append(contact.Id);

                using (var streamwriter = new StreamWriter(_constants.PathToAddressFile, true))
                {
                    streamwriter.WriteLine(stringBuilder);
                }

                return true;
            }
            catch (Exception exception)
            {
                _logHandler.WriteToLog(exception);
                
                return false;
            }
        }

        public bool UpdateContact(string id)
        {
            return false;
        }
    }
}