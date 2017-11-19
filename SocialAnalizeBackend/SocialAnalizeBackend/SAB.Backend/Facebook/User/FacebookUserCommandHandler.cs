using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.Repositories;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Facebook.User
{
    public class FacebookUserCommandHandler : IAsyncCommandHandler<CreateFacebookUser>
    {
        private readonly IRepository<FacebookUser> repository;

        public FacebookUserCommandHandler(IRepository<FacebookUser> repository)
        {
            this.repository = repository;
        }

        public async Task Handle(CreateFacebookUser command)
        {
            var newUser = new FacebookUser()
            {
                Id = command.Id,
                FirstName = command.FirstName,
                LastName = command.LastName
            };
            await repository.AddAsync(newUser);
            await repository.SaveChangesAsync();
        }
    }
}
