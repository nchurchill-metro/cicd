using Microsoft.VisualStudio.TestTools.UnitTesting;
using CicdApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CicdApp.Controllers.Tests
{
	[TestClass()]
	public class TestControllerTests
	{
		[TestMethod()]
		public void GetStuffTest()
		{
			TestController controller = new TestController();
			Assert.AreEqual("TESTME  Fail Me", controller.GetStuff("TestMe"));
		}
	}
}