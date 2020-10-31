using FluentAssertions;
using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Moves.Exceptions;
using LeilaoVirtual.Tests.Base.ObjectMother;
using LeilaoVirtual.Tests.Base.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Domain.Features.Moves
{
    public class TestDomainMove : TestBase
    {
        private Move _move;
        public override void Initialize()
        {
            _move = null;
        }


        [Test]
        public void Move_Default_Should_Be_OK()
        {
            //arrange
            _move = MoveObjectMother.Default;

            //Action
            Action act = () => _move.Validate();
            bool result = _move.Validate();

            //Validation
            act.Should().NotThrow<BusinessException>();
            result.Should().BeTrue();
        }

        [Test]
        public void Move_InvalidPerson_Should_Throw_Exception()
        {
            //arrange
            _move = MoveObjectMother.InvalidPerson;

            //Action
            Action act = () => _move.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<InvalidPersonException>();

        }

        [Test]
        public void Move_InvalidMoveValue_Should_Throw_Exception()
        {
            //arrange
            _move = MoveObjectMother.InvalidMoveValue;

            //Action
            Action act = () => _move.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<InvalidMoveValueException>();

        }
    }
}
