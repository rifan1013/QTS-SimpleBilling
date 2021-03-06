using Microsoft.EntityFrameworkCore;
namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB; Initial Catalog=QTS-SimpleBilling;Integrated Security=True");
         }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReceiptBody> ReceiptBodies { get; set; }
        public DbSet<ReceiptHeader> ReceiptHeaders { get; set; }
    }
}
