using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Base.Common;
using LeilaoVirtual.Domain.Features.Products.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Products
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public double Value { get; set; }


        public override bool Validate()
        {
            if (String.IsNullOrEmpty(Name))
                throw new EmptyNameException();

            if (Value <= 0)
                throw new InvalidValueException();

            return true;
        }
    }
}
 