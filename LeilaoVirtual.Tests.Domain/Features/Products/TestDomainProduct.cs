using FluentAssertions;
using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Base.Common;
using LeilaoVirtual.Domain.Features.Products;
using LeilaoVirtual.Domain.Features.Products.Exceptions;
using LeilaoVirtual.Tests.Base.ObjectMother;
using LeilaoVirtual.Tests.Base.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Domain.Features.Products
{
    public class TestDomainProduct : TestBase
    {
        private Product _product;
        public override void Initialize()
        {
            _product = null;
        }


        [Test]
        public void Product_Default_Should_Be_OK()
        {
            //arrange
            _product = ProductObjectMother.Defaut;

            //Action
            Action act = () => _product.Validate();
            bool result = _product.Validate();

            //Validation
            act.Should().NotThrow<BusinessException>();
            result.Should().BeTrue();
        }

        [Test]
        public void Product_InvalidName_Should_Throw_Exception()
        {
            //arrange
            _product = ProductObjectMother.InvalidName;

            //Action
            Action act = () => _product.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<EmptyNameException>();

        }

        [Test]
        public void Product_InvalidValue_Should_Throw_Exception()
        {
            //arrange
            _product = ProductObjectMother.InvalidValue;

            //Action
            Action act = () => _product.Validate();

            //Validation
            act.Should().Throw<BusinessException>();
            act.Should().Throw<InvalidValueException>();

        }



    }
}
