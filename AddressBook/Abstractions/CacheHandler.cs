using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using AddressBook.Abstractions.Interfaces;
using AddressBook.Entities;
using StructureMap;

namespace AddressBook.Abstractions
{
    public class CacheHandler : ICacheHandler
    {
        private readonly IConstants _siteConstants = ObjectFactory.GetInstance<IConstants>();

        public void SetCacheForContacts(List<Contact> contacts)
        {            
            HttpRuntime.Cache.Insert(_siteConstants.Contacts, contacts, null, DateTime.Now.AddDays(1), Cache.NoSlidingExpiration);
        }

        public List<Contact> GetCacheForContacts()
        {
            var sitesWithAgreements = HttpRuntime.Cache[_siteConstants.Contacts] as List<Contact>;

            return sitesWithAgreements;
        }
    }
}