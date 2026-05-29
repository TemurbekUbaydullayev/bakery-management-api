namespace BakeryApi.Entities;

public class PriceHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }
    public DateTime EffectiveDate { get; set; } = DateTime.UtcNow;

    public Product Product { get; set; } = null!;
}