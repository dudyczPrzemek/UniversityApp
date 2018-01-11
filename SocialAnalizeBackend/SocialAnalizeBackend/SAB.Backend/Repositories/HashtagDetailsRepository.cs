using SA.Backend.DB;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Reports.InternetActivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SA.Backend.Repositories
{
    public class HashtagDetailsRepository : IHashtagDetailsRepository
    {
        private SAContext Context;

        public HashtagDetailsRepository(SAContext context)
        {
            Context = context;
        }

        public IList<HashtagDetails> GetByUserId(int userId)
        {
            return Context.HashtagDetails.Include("FollowedUser").Where(x => x.FollowedUser.Id == userId).ToList();
        }
    }
}
