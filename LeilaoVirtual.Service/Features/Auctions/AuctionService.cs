using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Auctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Service.Features.Auctions
{
    public class AuctionService : IAuctionService
    {
        IAuctionRepository _repository;
        public AuctionService(IAuctionRepository repository)
        {
            _repository = repository;
        }
        public Auction Add(Auction entity)
        {
            entity.Validate();
            return _repository.Add(entity);
        }

        public void Update(Auction entity)
        {
            entity.Validate();
            _repository.Update(entity);
        }

        public Auction GetById(long id)
        {
            return _repository.GetById(id);
        }

        public IList<Auction> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(Auction entity)
        {
            _repository.Delete(entity);
        }
    }
}
