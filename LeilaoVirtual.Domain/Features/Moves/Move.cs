using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Moves.Exceptions;
using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Products;

namespace LeilaoVirtual.Domain.Features.Moves
{
    public class Move : Entity
    {
        public Person Person { get; set; }
      

        public double MoveValue { get; set; }

        //EF relations
        public Auction Auction { get; set; }

        public override bool Validate()
        {
            if (Person == null)
                throw new InvalidPersonException();

            if (MoveValue <= 0)
                throw new InvalidMoveValueException();

            return true;
        }


    }
}
