using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Social_Network.Core.Domain.Common;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Persistence.Contexts
{
    public class Social_NetworkContext : DbContext
    {
        public Social_NetworkContext(DbContextOptions<Social_NetworkContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Friend> Friends { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "SomeUserApp";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "SomeUserApp";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region "tables"
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Publication>().ToTable("Publications"); 
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Friend>().ToTable("Friends");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            modelBuilder.Entity<Publication>().HasKey(ad => ad.Id);
            modelBuilder.Entity<Comment>().HasKey(ad => ad.Id);
            modelBuilder.Entity<Friend>().HasKey(ad => ad.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<User>()
                .HasMany<Publication>(user => user.Publications)
                .WithOne(ad => ad.User)
                .HasForeignKey(ad => ad.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<User>()
                .HasMany<Friend>(user => user.Friends)
                .WithOne(ad => ad.User)
                .HasForeignKey(ad => ad.IdFriend)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany<Comment>(user => user.Comments)
                .WithOne(ad => ad.User)
                .HasForeignKey(ad => ad.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Publication>()
                .HasMany<Comment>(user => user.Comments)
                .WithOne(ad => ad.Post)
                .HasForeignKey(ad => ad.PostId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property Configuration"

            #region "User"

            modelBuilder.Entity<User>()
                .Property(user => user.FirstName)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.LastName)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.UserName)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.Password)
                .IsRequired();

            #endregion

            #region "Publications"

            modelBuilder.Entity<Publication>()
                .Property(ad => ad.PublicationContent)
                .IsRequired();

            #endregion

            #region "Comments"

            modelBuilder.Entity<Comment>()
                .Property(ad => ad.CommentText)
                .IsRequired();

            #endregion
            
            #region "Friends"

            modelBuilder.Entity<Friend>()
                .Property(ad => ad.IdFriend)
                .IsRequired();
            modelBuilder.Entity<Friend>()
                .Property(ad => ad.UserId)
                .IsRequired();

            #endregion

            #endregion
        }

    }
}
