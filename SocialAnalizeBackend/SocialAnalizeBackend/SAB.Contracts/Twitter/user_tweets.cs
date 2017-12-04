using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SA.Contracts.Twitter
{
    public class user_tweets : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "jsonb")]
        public string Data { get; set; }
        object IHasId.Id => Id;
    }
}
