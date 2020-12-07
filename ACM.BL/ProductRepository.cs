using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class ProductRepository
	{
		public Product Retrieve(int productId)
		{
			var product = new Product(productId);

			if(productId == 1)
			{
				product.ProductName = "Ring";
				product.ProductDescription = "The one ring";
				product.CurrentPrice = 10000;
			}

			return product;
		}

		public bool Save()
		{
			return true;
		}
	}
}
