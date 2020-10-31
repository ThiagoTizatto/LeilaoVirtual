using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Auctions.Exceptions
{
    public class InvalidMoveException: BusinessException
    {
        public override string Message => "O valor do lance deve ser maior que o maior lance";
    }
}
