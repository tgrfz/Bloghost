using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bloghost.Domain;

namespace Bloghost.Data
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                .HasKey(x => x.Id);
            builder.Entity<Followers>()
                .HasKey(x => x.Id);
            builder.Entity<Following>()
                .HasKey(x => x.Id);
            builder.Entity<User>()
                .HasOne(x => x.Followers)
                .WithMany(e => e.Users)
                .HasForeignKey(x => x.FollowersId);
            builder.Entity<User>()
                .HasOne(x => x.Following)
                .WithMany(e => e.Users)
                .HasForeignKey(x => x.FollowingId);
            //builder.Entity<User>()
            //    .HasMany(x => x.Comments)
            //    .WithOne(e => e.Author);

        }
    }
}
