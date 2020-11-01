using LeilaoVirtual.Domain.Features.Products;
using LeilaoVirtual.Domain.Features.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Service.Features.Products
{
    public class ProductService : IProductService
    {
        IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public Product Add(Product entity)
        {
            entity.Validate();
            return _repository.Add(entity);
        }

        public void Update(Product entity)
        {
            entity.Validate();
            _repository.Update(entity);
        }

        public Product GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IList<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(Product entity)
        {
            _repository.Delete(entity);
        }
    }
}
