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
            app.Groups.Remove(1);
        }
    }
}
