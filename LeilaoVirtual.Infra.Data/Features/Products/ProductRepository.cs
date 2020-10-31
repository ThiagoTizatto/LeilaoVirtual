using LeilaoVirtual.Domain.Base.Interfaces;
using LeilaoVirtual.Domain.Features.Products;
using LeilaoVirtual.Domain.Features.Products.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Features.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(LeilaoDbContext db) : base(db)
        {
        }
    }
}
