namespace csCY_Avenue.Canedo.backend.entities;

public class MembershipPending
{
    public int? Id { get; set; }
    public int membership_id {get; set;} 
    public string member_name { get; set; }
    public string membership_type { get; set; }
    public double price { get; set; }
    public DateTime create_at { get; set; }
    public bool status { get; set; }
}