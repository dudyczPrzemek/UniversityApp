using GoldenEye.Backend.Core.DDD.Queries;
using SA.Contracts.Base;
using SA.Contracts.Facebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User.Queries
{
    public class GetSearchedUser : IQuery<SearchUserModel>
    {
        public AccessTokensModel AccessTokens { get; set; }
        public string UserId { get; set; }
    }
}
