namespace HW8.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HW8.Models;

    public partial class AuctionContext : DbContext
    {
        public AuctionContext()
            : base("name=AuctionContext")
        {
        }

        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Item>()
                .HasForeignKey(e => e.SellerID);
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bid>()
                .HasMany(e => e.Bids)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);*/
        }
    }
}