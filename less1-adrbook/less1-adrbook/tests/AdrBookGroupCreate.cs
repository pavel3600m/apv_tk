﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AdrBookGroupCreation : TestBase
    {
      
        [Test]
        public void AdrBookGroupCreate()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            app.Groups.FillGroupForm(group);
            app.Groups.SUbmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
        }
    }
}
