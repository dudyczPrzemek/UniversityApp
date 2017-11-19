using GoldenEye.Shared.Core.Modules;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using GoldenEye.Backend.Core.DDD.Registration;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Queries;
using SA.Backend.Facebook.User;

namespace SA.Backend
{
    public class Module : ModuleBase
    {
        public Module(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Configure(IServiceCollection services)
        {
            RegisterHandlers(services);
            base.Configure(services);
        }

        private void RegisterHandlers(IServiceCollection services)
        {
            services.RegisterAsyncQueryHandler<GetFacebookUser, FacebookUser, FacebookUserQueryHandler>();
        }
    }
}
