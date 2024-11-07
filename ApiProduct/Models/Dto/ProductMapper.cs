using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProduct.Models.Dto
{
    public class ProductMapper 
    {
        // ProductDto -> Product
        public Product MapperDtoToProduct(ProductDto productDto)
        {
            if (productDto == null)
            {
                throw new ArgumentNullException(nameof(productDto));
            }

            return new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };
        }
        // Product -> ProductDto
        public ProductDto MapperProductToDto(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
        // CreateProductDto -> Product
        public Product MapperCreateProductToProduct(CreateProductDto createProductDto)
        {
            if (createProductDto == null)
            {
                throw new ArgumentNullException(nameof(createProductDto));
            }

            return new Product
            {
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Quantity = createProductDto.Quantity
            };
        }
        // IEnumerable<Product> -> IEnumerable<ProductDto>
        public IEnumerable<ProductDto> MapperProductsToDtos(IEnumerable<Product> products)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            return products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            });
        }
    }
}