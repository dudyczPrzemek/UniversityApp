using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User
{
    public class SearchUserModel
    {
        public IList<SearchUserUnitModel> SearchedUsers { get; set; }
        public string Paging { get; set; }
    }
}
