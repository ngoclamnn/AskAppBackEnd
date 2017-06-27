namespace DiscountCrazyAdmin.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DiscountCrazyAdmin.Data.Entities;

    public partial class AskAppBackEndContext : DbContext
    {
        public AskAppBackEndContext()
            : base("name=DiscountCrazyAdminContext")
        {
        }

        public virtual DbSet<BusinessCategory> BusinessCategories { get; set; }
        public virtual DbSet<Code> Codes { get; set; }
        public virtual DbSet<CodeUsedHistory> CodeUsedHistories { get; set; }
        public virtual DbSet<DiscountType> DiscountTypes { get; set; }
        public virtual DbSet<PromotionCode> PromotionCodes { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<StoreCode> StoreCodes { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessCategory>()
                .Property(e => e.category_code)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessCategory>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessCategory>()
                .Property(e => e.modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessCategory>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.BusinessCategory)
                .HasForeignKey(e => e.business_category_id);

            modelBuilder.Entity<Code>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Code>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<Code>()
                .Property(e => e.modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<Code>()
                .HasMany(e => e.CodeUsedHistories)
                .WithRequired(e => e.Code)
                .HasForeignKey(e => e.code_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Code>()
                .HasMany(e => e.PromotionCodes)
                .WithRequired(e => e.Code)
                .HasForeignKey(e => e.code_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiscountType>()
                .HasMany(e => e.Codes)
                .WithRequired(e => e.DiscountType)
                .HasForeignKey(e => e.discount_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.CodeUsedHistories)
                .WithRequired(e => e.Promotion)
                .HasForeignKey(e => e.promotion_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.PromotionCodes)
                .WithRequired(e => e.Promotion)
                .HasForeignKey(e => e.promotion_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.postcode)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.security_key)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Promotions)
                .WithRequired(e => e.Store)
                .HasForeignKey(e => e.store_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
