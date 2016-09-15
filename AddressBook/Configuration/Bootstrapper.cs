using StructureMap;

namespace AddressBook.Configuration
{
    public class Bootstrapper
    {
        public static void ConfigureStructureMap(IContainer container)
        {
            container.Configure(x => x.AddRegistry(new WebRegistry()));
        }
    }
}