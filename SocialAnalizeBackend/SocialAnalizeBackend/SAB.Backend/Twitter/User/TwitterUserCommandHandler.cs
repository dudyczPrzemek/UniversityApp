using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.Repositories;
using Newtonsoft.Json;
using SA.Contracts.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace SA.Backend.Twitter.User
{
    public class TwitterUserCommandHandler : IAsyncCommandHandler<RefreshTwitterUserData>
    {
        private readonly IRepository<SearchedTwitterUserData> repository;

        public TwitterUserCommandHandler(IRepository<SearchedTwitterUserData> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(RefreshTwitterUserData data)
        {
            await repository.AddAsync(new SearchedTwitterUserData()
            {
                UserId = 1,
                Data = GetSearchedUserData(data)
            });
            await repository.SaveChangesAsync();
        }

        private string GetSearchedUserData(RefreshTwitterUserData data)
        {
            var ConsumerKey = "WdraGJz5UUR2l8Y35g9zBrwOw";
            var ConsumerSecret = "oxurh7hr5HxkCUChNwnshmCjNjOhdhE5r307AOEhZtxYKbPbyd";
            Auth.SetUserCredentials(ConsumerKey,
                ConsumerSecret, data.AccessToken,
                data.AccessTokenSecret);
            var users = Search.SearchUsers("oskar_at_net");
            return JsonConvert.SerializeObject(users.First());
        }
    }
}
