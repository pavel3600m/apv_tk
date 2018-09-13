using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AdrBookGroupRemoval : TestBase
    {

        [Test]
        public void AdrBookGroupRemove()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.SelectGroup(3);
            app.Groups.RemoveGroup();
            app.Groups.ReturnToGroupsPage();
        }
    }
}
