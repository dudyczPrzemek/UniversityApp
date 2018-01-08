using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SA.Contracts.Instagram.User
{
    public class instagram_media_recent : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "jsonb")]
        public string Data { get; set; }
        public FollowedUser FollowedUser { get; set; }

        object IHasId.Id => Id;
    }
}
