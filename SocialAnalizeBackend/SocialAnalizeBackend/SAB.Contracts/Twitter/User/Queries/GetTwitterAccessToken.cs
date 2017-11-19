using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Twitter.User.Queries
{
    public class GetTwitterAccessToken : IQuery<string>
    {
        public string AuthorizationId { get; set; }
        public string OauthToken { get; set; }
        public string OauthVerifier { get; set; }
    }
}
