using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatLeilao.API.Entities;

[Table("Items")] // referenciando a classe Item para a tabela Items no SQLite
public class Item
{
    public int Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int Condition { get; set; }
    public decimal BasePrice { get; set; }
    public int AuctionId { get; set; }
}
