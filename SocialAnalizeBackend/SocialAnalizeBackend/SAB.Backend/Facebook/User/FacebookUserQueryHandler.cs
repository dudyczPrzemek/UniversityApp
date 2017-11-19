using GoldenEye.Backend.Core.DDD.Queries;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Facebook.User
{
    public class FacebookUserQueryHandler : IAsyncQueryHandler<GetFacebookUser, FacebookUser>
    {
        public Task<FacebookUser> Handle(GetFacebookUser userData)
        {
            return Task.FromResult(new FacebookUser {
                Id = 1,
                FirstName = "Przemek",
                LastName = "Dudycz"
            });
        }
    }
}
