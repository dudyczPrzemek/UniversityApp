using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.InternetActivity
{
    public class InternetActivityData : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public HashtagDetails HashtagDetails { get; set; }
        public HourActivityDetails HourActivityDetails { get; set; }
    }
}
