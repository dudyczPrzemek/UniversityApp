using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Facebook.User.Queries
{
    public class RefreshIntagramUserData : IQuery<bool>
    {
        public string FacebookUserId { get; set; }
        public string AccessToken { get; set; }
    }
}
