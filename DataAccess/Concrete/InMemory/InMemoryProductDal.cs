using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //_products daki _ bir alışkannlık .net geliştiriciler kullanılır this yazmak yerine bu daha anlaşılır gibi.
        public InMemoryProductDal()
        {

            //Oracla, Sql Server, Postgres, MongoDb
            _products = new List<Product> { 
                new Product{ ProductID = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ ProductID = 2, CategoryID = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ ProductID = 3, CategoryID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ ProductID = 4, CategoryID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ ProductID = 5, CategoryID = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); //Bu şekilde silemeyiz nedeni ise Delete methoduna gönderilen product ın gönderilirken 
            //yeni bir referans alması yeni gönderilen referans silinir eskisi kalır değer tip olmadığı için gönderdiğimiz şey referans tip
            //biz işlem yaparken primary key i kullanmalıyız yanni ProductID

            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if(product.ProductID == p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //_products.Remove(productToDelete); //bu şekilde silinir

            //LİNQ = Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
            //yukarıdaki for each yapısı yerine bu kullanılır bunu kullanmak için Linq importlamak lazım bu tür operasyonlarda linq kullanacağız


        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList(); //where ile productstaki ıdler eşleşiyosa list olarak döndürür.
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün ıdsine sahip olan urun ıd sine sahip listedeki ürünü bul demek
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }


    }
}
