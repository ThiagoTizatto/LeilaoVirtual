using FluentAssertions;
using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Auctions.Exceptions;
using LeilaoVirtual.Tests.Base.ObjectMother;
using LeilaoVirtual.Tests.Base.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Domain.Features.Auctions
{
    public class TestDomainAuction : TestBase
    {
        private Auction _auction;
        public override void Initialize()
        {
            _auction = null;
        }

        [Test]
        public void Auction_MakeMove_Should_Be_OK()
        {
            //arrange
            _auction = AuctionObjectMother.Defaut;

            //Action
            _auction.MakeMove(MoveObjectMother.Default);
            _auction.MakeMove(MoveObjectMother.Default2);
            _auction.MakeMove(MoveObjectMother.Default3);

            //Validation
            _auction.BiggerMove.MoveValue.Should().Be(MoveObjectMother.Default3.MoveValue);
            _auction.BiggerMove.Person.Name.Should().Be(MoveObjectMother.Default3.Person.Name);
            _auction.BiggerMove.Person.Age.Should().Be(MoveObjectMother.Default3.Person.Age);

        }

        [Test]
        public void Auction_MakeMove_Alternative_Should_Be_OK()
        {
            //arrange
            _auction = AuctionObjectMother.Defaut;

            //Action

            _auction.MakeMove(MoveObjectMother.Default2);
            Action act = () => _auction.MakeMove(MoveObjectMother.Default);

            //Validation
            act.Should().Throw<InvalidMoveException>();
            _auction.BiggerMove.MoveValue.Should().Be(MoveObjectMother.Default2.MoveValue);
            _auction.BiggerMove.Person.Name.Should().Be(MoveObjectMother.Default2.Person.Name);
            _auction.BiggerMove.Person.Age.Should().Be(MoveObjectMother.Default2.Person.Age);

        }
    }
}
