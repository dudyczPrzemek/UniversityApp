using GoldenEye.Backend.Core.DDD.Commands;
using SA.Contracts.User.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.User
{
    public class UserCommandHandler : IAsyncCommandHandler<AddUser> 
    {
        public async Task Handle(AddUser userData)
        {

        }
    }
}
