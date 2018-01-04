using GoldenEye.Backend.Core.DDD.Commands;
using SA.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User.Commands
{
    public class AddUser : CommandBase, ICommand
    {
        public string FacebookId { get; set; }
        public string InstagramId { get; set; }
        public string TwitterId { get; set; }
    }
}
