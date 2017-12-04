using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SA.Contracts.Facebook;
using SA.Contracts.Instagram.User;
using SA.Contracts.Twitter;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Backend.DB
{
    public partial class SAContext : DbContext
    {
        public SAContext(DbContextOptions<SAContext> options) : base(options)
        { }

        public virtual DbSet<FacebookUser> FacebookUser { get; set; }
        public virtual DbSet<instagram_media_recent> instagram_media_recent { get; set; }

        public virtual DbSet<>
        public virtual DbSet<SearchedTwitterUserData> twitter_searched_user_data  { get; set; }
    }
}
