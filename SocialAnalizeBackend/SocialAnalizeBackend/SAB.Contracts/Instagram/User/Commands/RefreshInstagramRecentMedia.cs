using GoldenEye.Backend.Core.DDD.Commands;
using SA.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Instagram.User.Commands
{
    public class RefreshInstagramRecentMedia : CommandBase, ICommand
    {
        public int UserId { get; set; }
    }
}
