﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID=1, CategoryID= 1, ProductName ="Elma", UnitPrice= 10, UnitsInStock= 44},
                new Product{ProductID=2, CategoryID= 2, ProductName ="Masa", UnitPrice= 15, UnitsInStock= 24},
                new Product{ProductID=3, CategoryID= 2, ProductName ="Tablo", UnitPrice= 177, UnitsInStock= 33},
                new Product{ProductID=4, CategoryID= 2, ProductName ="Kaşık", UnitPrice= 1, UnitsInStock= 64},
                new Product{ProductID=5, CategoryID= 2, ProductName ="Bardak", UnitPrice= 50, UnitsInStock= 44},
                new Product{ProductID=6, CategoryID= 1, ProductName ="Muz", UnitPrice= 13, UnitsInStock= 4400},
                new Product{ProductID=7, CategoryID= 1, ProductName ="Armut", UnitPrice= 10, UnitsInStock= 440}
            };
        }



        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
