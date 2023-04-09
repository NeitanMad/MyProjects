using OpenQA.Selenium;
using System;

namespace AddressBookNewTestProject
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }
        public void Login(AccountData accountData)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(accountData))
                {
                    return;
                }
                Logout();
            }
            Type(By.Name("user"), accountData.Username);
            //Console.WriteLine($"{accountData.Username} -- {(nameof(accountData.Username))}");
            Type(By.Name("pass"), accountData.Password);
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn() && GetLoggedUserName() == account.Username;
        }

        private string GetLoggedUserName()
        {

            string text = driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text;
            return text.Substring(1, text.Length - 2);
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();

            }
        }
    }
}
