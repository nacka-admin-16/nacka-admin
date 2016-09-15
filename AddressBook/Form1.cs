using System;
using System.Windows.Forms;
using AddressBook.Abstractions.Interfaces;
using AddressBook.Entities;
using StructureMap;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private readonly ICacheHandler _cacheHandler = ObjectFactory.GetInstance<ICacheHandler>();
        private readonly IContactHandler _contactHandler = ObjectFactory.GetInstance<IContactHandler>();        
        
        public Form1()
        {
            _cacheHandler.SetCacheForContacts(_contactHandler.GetContacts());

            InitializeComponent();

            txtBoxName.Focus();            
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = txtBoxName.Text,
                Address = txtBoxAddress.Text,
                Zip = txtBoxZip.Text,
                City = txtBoxCity.Text,
                Phone = txtBoxPhone.Text,
                Email = txtBoxEmail.Text,
                Id = Guid.NewGuid().ToString()
            };

            _contactHandler.ValidateContact(contact);

            //if (_contactHandler.SaveContact(contact))
            //{
            //    lblMessage.ForeColor = Color.LimeGreen;
            //    lblMessage.Text = @"Kontakten skapad";

            //    ResetContact();
            //}
            //else
            //{
            //    lblMessage.ForeColor = Color.Red;
            //    lblMessage.Text = @"Tekniskt fel";
            //}                       
        }

        private void ResetContact()
        {
            txtBoxName.Clear();
            txtBoxAddress.Clear();
            txtBoxZip.Clear();
            txtBoxCity.Clear();
            txtBoxPhone.Clear();
            txtBoxEmail.Clear();
        }        
    }    
}