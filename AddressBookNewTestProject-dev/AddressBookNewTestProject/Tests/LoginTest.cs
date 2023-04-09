using NUnit.Framework;

namespace AddressBookNewTestProject
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            app.Login.Logout();
            AccountData account = new AccountData("admin", "secret");
            app.Login.Login(account);
            Assert.IsTrue(app.Login.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithINValidCredentials()
        {
            app.Login.Logout();
            AccountData account = new AccountData("admin", "12345");
            app.Login.Login(account);
            Assert.IsFalse(app.Login.IsLoggedIn(account));
        }

    }


}
