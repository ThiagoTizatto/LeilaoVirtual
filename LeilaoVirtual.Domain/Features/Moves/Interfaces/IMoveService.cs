using LeilaoVirtual.Domain.Features.Auctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Moves.Interfaces
{
    public interface IMoveService
    {
        Move Add(Move entity);
        Move GetById(Guid id);
        IList<Move> GetAll();
        void Update(Move entity);
        void Delete(Move entity);
    }
}
