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
		public void ToUpperTest()
		{
			TestController controller = new TestController();
			string testString = "TestMe";
			Assert.AreEqual(testString.ToUpper(), controller.ToUpper(testString));
			Assert.IsTrue(controller.ToUpper(null) != null);
		}

		[TestMethod()]
		public void ToLowerTest()
		{
			TestController controller = new TestController();
			string testString = "TestMe";
			Assert.AreEqual(testString.ToLower(), controller.ToLower(testString));
			Assert.IsTrue(controller.ToLower(null) != null);
		}

		[TestMethod()]
		public void HealthTest()
		{
			TestController controller = new TestController();
			Assert.IsTrue(!string.IsNullOrEmpty(controller.HealthCheck(null)));
		}
	}
}