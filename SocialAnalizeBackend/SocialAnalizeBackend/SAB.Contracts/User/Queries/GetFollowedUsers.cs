using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User.Queries
{
    public class GetFollowedUsers : IQuery<IList<FollowedUser>>
    {
    }
}
