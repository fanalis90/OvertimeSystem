using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class OvertimeSystemDbContext : DbContext
    {
        public OvertimeSystemDbContext(DbContextOptions<OvertimeSystemDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<OvertimeRequest> OvertimeRequests { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                .HasMany(a => a.AccountRoles)
                .WithOne(ar => ar.Account)
                .HasForeignKey(ar => ar.AccountId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.AccountRoles)
                .WithOne(ar => ar.Role)
                .HasForeignKey(ar => ar.RoleId);

            modelBuilder.Entity<Account>()
                .HasMany(a => a.OvertimeRequests)
                .WithOne(or => or.Account)
                .HasForeignKey(or => or.AccountId);

            modelBuilder.Entity<Overtime>()
                .HasMany(o => o.OvertimeRequests)
                .WithOne(or => or.Overtime)
                .HasForeignKey(or => or.OvertimeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees)
                .WithOne(e => e.Manager)
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Account)
                .WithOne(a => a.Employee)
                .HasForeignKey<Account>(a => a.Id);

        }
    }
}
