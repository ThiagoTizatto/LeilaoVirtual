using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Base.Common;
using LeilaoVirtual.Domain.Features.Persons.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Persons
{
    public class Person : Entity
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override bool Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new EmptyNameException();

            if (Age <= 0)
                throw new InvalidAgeException();

            return true;
        }
    }
}
