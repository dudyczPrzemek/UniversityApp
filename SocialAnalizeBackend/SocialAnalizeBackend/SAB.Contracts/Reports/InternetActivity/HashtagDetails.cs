using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.InternetActivity
{
    public class HashtagDetails : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public string Name { get; set; }
        public int Count { get; set; }
        public FollowedUser FollowedUser { get; set; }
    }
}
