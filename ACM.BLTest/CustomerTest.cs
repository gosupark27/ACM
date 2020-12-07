using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]
		public void FullNameTestValid()
		{
			//Arrange
			Customer customer = new Customer
			{
				FirstName = "John",
				LastName = "Doe"
			};

			string expected = "Doe, John";

			//Act
			string actual = customer.FullName;

			//Asert
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FullNameFirstEmpty()
		{
			//Arrange
			Customer customer = new Customer
			{
				LastName = "Doe"
			};

			string expected = "Doe";

			//Act
			string actual = customer.FullName;

			//Asert
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FullNameLastEmpty()
		{
			//Arrange
			Customer customer = new Customer
			{
				FirstName = "John"
			};

			string expected = "John";

			//Act
			string actual = customer.FullName;

			//Asert
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void ValidateValid()
		{
			//Arrange
			var customer = new Customer
			{
				LastName = "Doe",
				EmailAddress = "jdoe@gmail.com"
			};

			var expected = true;

			//Act
			var actual = customer.Validate();

			//Assert
			Assert.AreEqual(expected, actual);


		}

		[TestMethod]
		public void ValidateMissingLastName()
		{
			//Arrange
			var customer = new Customer
			{
				EmailAddress = "jdoe@gmail.com"
			};

			var expected = false;

			//Act
			var actual = customer.Validate();

			//Assert
			Assert.AreEqual(expected, actual);


		}
	}
}
