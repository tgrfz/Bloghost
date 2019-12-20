using System;
using System.IO;
using System.Text.Json;
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
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Admin>()
                .HasKey(x => x.Id);
            builder.Entity<Blog>()
                .HasKey(x => x.Id);
            builder.Entity<Blog>()
                .HasAlternateKey(x => x.Address);
            builder.Entity<Comment>()
                .HasKey(x => x.Id);
            builder.Entity<Followers>()
                .HasKey(x => x.Id);
            builder.Entity<Following>()
                .HasKey(x => x.Id);
            builder.Entity<Post>()
                .HasKey(x => x.Id);
            builder.Entity<Post>()
                .HasAlternateKey(x => x.Url);
            builder.Entity<User>()
                .HasKey(x => x.Id);

            builder.Entity<User>()
                .HasOne(x => x.Followers)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.FollowersId);
            builder.Entity<User>()
                .HasOne(x => x.Following)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.FollowingId);

            Admin admin;
            string path = @"D:\adminemail.json";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                admin = await JsonSerializer.DeserializeAsync<Admin>(fs);
            }
            Admins.Add(admin);
        }
    }
}
