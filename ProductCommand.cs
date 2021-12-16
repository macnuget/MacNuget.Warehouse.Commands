namespace MacNuget.Warehouse.Commands;

public abstract class ProductCommand
{
    public int Id { get; set; }
    public int? Quantity { get; set; }
    public string? Name { get; set; }
}