using AddressBook.Abstractions;
using AddressBook.Abstractions.Interfaces;
using StructureMap.Configuration.DSL;

namespace AddressBook.Configuration
{
    public class WebRegistry : Registry
    {
        public WebRegistry()
        {
            For<IContactHandler>()
                .Use<ContactHandler>();

            For<ILogHandler>()
                .Use<LogHandler>();
            
            For<IConstants>()
                .Use<Constants>();

            For<ISearch>()
                .Use<Search>();
        }
    }
}