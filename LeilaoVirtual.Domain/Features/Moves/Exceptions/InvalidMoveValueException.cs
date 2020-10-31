using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Moves.Exceptions
{
    public class InvalidMoveValueException : BusinessException
    {
        public override string Message => "O valor do lance deve ser maior que 0";
    }
}
