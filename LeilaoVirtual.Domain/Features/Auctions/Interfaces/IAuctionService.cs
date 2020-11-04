using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Auctions.Interfaces
{
    public interface IAuctionService
    {
        Auction Add(Auction entity);
        Auction GetById(long id);
        IList<Auction> GetAll();
        void Update(Auction entity);
        void Delete(Auction entity);
    }
}
