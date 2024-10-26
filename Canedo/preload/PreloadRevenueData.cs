using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.revenue;
using csCY_Avenue.Canedo.backend.entities;
using Mysqlx.Crud;

namespace CarlosYulo.preload;

public class PreloadRevenueData
{
    public static List<MembershipSale> MembershipSales { get; set; }
    public static List<ItemSales> ItemPendingSales { get; set; }
    public static List<ItemInvoice> ItemInvoices { get; set; }

    private static readonly RevenueController _revenueController = ServiceLocator.GetService<RevenueController>();


    public static void PreLoad()
    {
        try
        {
            ItemPendingSales = _revenueController.SearchItemSalesAll();
            MembershipSales = _revenueController.SearchMemberRevenueAll();
            ItemInvoices = _revenueController.SearchAllItemInvoice();

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
            ItemPendingSales = _revenueController.SearchItemSalesAll();
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void PreLoadItemInvoices()
    {
        try
        {
            ItemInvoices = _revenueController.SearchAllItemInvoice();
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
        ItemPendingSales.Add(itemSales);
    }
    
    public static void UpdateItemInvoiceAdd(ItemInvoice itemInvoice)
    {
        ItemInvoices.Add(itemInvoice);
    }
}