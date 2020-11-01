using AutoMapper;
using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Products;
using LeilaoVirtual.Presentation.Models.Features.Auctions;
using LeilaoVirtual.Presentation.Models.Features.Moves;
using LeilaoVirtual.Presentation.Models.Features.Persons;
using LeilaoVirtual.Presentation.Models.Features.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeilaoVirtual.Presentation.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Auction, AuctionViewModel>().ReverseMap();
            CreateMap<Move, MoveViewModel>().ReverseMap();
            CreateMap<Person, PersonViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
