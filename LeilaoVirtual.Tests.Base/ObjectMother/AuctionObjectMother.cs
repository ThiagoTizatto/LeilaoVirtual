using LeilaoVirtual.Domain.Features.Auctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Base.ObjectMother
{
    public static class AuctionObjectMother
    {
        public static Auction Defaut
        {
            get
            {
                var auction = new Auction()
                {
                    Name = "Leilao Padrao",
                    Product = ProductObjectMother.Defaut
                };

                return auction;
            }
        }

    }
}
