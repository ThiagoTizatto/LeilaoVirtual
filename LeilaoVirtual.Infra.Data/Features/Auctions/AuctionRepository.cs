using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Auctions.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Features.Auctions
{
    public class AuctionRepository : Repository<Auction>, IAuctionRepository
    {
        public AuctionRepository(LeilaoDbContext db) : base(db)
        {
        }
    }
}
