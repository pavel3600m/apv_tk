using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests.tests
{

    [TestFixture]

    public class AdrBookGroupModification : TestBase
    {

        [Test]
        public void AdrBookGroupModify()
        {
            GroupData newData = new GroupData("modify");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData);
        }
    }
}
