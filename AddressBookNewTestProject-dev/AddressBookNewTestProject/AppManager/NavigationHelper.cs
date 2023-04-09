using OpenQA.Selenium;
using System;

namespace AddressBookNewTestProject
{
    public class NavigationHelper : HelperBase
    {

        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void OpenHomePage()
        {
            if (driver.Url == "http://localhost/addressbook/group.php" && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
            driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        }

        public void OpenGroupPage()
        {
            if (driver.Url == "http://localhost/addressbook/group.php" && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void ReturnGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        public void OpenAddNewContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
