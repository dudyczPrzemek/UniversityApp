using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SA.Contracts.Facebook;
using SA.Contracts.Instagram.User;
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
    }
}
