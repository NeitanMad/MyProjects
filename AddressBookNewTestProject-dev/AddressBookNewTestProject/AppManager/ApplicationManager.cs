using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AddressBookNewTestProject
{
    public class ApplicationManager
    {

        protected IWebDriver driver;

        protected LoginHelper login;
        protected NavigationHelper navigation;
        protected GroupHelper group;
        protected ContactHelper contact;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            login = new LoginHelper(this);
            navigation = new NavigationHelper(this);
            group = new GroupHelper(this);
            contact = new ContactHelper(this);

        }

        public ContactHelper Contacts { get { return contact; } }
        public LoginHelper Login { get { return login; } }
        public NavigationHelper Navigation { get { return navigation; } }
        public GroupHelper Group { get { return group; } }

        public IWebDriver Driver { get { return driver; } }

    }
}
