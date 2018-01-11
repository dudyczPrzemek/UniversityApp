using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.Localization
{
    public class Localization : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public FollowedUser FollowedUser { get; set; }
    }
}
