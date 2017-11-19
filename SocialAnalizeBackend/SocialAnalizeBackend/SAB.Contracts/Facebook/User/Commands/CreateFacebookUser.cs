using GoldenEye.Backend.Core.DDD.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Facebook.User.Commands
{
    public class CreateFacebookUser : ICommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
