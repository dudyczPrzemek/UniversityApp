using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.InternetActivity
{
    public class HourActivityDetails : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public int Mentions { get; set; }
        public int Hour { get; set; }
        public string Source { get; set; }
        public FollowedUser FollowedUser { get; set; }
    }
}
