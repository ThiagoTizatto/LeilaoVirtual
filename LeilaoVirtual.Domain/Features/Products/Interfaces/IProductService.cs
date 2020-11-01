using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Products.Interfaces
{
    public interface IProductService
    {
        Product Add(Product entity);
        Product GetById(Guid id);
        IList<Product> GetAll();
        void Update(Product entity);
        void Delete(Product entity);
    }
}
