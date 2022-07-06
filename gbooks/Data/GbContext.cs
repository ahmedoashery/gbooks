namespace gbooks.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GbContext : DbContext
    {
        public GbContext()
            : base("name=GbContext")
        {
        }

        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<bill_lines> bill_lines { get; set; }
        public virtual DbSet<bill_payments> bill_payments { get; set; }
        public virtual DbSet<Bill> bills { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<invoice_lines> invoice_lines { get; set; }
        public virtual DbSet<invoice_payments> invoice_payments { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<split> splits { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.accounts1)
                .WithOptional(e => e.account1)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.bill_lines)
                .WithOptional(e => e.account)
                .HasForeignKey(e => e.account_id);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.bills)
                .WithRequired(e => e.account)
                .HasForeignKey(e => e.ap_account_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.invoices)
                .WithRequired(e => e.account)
                .HasForeignKey(e => e.ar_account_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.invoice_lines)
                .WithOptional(e => e.account)
                .HasForeignKey(e => e.account_id);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.splits)
                .WithOptional(e => e.account)
                .HasForeignKey(e => e.account_id);

            modelBuilder.Entity<bill_lines>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<bill_payments>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<bill_payments>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.bill_lines)
                .WithRequired(e => e.bill)
                .HasForeignKey(e => e.bill_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.bill_payments)
                .WithRequired(e => e.bill)
                .HasForeignKey(e => e.bill_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.invoices)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.customer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<invoice_payments>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<invoice_payments>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .HasMany(e => e.invoice_lines)
                .WithRequired(e => e.invoice)
                .HasForeignKey(e => e.invoice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<invoice>()
                .HasMany(e => e.invoice_payments)
                .WithRequired(e => e.invoice)
                .HasForeignKey(e => e.invoice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .HasMany(e => e.bill_lines)
                .WithRequired(e => e.item)
                .HasForeignKey(e => e.item_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item>()
                .HasMany(e => e.invoice_lines)
                .WithRequired(e => e.item)
                .HasForeignKey(e => e.item_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.job)
                .HasForeignKey(e => e.job_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<split>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<transaction>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<transaction>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<transaction>()
                .HasMany(e => e.splits)
                .WithOptional(e => e.transaction)
                .HasForeignKey(e => e.transaction_id);

            modelBuilder.Entity<type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .HasMany(e => e.accounts)
                .WithOptional(e => e.type)
                .HasForeignKey(e => e.type_id);

            modelBuilder.Entity<type>()
                .HasMany(e => e.customers)
                .WithRequired(e => e.type)
                .HasForeignKey(e => e.type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<type>()
                .HasMany(e => e.items)
                .WithOptional(e => e.type)
                .HasForeignKey(e => e.type_id);

            modelBuilder.Entity<type>()
                .HasMany(e => e.vendors)
                .WithOptional(e => e.type)
                .HasForeignKey(e => e.type_id);

            modelBuilder.Entity<vendor>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .HasMany(e => e.bills)
                .WithRequired(e => e.vendor)
                .HasForeignKey(e => e.vendor_id)
                .WillCascadeOnDelete(false);
        }
    }
}
