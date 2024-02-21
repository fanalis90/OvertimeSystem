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


    }
}
