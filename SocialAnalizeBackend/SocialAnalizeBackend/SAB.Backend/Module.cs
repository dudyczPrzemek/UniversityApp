using GoldenEye.Shared.Core.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GoldenEye.Backend.Core.DDD.Registration;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Queries;
using SA.Backend.Facebook.User;
using SA.Backend.DB;
using GoldenEye.Backend.Core.Registration;
using GoldenEye.Backend.Core.EntityFramework.Registration;
using Microsoft.EntityFrameworkCore;
using System;
using SA.Contracts.Facebook.User.Commands;
using SA.Contracts.Twitter.User.Queries;
using SA.Backend.Twitter.User;
using SA.Contracts.Instagram.User.Queries;
using SA.Backend.Instagram.User;
using SA.Contracts.Instagram.User;
using SA.Contracts.Instagram.User.Commands;
using SA.Contracts.Twitter;
using SA.Contracts.User.Queries;
using SA.Contracts.User;
using SA.Backend.User;
using System.Collections.Generic;
using SA.Contracts.User.Commands;
using SA.Backend.Repositories.Interfaces;
using SA.Backend.Repositories;
using SA.Contracts.Facebook.User;
using SA.Contracts.Reports.Localization.Queries;
using SA.Contracts.Reports.Localization;
using SA.Backend.Reports.Localization;
using SA.Contracts.Reports.InternetActivity.Queries;
using SA.Contracts.Reports.InternetActivity;
using SA.Backend.Reports.InternetActivity;

namespace SA.Backend
{
    public class Module : ModuleBase
    {
        public Module(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Configure(IServiceCollection services)
        {
            var connectionString = "PORT = 5433; HOST = 127.0.0.1; TIMEOUT = 15; POOLING = True; MINPOOLSIZE = 1; MAXPOOLSIZE = 100; COMMANDTIMEOUT = 20; DATABASE = 'postgres'; PASSWORD = 'Przemek1*'; USER ID = 'postgres'";

            services.AddEFDataContext<SAContext>((sp, options) => options.UseNpgsql(connectionString));

            RegisterHandlers(services);
            RegisterRepositories(services);
            base.Configure(services);
        }

        private void RegisterHandlers(IServiceCollection services)
        {
            //FACEBOOK
            services.RegisterAsyncQueryHandler<GetFacebookUser, FacebookUser, FacebookUserQueryHandler>();
            services.RegisterAsyncQueryHandler<GetFacebookAccessToken, string, FacebookUserQueryHandler>();
            services.RegisterAsyncQueryHandler<RefreshIntagramUserData, bool, FacebookUserQueryHandler>();
            services.RegisterAsyncCommandHandler<CreateFacebookUser, FacebookUserCommandHandler>();

            //TWITTER
            services.RegisterAsyncQueryHandler<GetTwitterAccessToken, string, TwitterUserQueryHandler>();
            services.RegisterAsyncQueryHandler<RefreshTwitterDataUser, bool, TwitterUserQueryHandler>();
            services.RegisterAsyncCommandHandler<RefreshTwitterUserData, TwitterUserCommandHandler>();

            //INSTAGRAM
            services.RegisterAsyncQueryHandler<GetInstagramAccessToken, string, InstagramUserQueryHandler>();
            services.RegisterAsyncQueryHandler<RefreshInstagramUserData, bool, InstagramUserQueryHandler>();
            services.RegisterAsyncCommandHandler<RefreshInstagramRecentMedia, InstagramUserCommandHandler>();

            services.RegisterAsyncQueryHandler<GetSearchedUser, SearchUserModel, UserQueryHandler>();
            services.RegisterAsyncQueryHandler<GetFollowedUsers, IList<FollowedUser>, UserQueryHandler>();
            services.RegisterAsyncCommandHandler<AddUser, UserCommandHandler>();
            services.RegisterAsyncCommandHandler<UpdateFollowedUser, UserCommandHandler>();

            //LOCALIZATION
            services.RegisterAsyncQueryHandler<GetUserLocalization, IList<Localization>, LocalizationQueryHandler>();

            //INTERNETACTIVITY
            services.RegisterAsyncQueryHandler<GetUserInternetActivity, InternetActivityData, InternetActivityQueryHandler>();
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            //FACEBOOK
            services.AddEFCRUDRepository<SAContext, FacebookUser>();

            //TWITTER
            services.AddEFCRUDRepository<SAContext, SearchedTwitterUserData>();
            //INSTAGRAM
            services.AddEFCRUDRepository<SAContext, instagram_media_recent>();
            services.AddEFCRUDRepository<SAContext, user_tweets>();
            services.AddEFCRUDRepository<SAContext, facebook_user>();
            services.AddEFCRUDRepository<SAContext, FollowedUser>();

            services.AddScoped<IFollowedUserRepository, FollowedUserRepository>();
            services.AddScoped<ILocalizationRepository, LocalizationRepository>();
            services.AddScoped<IHourActivityRepository, HourActivityRepository>();
            services.AddScoped<IHashtagDetailsRepository, HashtagDetailsRepository>();

            services.AddSingleton<IFacebookRepository, FacebookRepository>();
            services.AddSingleton<IInstagramRepository, InstagramRepository>();
            services.AddSingleton<ITwitterRepository, TwitterRepository>();
        } 
    }
}
