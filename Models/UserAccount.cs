namespace FlashcardsAPI.Models;

public class UserAccount
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public string? Username { get; set; }
  public string? Email { get; set; }
  public string? Password { get; set; }
}