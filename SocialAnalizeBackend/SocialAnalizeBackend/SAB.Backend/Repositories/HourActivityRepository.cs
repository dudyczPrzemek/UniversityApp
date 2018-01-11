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
    public class HourActivityRepository : IHourActivityRepository
    {
        private SAContext Context;

        public HourActivityRepository(SAContext context)
        {
            Context = context;
        }

        public IList<HourActivityDetails> GetByUserId(int userId)
        {
            return Context.HourActivityData.Include("FollowedUser").Where(x => x.FollowedUser.Id == userId).ToList();
        }
    }
}
