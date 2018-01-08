using SA.Contracts.Twitter;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories.Interfaces
{
    public interface ITwitterRepository
    {
        Task<SearchUserModel> SearchForUser(string searchedUserName);
        Task<user_tweets> GetTwitterData(string userTwitterId);
    }
}
