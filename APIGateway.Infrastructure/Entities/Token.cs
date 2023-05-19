namespace APIGateway.Infrastructure.Entities;

public partial class Token
{
    public int TokenId { get; set; }

    public int UserId { get; set; }

    public string TokenValue { get; set; } = null!;

    public DateTime ExpirationDate { get; set; }

    public virtual User User { get; set; } = null!;
}
