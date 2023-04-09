using NUnit.Framework;

namespace AddressBookNewTestProject
{
    public class AuthTestBase : TestBase
    {
        [SetUp]
        public void SetUpTest()
        {
            app.Login.Login(new AccountData("admin", "secret"));

        }
    }
}
