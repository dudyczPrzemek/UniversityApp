using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Twitter.User.Queries
{
    public class RefreshTwitterDataUser : IQuery<bool>
    {
        public string TwitterUserId { get; set; }
    }
}
