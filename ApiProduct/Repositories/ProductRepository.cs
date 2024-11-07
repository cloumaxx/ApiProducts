using ApiProduct.Models;
using ApiProduct.Models.Dto;
using ApiProduct.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProduct.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductMapper productMapper = new ProductMapper();
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200.99m, Quantity = 10 },
            new Product { Id = 2, Name = "Smartphone", Price = 699.50m, Quantity = 25 },
            new Product { Id = 3, Name = "Headphones", Price = 199.99m, Quantity = 15 },
            new Product { Id = 4, Name = "Monitor", Price = 299.99m, Quantity = 8 },
            new Product { Id = 5, Name = "Keyboard", Price = 49.99m, Quantity = 20 },
            new Product { Id = 6, Name = "Mouse", Price = 29.99m, Quantity = 30 },
            new Product { Id = 7, Name = "External Hard Drive", Price = 89.99m, Quantity = 12 },
            new Product { Id = 8, Name = "USB-C Cable", Price = 9.99m, Quantity = 50 },
            new Product { Id = 9, Name = "Smartwatch", Price = 149.99m, Quantity = 18 },
            new Product { Id = 10, Name = "Tablet", Price = 329.99m, Quantity = 5 }
        };

        public ProductDto Create(CreateProductDto createProductDto)
        {
            if (createProductDto == null)
            {
                throw new ArgumentNullException(nameof(createProductDto));
            }

            Product product = productMapper.MapperCreateProductToProduct(createProductDto);
            product.Id = products.Count() + 1;
            products.Add(product);

            return productMapper.MapperProductToDto(product);
        }

        public void Delete(int id)
        {
            products.RemoveAll(product => product.Id == id);
        }

        public ProductDto FindById(int id)
        {
            Product product = products.Find(prod => prod.Id == id);

            if (product == null)
            {
                throw new KeyNotFoundException("No se encontró el producto con el ID especificado.");
            }
            return productMapper.MapperProductToDto(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return productMapper.MapperProductsToDtos(products);
        }

        public ProductDto Update(int id,CreateProductDto productDto)
        {
            if (productDto == null)
            {
                throw new ArgumentNullException("item");
            }

            Product product = productMapper.MapperCreateProductToProduct(productDto);
            product.Id = id;    
            int index = products.FindIndex(p => p.Id == id);
            if (index == -1)
            {
                throw new KeyNotFoundException("No se encontró el producto con el ID especificado.");
            }
            products.RemoveAt(index);
            products.Add(product);
            return productMapper.MapperProductToDto(product);
        }

        
    }
}