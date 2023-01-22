


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

var result = productManager.GetProductDetailDtos();

if (result.Success == true)
{
	foreach (var product in result.Data)
	{
        Console.WriteLine("Kategorisi: {0}", product.CategoryName);
        Console.WriteLine("Ürün Adı: {0}", product.ProductName);
        Console.WriteLine("Fiyatı: {0}", product.UnitPrice);
        Console.WriteLine("Stok Adedi: {0}", product.UnitsInStock);
        Console.WriteLine("--------------------------------------");
    }
}
else
{
    Console.WriteLine(result.Message);
}


Console.ReadLine();