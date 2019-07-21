namespace App.Data.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using App.Entities.Base;

    public partial class DbPesce : DbContext
    {
        public DbPesce()
            : base("name=DbPesce")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DeliverySubject> DeliverySubject { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentLine> DocumentLine { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ReferenceDocument> ReferenceDocument { get; set; }
        public virtual DbSet<ReferenceDocumentType> ReferenceDocumentType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Street)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.Country)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.Reference)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .Property(e => e.Symbol)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Document)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Company)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Identification)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.RUC)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Document)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Price)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ReferenceDocument)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ReferenceDocument1)
                .WithRequired(e => e.Customer1)
                .HasForeignKey(e => e.CustomerId2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliverySubject>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<DeliverySubject>()
                .HasMany(e => e.ReferenceDocument)
                .WithRequired(e => e.DeliverySubject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.BillingAddress)
                .IsFixedLength();

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Document1)
                .WithOptional(e => e.Document2)
                .HasForeignKey(e => e.DocumentId2);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.DocumentLine)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentLine>()
                .Property(e => e.IGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<DocumentType>()
                .HasMany(e => e.Document)
                .WithRequired(e => e.DocumentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Price>()
                .HasMany(e => e.DocumentLine)
                .WithRequired(e => e.Price)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Format)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DocumentLine)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Price)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReferenceDocument>()
                .Property(e => e.DeliveryAddress)
                .IsFixedLength();

            modelBuilder.Entity<ReferenceDocument>()
                .Property(e => e.OriginAddress)
                .IsFixedLength();

            modelBuilder.Entity<ReferenceDocumentType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ReferenceDocumentType>()
                .HasMany(e => e.ReferenceDocument)
                .WithRequired(e => e.ReferenceDocumentType)
                .WillCascadeOnDelete(false);
        }
    }
}
