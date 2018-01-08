using Microsoft.EntityFrameworkCore;
using SA.Contracts.Facebook.User;
using SA.Contracts.Instagram.User;
using SA.Contracts.Reports.Character;
using SA.Contracts.Reports.InternetActivity;
using SA.Contracts.Reports.Localization;
using SA.Contracts.Reports.PersonalData;
using SA.Contracts.Twitter;
using SA.Contracts.User;

namespace SA.Backend.DB
{
    public partial class SAContext : DbContext
    {
        public SAContext(DbContextOptions<SAContext> options) : base(options)
        { }
        
        public virtual DbSet<instagram_media_recent> instagram_media_recent { get; set; }
        public virtual DbSet<facebook_user> facebook_user  { get; set; }
        public virtual DbSet<user_tweets> user_tweets { get; set; }
        public virtual DbSet<Contracts.User.User> User { get; set; }
        public virtual DbSet<PersonalData> PersonalData { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<CharacterData> CharacterData { get; set; }
        public virtual DbSet<HourActivityDetails> HourActivityData { get; set; }
        public virtual DbSet<HashtagDetails> HashtagDetails { get; set; }
        public virtual DbSet<InternetActivityData> InternetActivityData { get; set; }
        public virtual DbSet<FollowedUser> FollowedUser { get; set; }
    }
}
