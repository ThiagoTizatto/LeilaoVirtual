using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Base
{
    public abstract class Entity
    {
        public long Id{ get; set; }


        public virtual bool Validate()
        {
            return true;
        }
    }
}
