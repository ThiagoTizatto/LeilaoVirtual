using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Moves.Exceptions
{
    public class InvalidProductException : BusinessException
    {
        public override string Message => "É necessário um produto para fazer um lance";
    }
}
