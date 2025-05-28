using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FinanceApp.Data;

namespace FinanceApp
{
  public class FinanceAppContextFactory : IDesignTimeDbContextFactory<FinanceAppContext>
  {
    public FinanceAppContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<FinanceAppContext>();
      optionsBuilder.UseSqlite("Data Source=finance.db");

      return new FinanceAppContext(optionsBuilder.Options);
    }
  }
}
