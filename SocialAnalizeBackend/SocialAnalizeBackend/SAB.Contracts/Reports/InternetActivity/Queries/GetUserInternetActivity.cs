using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.InternetActivity.Queries
{
    public class GetUserInternetActivity : IQuery<InternetActivityData>
    {
        public int UserId { get; set; }
    }
}
