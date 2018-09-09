using DarkstarCrm.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace DarkstarCrm.Model.EF
{
    public class DarkstarCrmDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Client>().Property(p => p.Email).IsRequired();
            modelBuilder.Entity<Client>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Client>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Client>().HasMany(c => c.Contacts);

            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Account>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Account>().HasMany(c => c.Contacts);

            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Country>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Country>().Property(p => p.Code).IsRequired();

            modelBuilder.Entity<State>().ToTable("State");
            modelBuilder.Entity<State>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<State>().Property(p => p.Code).IsRequired();

            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Contact>().Property(p => p.Email).IsRequired();
            modelBuilder.Entity<Contact>().Property(p => p.IsDefault).IsRequired().HasDefaultValue(false);
            modelBuilder.Entity<Contact>().HasOne(c => c.Client);
            modelBuilder.Entity<Contact>().HasOne(a => a.Account);
            modelBuilder.Entity<Contact>().HasOne(c => c.Country);
            modelBuilder.Entity<Contact>().HasOne(s => s.State);
        }
    }
}