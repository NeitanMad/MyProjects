using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNewTestProject
{
    [TestFixture]
    public class CreateContact : AuthTestBase
    {
        [Test]
        public void CreateContactTest()
        {
            //List<ContactData> oldContacts = app.Contacts.GetContacts();
            ContactData contact = new ContactData("Имя", "Фамилия", "qwerty@mail.ru", "+71234567890");
            //{
            //    Address = "address",
            //    HomePhone = "homePhone",
            //    MobilePhone = "mobilePhone",
            //    WorkPhone = "workPhone"
            //};

            app.Contacts.CreateContact(contact); // null

            //Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            //List<ContactData> newContacts = app.Contacts.GetContacts();
            //oldContacts.Add(contact);
            //oldContacts.Sort();
            //newContacts.Sort();
            //Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
