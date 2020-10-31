using LeilaoVirtual.Domain.Base.Interfaces;
using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Moves.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Features.Moves
{
    public class MoveRepository : Repository<Move>, IMoveRepository
    {
        public MoveRepository(LeilaoDbContext db) : base(db)
        {
        }
    }
}
