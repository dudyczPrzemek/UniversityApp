using SA.Contracts.Instagram.User;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories.Interfaces
{
    public interface IInstagramRepository
    {
        Task<SearchUserModel> SearchForUser(string searchedUserName, string accessToken);
        Task<instagram_media_recent> GetInstagramData(string userInstagramId, string accessToken);
    }
}
