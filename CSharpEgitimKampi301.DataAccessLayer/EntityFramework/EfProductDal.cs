using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public List<Object> GetProductsWitsCategory()
		{
			var context = new KampContext();
			var values = context.Products
				.Select(x=> new 
				{
					ProductId = x.ProductId,
					ProductName = x.ProductName,
					ProductPrice = x.ProductPrice,
					ProductStock = x.ProductStock,
					ProductDescription = x.ProductDescription,
					CategoryName = x.Category.CategoryName
				}).ToList();
			return values.Cast<object>().ToList();
		}
	}
}
