using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Reports.PersonalData
{
    public class PersonalData : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
