using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNewTestProject
{
    public class TestBase
    {

        public ApplicationManager app;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            app = new ApplicationManager();
            js = (IJavaScriptExecutor)app.Driver;
            vars = new Dictionary<string, object>();
            app.Navigation.OpenHomePage();
        }
        [TearDown]
        public void Teardown()
        {
            app.Driver.Quit();
        }

        public static Random random = new Random();

        public static string GenerateRandomString(int max)
        {
            
            int l = random.Next(1, max + 1);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                builder.Append(Convert.ToChar(random.Next(32, 223)));
            }

            return builder.ToString();
        }

    }
}
