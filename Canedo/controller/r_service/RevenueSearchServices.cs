using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.revenue.i_search;

namespace CarlosYulo.backend.monolith.revenue;

public class RevenueSearchServices
{
    private readonly RevenueSearchFinalByMonth _searchFinalByMonth;
    private readonly ErrorMessageBox _messageBox;

    public RevenueSearchServices(RevenueSearchFinalByMonth searchFinalByMonth)
    {
        _searchFinalByMonth = searchFinalByMonth;
        _messageBox = new ErrorMessageBox();
    }

    public FinalRevenueReport? SearchRevenueByMonthPreload(DateTime month)
    {
        string message;    
        return _searchFinalByMonth.SearchRevenueByMonth(month, out message);
    }


    public FinalRevenueReport? SearchRevenueByMonth(DateTime month)
    {
        string message;
        var result = _searchFinalByMonth.SearchRevenueByMonth(month, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return null;
        }
        return result;
    }
}