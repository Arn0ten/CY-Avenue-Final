using CarlosYulo.backend.monolith.item;
using CarlosYulo.backend.monolith.shop;

namespace CarlosYulo.preload;

public class PreloadItemData
{
    public static List<Item> Items { get; set; }

    private static readonly ItemController _itemController = ServiceLocator.GetService<ItemController>();


    public static void PreloadItems()
    {
        try
        {
            Items = _itemController.SearchAll();
            Console.WriteLine("Preload items completed successfully.");

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during data preload: {e.Message}");
            throw;
        }
        
    }
    
    public static void UpdateItemsAdd(Item client)
    {
        Items.Add(client);
    }
    
}