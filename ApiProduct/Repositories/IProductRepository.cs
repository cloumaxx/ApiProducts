using ApiProduct.Models;
using ApiProduct.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Repository
{
    interface IProductRepository
    {
 
        IEnumerable<ProductDto> GetAll();
        ProductDto FindById(int id);
        ProductDto Create(CreateProductDto item);
        void Delete(int id);
        ProductDto Update(int id, CreateProductDto item);
    }
}


