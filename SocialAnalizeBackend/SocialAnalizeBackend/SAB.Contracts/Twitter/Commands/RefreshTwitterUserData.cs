using GoldenEye.Backend.Core.DDD.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Tweetinvi.Models;

namespace SA.Contracts.Twitter
{
    public class RefreshTwitterUserData : ICommand
    {
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }

        public int UserId { get; set; }
    }
}
