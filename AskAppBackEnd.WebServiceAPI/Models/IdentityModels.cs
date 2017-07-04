using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.ComponentModel.DataAnnotations;

namespace AskAppBackEnd.WebServiceAPI.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
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

    //public class ApplicationUserRole : IdentityUserRole { }
    //public class ApplicationRole : IdentityRole { }
    //public class ApplicationUserClaim : IdentityUserClaim { }
    //public class ApplicationUserLogin : IdentityUserLogin { }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AskApp", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ApplicationUser>().ToTable("Users", "dbo");
        }
    }
}