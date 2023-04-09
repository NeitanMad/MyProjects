using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace AddressBookNewTestProject
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        //public ContactData GetContactInformationFromTable(int index)
        //{
        //    manager.Navigation.OpenHomePage();
        //    IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index].FindElements(By.TagName("td"));
        //    string firstName = cells[1].Text;
        //    string lastName = cells[2].Text;
        //    string address = cells[3].Text;
        //    string allPhones = cells[5].Text;
        //    return new ContactData(firstName, lastName)
        //    {
        //        Address = address,
        //        AllPhones = allPhones,
        //    };
        //}

        internal double GetContactCount()
        {
            throw new NotImplementedException();
        }

        internal List<ContactData> GetContacts()
        {
            throw new NotImplementedException();
        }

        //public ContactData GetContactInformationFromEditForm(int index)
        //{
        //    manager.Navigation.OpenHomePage();
        //    InitContactModification(0);
        //    string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
        //    string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
        //    string address = driver.FindElement(By.Name("address")).GetAttribute("value");

        //    string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
        //    string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
        //    string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

        //    return new ContactData(firstName, lastName)
        //    {
        //        Address = address,
        //        HomePhone = homePhone,
        //        MobilePhone = mobilePhone,
        //        WorkPhone = workPhone
        //    };

        //}

        //private void InitContactModification(int index)
        //{
        //    driver.FindElements(By.Name("entry"))[index]
        //        .FindElements(By.TagName("td"))[7]
        //        .FindElement(By.TagName("a")).Click();
        //}

        public ContactHelper CreateContact(ContactData contactData)
        {
            manager.Navigation.OpenAddNewContactPage();
            FildForms(contactData);
            Submit();
            return this;
        }

        public void Submit()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FildForms(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).SendKeys(contact.HomePhone);
        }
    }
}
