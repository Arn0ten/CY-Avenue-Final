namespace csCY_Avenue.Canedo.backend.entities;

public class ItemInvoice
{
    public int Id { get;  set; }
    public double Merchandise { get;  set; }
    public double Equipment { get;  set; }
    public double Supplement { get;  set; }
    public double Discount { get;  set; }
    public double TotalPrice { get;  set; }
    public DateTime RecordedAt { get;  set; }


    // Override ToString method
    public override string ToString()
    {
        return $"Invoice ID: {Id}\n" +
               $"Merchandise: {Merchandise:C}\n" +
               $"Equipment: {Equipment:C}\n" +
               $"Supplement: {Supplement:C}\n" +
               $"Discount: {Discount:C}\n" +
               $"Total Price: {TotalPrice:C}\n" +
               $"Recorded At: {RecordedAt}\n";
    }
}