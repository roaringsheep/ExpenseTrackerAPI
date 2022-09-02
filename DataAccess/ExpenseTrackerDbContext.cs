using Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ExpenseTrackerDbContext : DbContext
{
    public ExpenseTrackerDbContext() : base() {}

    public ExpenseTrackerDbContext(DbContextOptions options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Category> Categories { get; set; }
}