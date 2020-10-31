using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Persons.Exceptions
{
    public class InvalidAgeException : BusinessException
    {
        public override string Message => "A idade tem que ser maior que Zero";
    }
}
