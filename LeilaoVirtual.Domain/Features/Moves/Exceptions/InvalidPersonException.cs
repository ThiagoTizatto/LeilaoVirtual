using LeilaoVirtual.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Moves.Exceptions
{
    public class InvalidPersonException : BusinessException
    {

        public override string Message => "É necessário uma pessoa para fazer um lance";
    }
}
