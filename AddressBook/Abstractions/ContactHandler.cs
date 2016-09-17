using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                            Email = values[5],
                            Id = values[6]
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

        public bool UpdateContact(Contact contact)
        {
            var lines = File.ReadAllLines(_constants.PathToAddressFile);
            var line = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(contact.Id))
                {
                    line = i;
                }
            }

            var sb = new StringBuilder();
            sb.Append(contact.Name + ",");
            sb.Append(contact.Address + ",");
            sb.Append(contact.Zip + ",");
            sb.Append(contact.City + ",");
            sb.Append(contact.Phone + ",");
            sb.Append(contact.Email + ",");
            sb.Append(contact.Id);

            LineChanger(sb.ToString(), _constants.PathToAddressFile, line);

            return false;
        }

        public void DeleteContact(string contactId)
        {
            var lines = File.ReadAllLines(_constants.PathToAddressFile);
            var line = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(contactId))
                {
                    line = i;
                }
            }

            RemoveLine(_constants.PathToAddressFile, line);            
        }

        public void LineChanger(string newText, string fileName, int lineToEdit)
        {
            var arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit] = newText;

            File.WriteAllLines(fileName, arrLine);
        }

        public void RemoveLine(string fileName, int lineToRemove)
        {
            var arrLine = File.ReadAllLines(fileName).ToList();
            arrLine.RemoveAt(lineToRemove);

            File.WriteAllLines(fileName, arrLine);
        }
    }
}