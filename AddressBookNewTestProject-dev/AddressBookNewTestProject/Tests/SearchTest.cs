using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace AddressBookNewTestProject
{
    public class Search : AuthTestBase
    {
        [Test]
        public void SearchTest()
        {
            Console.WriteLine(app.Contacts.GetNumberOfSearchREsults());
            int count = (int)app.Contacts.GetContactCount();
            int searchCount = app.Contacts.GetNumberOfSearchREsults();
            Assert.AreEqual(count, searchCount);
        }
    }
}
