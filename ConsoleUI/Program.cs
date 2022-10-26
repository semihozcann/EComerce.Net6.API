


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine("Ürün Adı: {0} - Fiyatı: {1}", product.ProductName, product.UnitPrice);
}

Console.ReadLine();