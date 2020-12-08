using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class ProductRepositoryTest
	{
		[TestMethod]
		public void RetrieveValid()
		{
			//Assert
			var productRepo = new ProductRepository();

			var expected = new Product(1)
			{
				ProductName = "Ring",
				ProductDescription = "The one ring",
				CurrentPrice = 10000,
			};

			//Act
			var actual = productRepo.Retrieve(1);

			//Arrange
			Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
			Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
			Assert.AreEqual(expected.ProductName, actual.ProductName);
		}

		[TestMethod]
		public void SaveTestValid()
		{
			//Arrange 
			var productRepo = new ProductRepository();
			var updatedProduct = new Product(1)
			{
				CurrentPrice = 18M,
				ProductDescription = "Assorted size of 4 Bright Yellow Mini Sunflowers",
				ProductName = "Sunflowers",
				HasChanges = true
			};

			//Act
			var actual = productRepo.Save(updatedProduct);

			//Assert
			Assert.AreEqual(true, actual);
		}

		[TestMethod]
		public void SaveTestMissingPrice()
		{
			//Arrange 
			var productRepo = new ProductRepository();
			var updatedProduct = new Product(2)
			{
				CurrentPrice = null,
				ProductDescription = "Assorted size of 4 Bright Yellow Mini Sunflowers",
				ProductName = "Sunflowers",
				HasChanges = true
			};

			//Act
			var actual = productRepo.Save(updatedProduct);

			//Assert
			Assert.AreEqual(false, actual);
		}
	}
}
