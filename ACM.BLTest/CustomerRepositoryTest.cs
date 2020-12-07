using System;
using System.Linq;
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
			var addressRepo = new AddressRepository();
			

			var customer = new Customer(1)
			{
				EmailAddress = "john_doe@gmail.com",
				FirstName = "John",
				LastName = "Doe",
				AddressList = addressRepo.RetrieveByCustomerId(0).ToList()
		};
			var expected = customer;

			//Act
			var actual = customerRepository.Retrieve(1);

			//Arrange
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);
			Assert.AreEqual(expected.AddressList[0].StreetLine1, actual.AddressList[0].StreetLine1);
		}
	}
}
