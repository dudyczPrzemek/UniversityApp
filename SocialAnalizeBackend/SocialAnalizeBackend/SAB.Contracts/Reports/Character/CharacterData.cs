using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.Character
{
    public class CharacterData : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public int PositiveOpinions { get; set; }
        public int NegativeOpinions { get; set; }
    }
}
