using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AskAppBackEnd.Data.Entities;
using System.Data.Entity;
using System.Collections.Generic;

namespace AskAppBackEnd.WebServiceAPI.Models
{

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser<Guid, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, Guid> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(200)]
        public string Firstname { get; set; }

        [StringLength(200)]
        public string Lastname { get; set; }

        [StringLength(200)]
        public string FacebookAccount { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(200)]
        public string Nationality { get; set; }

        [StringLength(2000)]
        public string Interests { get; set; }

        public bool IsVisible { get; set; }

        public bool IsNotified { get; set; }

        public bool? DisplayUserProfile { get; set; }

        [StringLength(250)]
        public string AboutMe { get; set; }

        public string ProfilePicture { get; set; }

        [StringLength(200)]
        public string DeviceId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }
    }
    public class ApplicationRole : IdentityRole<Guid, ApplicationUserRole>
    {
    }

    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
    }

    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
    }

    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("AskApp")
        {
        }
        //public virtual DbSet<User> AppUsers { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserLogin>().Map(c =>
            {
                c.ToTable("UserLogin");
                c.Properties(p => new
                {
                    p.UserId,
                    p.LoginProvider,
                    p.ProviderKey
                });
            }).HasKey(p => new { p.LoginProvider, p.ProviderKey, p.UserId });

            // Mapping for ApiRole
            modelBuilder.Entity<ApplicationRole>().Map(c =>
            {
                c.ToTable("Role");
                c.Property(p => p.Id).HasColumnName("RoleId");
                c.Properties(p => new
                {
                    p.Name
                });
            }).HasKey(p => p.Id);
            modelBuilder.Entity<ApplicationRole>().HasMany(c => c.Users).WithRequired().HasForeignKey(c => c.RoleId);

            modelBuilder.Entity<ApplicationUser>().Map(c =>
            {
                c.ToTable("Users");
            }).HasKey(c => c.Id);
            modelBuilder.Entity<ApplicationUser>().HasMany(c => c.Logins).WithOptional().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<ApplicationUser>().HasMany(c => c.Claims).WithOptional().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<ApplicationUser>().HasMany(c => c.Roles).WithRequired().HasForeignKey(c => c.UserId);

            modelBuilder.Entity<ApplicationUserRole>().Map(c =>
            {
                c.ToTable("UserRole");
                c.Properties(p => new
                {
                    p.UserId,
                    p.RoleId
                });
            })
            .HasKey(c => new { c.UserId, c.RoleId });

            modelBuilder.Entity<ApplicationUserClaim>().Map(c =>
            {
                c.ToTable("UserClaim");
                c.Property(p => p.Id).HasColumnName("UserClaimId");
                c.Properties(p => new
                {
                    p.UserId,
                    p.ClaimValue,
                    p.ClaimType
                });
            }).HasKey(c => c.Id);

        }

    }
}
