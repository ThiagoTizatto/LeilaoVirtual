using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Features.Auctions.Exceptions;
using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Auctions
{
    public class Auction : Entity
    {
        public string Name { get; set; }
        public IList<Move> Moves { get; internal set; }

        public Move BiggerMove { get; internal set; }
        public Product Product { get; set; }

        public bool MakeMove(Move move)
        {
            if (Moves == null)
            {
                Moves = new List<Move>();
                Moves.Add(move);
            }
            else
            {
                var biggerMove = Moves.Max(x => x.MoveValue);

                if (move.MoveValue < biggerMove)
                    throw new InvalidMoveException();

                Moves.Add(move);
            }




            BiggerMove = move;

            return true;

        }
    }
}
