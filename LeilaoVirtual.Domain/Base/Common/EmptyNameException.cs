using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Base.Common
{
    public class EmptyNameException : BusinessException
    {
        public override string Message => "O Nome não pode ser vazio";
    }
}
