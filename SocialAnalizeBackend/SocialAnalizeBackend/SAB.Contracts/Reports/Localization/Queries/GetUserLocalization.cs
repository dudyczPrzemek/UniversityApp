using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.Localization.Queries
{
    public class GetUserLocalization : IQuery<IList<Localization>>
    {
        public int UserId { get; set; }
    }
}
