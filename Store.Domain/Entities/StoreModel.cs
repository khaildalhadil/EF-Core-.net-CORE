using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities;

public class StoreModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public bool HasDevlivery { get; set; }

    public string? ContactEmail { get; set; }
    public string? ContactNumber { get; set; }

    public Address? Address { get; set; }
    public List<Item> Items { get; set; } = new();

}
