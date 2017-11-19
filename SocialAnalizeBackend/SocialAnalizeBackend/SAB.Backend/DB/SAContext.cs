using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SA.Contracts.Facebook;
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
    }
}
