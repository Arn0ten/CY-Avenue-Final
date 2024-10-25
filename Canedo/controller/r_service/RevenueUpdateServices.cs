using CarlosYulo.backend.monolith.revenue.i_update;

namespace CarlosYulo.backend.monolith.revenue;

public class RevenueUpdateServices
{
    private readonly RevenueUpdateMembershipRecordToTrue _update;

    public RevenueUpdateServices(RevenueUpdateMembershipRecordToTrue update)
    {
        _update = update;
    }

    public bool UpdateMembershipRecordToTrue(int membershipId)
    {
        return _update.UpdateMembershipRecordToTrue(membershipId);
    }
    
}