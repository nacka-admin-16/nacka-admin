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

            For<ICacheHandler>()
                .Use<CacheHandler>();

            For<IConstants>()
                .Use<Constants>();
        }
    }
}