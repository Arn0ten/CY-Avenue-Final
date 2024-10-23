using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.revenue;
using Mysqlx.Crud;

namespace CarlosYulo.preload;

public class PreloadRevenueData
{
    public static List<MembershipSale> MembershipSales { get; set; }
    public static List<ItemSales> ItemSales { get; set; }

    private static readonly RevenueController _revenueController = ServiceLocator.GetService<RevenueController>();
    
    
    
    public static void PreLoad()
    {
        try
        {
            ItemSales = _revenueController.SearchItemSalesAll();
            MembershipSales = _revenueController.SearchMemberRevenueAll();

            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void PreLoadMemberRevenue()
    {
        try
        {
            MembershipSales = _revenueController.SearchMemberRevenueAll();
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }
    
    public static void PreLoadItemRevenue()
    {
        try
        {
            ItemSales = _revenueController.SearchItemSalesAll();
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }
    
    

    public static void UpdateMembershipRevenueAdd(MembershipSale client)
    {
        MembershipSales.Add(client);
    }
    
    public static void UpdateItemRevenueAdd(ItemSales itemSales)
    {
        ItemSales.Add(itemSales);
    }
    
}