using Microsoft.EntityFrameworkCore;

namespace FlashcardsAPI.Models;

public class UserAccountContext : DbContext
{
  public UserAccountContext(DbContextOptions<UserAccountContext> options)
    : base(options)
  {
  }

  public DbSet<UserAccount> UserAccounts { get; set; } = null!;
}