namespace CarlosYulo.backend.entities;

public class ItemSales
{
    public int? ItemSalesId { get; set; }
    public string? ItemName { get; set; }
    public string? ItemCategory { get; set; }
    public double? ItemTotalSales { get; set; }
    public int? ItemQuantitiesSold { get; set; }
    public double? ItemPriceSold { get; set; }
    public DateTime? ItemSaleDate { get; set; }
    public Boolean? IsRecorded { get; set; }
    
    public override string ToString()
    {
        return $"ItemSalesId: {ItemSalesId}, " +
               $"ItemName: {ItemName ?? "N/A"}, " +
               $"ItemCategory: {ItemCategory ?? "N/A"}, " +
               $"ItemTotalSales: {ItemTotalSales?.ToString("C") ?? "N/A"}, " +
               $"ItemQuantitiesSold: {ItemQuantitiesSold ?? 0}, " +
               $"ItemPriceSold: {ItemPriceSold?.ToString("C") ?? "N/A"}, " +
               $"ItemSaleDate: {ItemSaleDate?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A"}, " +
               $"IsRecorded: {IsRecorded?.ToString() ?? "N/A"}";
    }
}