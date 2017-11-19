using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Facebook.User.Queries
{
    public class GetFacebookUser : IQuery<FacebookUser>
    {
        public int Id { get; set; }
    }
}
