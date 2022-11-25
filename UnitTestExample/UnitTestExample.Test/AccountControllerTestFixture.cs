﻿using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample
{
	public class AccountControllerTestFixture
	{
		[
		 Test,
		 TestCase("abcd1234", false),
		 TestCase("irf@uni-corvinus", false),
		 TestCase("irf.uni-corvinus.hu", false),
		 TestCase("irf@uni-corvinus.hu", true)
 ]
		public void TestValidateEmail(string email, bool expectedResult)
		{
			// Arrange
			var accountController = new AccountController();

			// Act
			var actualResult = accountController.ValidateEmail(email);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
		[
		 Test,
		 TestCase("abcDeFGd", false),
		 TestCase("HALLOH1ALLO", false),
		 TestCase("jelszojelszo", false),
		TestCase("irf", false),
		 TestCase("irfIrf12", true)
		]
		public void TestValidatePassword(string password, bool expectedResult)
		{
			// Arrange
			var accountController = new AccountController();

			// Act
			var actualResult = accountController.ValidatePassword(password);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
