using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Instagram.User.Queries
{
    public class RefreshInstagramUserData : IQuery<bool>
    {
        public string InstagramUserId { get; set; }
        public string AccessToken { get; set; }
    }
}
