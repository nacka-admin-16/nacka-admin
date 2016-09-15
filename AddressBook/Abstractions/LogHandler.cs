using System;
using System.IO;
using AddressBook.Abstractions.Interfaces;
using StructureMap;

namespace AddressBook.Abstractions
{ 
    public class LogHandler : ILogHandler
    {
        private readonly IConstants _constants = ObjectFactory.GetInstance<IConstants>();

        public void WriteToLog(Exception exception)
        {
            using (var streamWriter = new StreamWriter(_constants.PathToLogFile, true))
            {
                streamWriter.WriteLine(DateTime.Now + " " + exception.Message);
            }
        }
    }
}