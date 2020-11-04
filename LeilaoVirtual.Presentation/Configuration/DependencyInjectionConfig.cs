using LeilaoVirtual.Domain.Features.Auctions.Interfaces;
using LeilaoVirtual.Domain.Features.Moves.Interfaces;
using LeilaoVirtual.Domain.Features.Persons.Interfaces;
using LeilaoVirtual.Domain.Features.Products.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using LeilaoVirtual.Infra.Data.Features.Auctions;
using LeilaoVirtual.Infra.Data.Features.Moves;
using LeilaoVirtual.Infra.Data.Features.Persons;
using LeilaoVirtual.Infra.Data.Features.Products;
using LeilaoVirtual.Service.Features.Products;
using Microsoft.Extensions.DependencyInjection;

namespace LeilaoVirtual.Presentation.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {


            services.AddScoped<LeilaoDbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IMoveRepository, MoveRepository>();
            services.AddScoped<IAuctionRepository, AuctionRepository>();

            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
