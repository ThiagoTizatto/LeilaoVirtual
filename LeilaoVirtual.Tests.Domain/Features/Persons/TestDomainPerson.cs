using FluentAssertions;
using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Base.Common;
using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Persons.Exceptions;
using LeilaoVirtual.Tests.Base.ObjectMother;
using LeilaoVirtual.Tests.Base.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Domain.Features.Persons
{
    public class TestDomainPerson : TestBase
    {
        private Person _person;
        public override void Initialize()
        {
            _person = null;
        }

        [Test]
        public void Person_Default_Should_Be_OK()
        {
            //arrange
            _person = PersonObjectMother.Defaut;

            //Action
            Action act = () => _person.Validate();
            bool result = _person.Validate();

            //Validation
            act.Should().NotThrow<BusinessException>();
            result.Should().BeTrue();
        }

        [Test]
        public void Person_InvalidName_Should_Throw_Exception()
        {
            //arrange
            _person = PersonObjectMother.InvalidName;

            //Action
            Action act = () => _person.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<EmptyNameException>();

        }

        [Test]
        public void Person_InvalidValue_Should_Throw_Exception()
        {
            //arrange
            _person = PersonObjectMother.InvalidAge;

            //Action
            Action act = () => _person.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<InvalidAgeException>();

        }
    }
}
