﻿using GoldenEye.Backend.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using GoldenEye.Shared.Core.Objects.General;

namespace SA.Contracts.Facebook
{
    public class FacebookUser : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        object IHasId.Id => Id;
    }
}