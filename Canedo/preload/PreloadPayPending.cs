using CarlosYulo.backend;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.backend.monolith.shop;
using csCY_Avenue.Canedo.backend.entities;

namespace CarlosYulo.preload;

public class PreloadPayPending
{
    public static List<MembershipPending> MembershipPendingSales { get; set; }
    public static List<Item> ItemPendingSales { get; set; }
    
    private static readonly RevenueController _revenueController = ServiceLocator.GetService<RevenueController>();

    
    public static void PreUnpaidLoad()
    {
        try
        {
            MembershipPendingSales = _revenueController.SearchPartialMembersAll();
            ItemPendingSales = new List<Item>();
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }
    
    
    public static void UpdateMembershipRevenueAdd(MembershipPending client)
    {
        MembershipPendingSales.Add(client);
    }
    
    public static void UpdateItemRevenueAdd(Item itemSales)
    {
        ItemPendingSales.Add(itemSales);
    }
}