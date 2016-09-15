using AddressBook.Abstractions.Interfaces;

namespace AddressBook.Abstractions
{
    public class Constants : IConstants
    {
        public string PathToAddressFile
        {
            get { return @"C:\Projects\nacka-admin\AddressBook\addressbook.txt"; }
        }
        
        public string PathToLogFile
        {
            get { return @"C:\Projects\nacka-admin\AddressBook\logs.txt"; }
        }

        public string Contacts
        {
            get { return "CONTACTS"; }
        }
    }
}