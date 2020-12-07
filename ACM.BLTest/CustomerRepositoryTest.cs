using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetrieveValid()
		{
			//Assert
			var customerRepository = new CustomerRepository();
			

			var customer = new Customer(1)
			{
				EmailAddress = "john_doe@gmail.com",
				FirstName = "John",
				LastName = "Doe",
			};
			var expected = customer;

			//Act
			var actual = customerRepository.Retrieve(1);

			//Arrange
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);
		}
	}
}
