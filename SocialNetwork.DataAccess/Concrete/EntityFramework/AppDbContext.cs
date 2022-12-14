using Microsoft.EntityFrameworkCore;
using SocialNetwork.Core.Entities.Concrete;
using SocialNetwork.Entities.Concrete;

namespace SocialNetwork.DataAccess.Concrete.EntityFramwork
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-8BCT0DK;initial catalog=SocialNetwork;Trusted_connection=true;MultipleActiveResultSets=true; TrustServerCertificate=True;");
        }
        public DbSet<User> Users { get; set;}
        public DbSet<Role> Roles { get; set;}
        public DbSet<UserRole> UserRoles { get; set;}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<DisLike> DisLikes { get; set; }
        
    }
}