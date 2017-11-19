using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Instagram.User.Queries
{
    public class GetInstagramAccessToken : IQuery<string>
    {
        public string ClientId { get; set; }
        public string ClientSecretId { get; set; }
        public string ReturnUrl { get; set; }
        public string Code { get; set; }
    }
}
