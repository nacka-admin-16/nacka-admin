using System;

namespace AddressBook.Abstractions.Interfaces
{
    public interface ILogHandler
    {
        void WriteToLog(Exception exception);
    }
}