using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Products.Exceptions
{
    public class InvalidValueException : BusinessException
    {
        public override string Message => "O valor tem que ser maior que zero";
    }
}
