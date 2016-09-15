namespace AddressBook.Abstractions.Interfaces
{
    public interface IConstants
    {
        string PathToAddressFile { get; }

        string PathToLogFile { get; }

        string Contacts { get; }
    }
}