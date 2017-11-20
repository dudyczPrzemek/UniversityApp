using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.Repositories;
using SA.Contracts.Instagram.User;
using SA.Contracts.Instagram.User.Commands;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Instagram.User
{
    public class InstagramUserCommandHandler : IAsyncCommandHandler<RefreshInstagramRecentMedia>
    {
        private readonly IRepository<instagram_media_recent> repository;

        public InstagramUserCommandHandler(IRepository<instagram_media_recent> repository)
        {
            this.repository = repository;
        }

        public async Task Handle(RefreshInstagramRecentMedia data)
        {
            await repository.AddAsync(new instagram_media_recent()
                    {
                        UserId = data.UserId,
                        Data = GetMediaRecent(data.AccessToken).Result
                    });
            await repository.SaveChangesAsync();
        }

        private async Task<string> GetMediaRecent(string accessToken)
        {
            var client = new HttpClient();
            var mediaUri = new Uri(@"https://api.instagram.com/v1/users/self/media/recent/?access_token=" + accessToken);
            var apiResponse = await client.GetAsync(mediaUri);
            return await apiResponse.Content.ReadAsStringAsync();
        }
    }
}
