using ApiProduct.Models;
using ApiProduct.Models.Dto;
using ApiProduct.Repositories;
using ApiProduct.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiProduct.Controllers
{
    public class ProductsController : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();

        // Get all products
        public IEnumerable<ProductDto> GetAllProducts()
        {
            return repository.GetAll();
        }
        // Get by ID
        public ProductDto GetProduct(int id)
        {
            ProductDto item = repository.FindById(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        // Delete product
        public IHttpActionResult DeleteProduct(int id)
        {
            ProductDto item = repository.FindById(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Delete(id);
            return Ok("Producto borrado de forma exitosa");
        }
        // Create product
        public IHttpActionResult PostProduct(CreateProductDto product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            var productDtoResponse = repository.Create(product);

            return CreatedAtRoute("DefaultApi", new { id = productDtoResponse.Id }, productDtoResponse);

        }
        // Edit product
        public IHttpActionResult PutProduct(int id, CreateProductDto product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedProduct = repository.Update(id,product);

            if (updatedProduct == null)
            {
                return NotFound();
            }

            return Ok(updatedProduct);
        }
        
    }
}