using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User
{
    public class User : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
