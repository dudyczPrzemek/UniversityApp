using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Base
{
    public abstract class CommandBase
    {
        public virtual string AccessToken { get; set; }
    }
}
