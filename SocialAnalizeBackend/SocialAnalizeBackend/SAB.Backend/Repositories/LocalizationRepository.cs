using SA.Backend.DB;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Reports.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SA.Backend.Repositories
{
    public class LocalizationRepository : ILocalizationRepository
    {
        private SAContext Context;

        public LocalizationRepository(SAContext context)
        {
            this.Context = context;
        }

        public IList<Localization> GetUserLocalization(int userId)
        {
            return Context.Localization.Include("FollowedUser").Where(x => x.FollowedUser.Id == userId).ToList();
        }
    }
}
