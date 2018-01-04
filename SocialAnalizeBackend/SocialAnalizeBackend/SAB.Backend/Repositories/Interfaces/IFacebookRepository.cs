using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories.Interfaces
{
    public interface IFacebookRepository
    {
        Task<SearchUserModel> SearchForUser(string searchedUserName, string accessToken);
    }
}
