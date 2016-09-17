using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using AddressBook.Abstractions.Interfaces;
using AddressBook.Entities;
using StructureMap;

namespace AddressBook
{
    public partial class Form1 : Form
    {        
        private readonly IContactHandler _contactHandler = ObjectFactory.GetInstance<IContactHandler>();
        private readonly ISearch _search = ObjectFactory.GetInstance<ISearch>();

        public Form1()
        {
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
            };

            //todo validate contact
            if (HttpRuntime.Cache["CONTACT_ID"] != null)
            {
                contact.Id = HttpRuntime.Cache["CONTACT_ID"] as string;

                _contactHandler.UpdateContact(contact);

                lblMessage.ForeColor = Color.LimeGreen;
                lblMessage.Text = @"Kontakten uppdaterad";

                ResetContact();
                lstBoxContacts.DataSource = new List<Contact>();
                txtBoxSearch.Clear();
                txtBoxSearch.Focus();
            }
            else
            {
                contact.Id = Guid.NewGuid().ToString();
                _contactHandler.SaveContact(contact);

                lblMessage.ForeColor = Color.LimeGreen;
                lblMessage.Text = @"Kontakten sparad";

                ResetContact();
                lstBoxContacts.DataSource = new List<Contact>();
                txtBoxSearch.Clear();
                txtBoxName.Focus();
            }            
        }        

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = txtBoxSearch.Text;

            if (!string.IsNullOrWhiteSpace(query))
            {
                var contacts = _search.SearchForContacts(query);

                lstBoxContacts.DataSource = contacts;
                lstBoxContacts.DisplayMember = "Name";

                if (!contacts.Any())
                {
                    ResetContact();
                    txtBoxSearch.Focus();
                }
            }
            else
            {
                lstBoxContacts.DataSource = new List<Contact>();
                ResetContact();
                txtBoxSearch.Focus();
            }
        }

        private void lstBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxContacts.SelectedValueChanged += lstBoxContacts_SelectedValueChanged;
        }

        private void lstBoxContacts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstBoxContacts.SelectedIndex != -1)
            {
                lblMessage.Text = @"";

                var listBox = (ListBox) sender;
                var contact = (Contact) listBox.SelectedItem;

                txtBoxName.Text = contact.Name;
                txtBoxAddress.Text = contact.Address;
                txtBoxZip.Text = contact.Zip;
                txtBoxCity.Text = contact.City;
                txtBoxPhone.Text = contact.Phone;
                txtBoxEmail.Text = contact.Email;
                btnSaveContact.Text = @"Uppdatera kontakt";

                HttpRuntime.Cache.Insert("CONTACT_ID", contact.Id);
            }
            else
            {
                HttpRuntime.Cache.Remove("CONTACT_ID");
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            var contactId = HttpRuntime.Cache["CONTACT_ID"] as string;

            if (!string.IsNullOrWhiteSpace(contactId))
            {
                _contactHandler.DeleteContact(contactId);
                
                var contacts = _search.SearchForContacts(txtBoxSearch.Text);
                lstBoxContacts.DataSource = contacts;

                if (!contacts.Any())
                {
                    ResetContact();
                    txtBoxSearch.Clear();
                    txtBoxName.Focus();
                }
            }
        }

        private void ResetContact()
        {
            txtBoxName.Clear();
            txtBoxAddress.Clear();
            txtBoxZip.Clear();
            txtBoxCity.Clear();
            txtBoxPhone.Clear();
            txtBoxEmail.Clear();            
            
            btnSaveContact.Text = @"Spara kontakt";
        }
    }    
}