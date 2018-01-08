using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.Localization
{
    public class Localization : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
    }
}
