using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.revenue.i_search;

namespace CarlosYulo.backend.monolith.revenue;

public class RevenueSearchServices
{
    private readonly RevenueSearchFinalByMonth _searchFinalByMonth;
    private readonly RevenueSearchMemberSalesByMonth _searchMemberSalesByMonth;
    private readonly RevenueItemSearchAll _searchItemAll;
    private readonly ErrorMessageBox _messageBox;

    public RevenueSearchServices(RevenueSearchFinalByMonth searchFinalByMonth,
        RevenueSearchMemberSalesByMonth searchMemberSalesByMonth, RevenueItemSearchAll searchItemAll)
    {
        _searchFinalByMonth = searchFinalByMonth;
        _searchMemberSalesByMonth = searchMemberSalesByMonth;
        _searchItemAll = searchItemAll;
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

    public List<MembershipSale>? SearchMemberRevenueAll()
    {
        string message;
        var result = _searchMemberSalesByMonth.SearchMemberRevenueAll(out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }


    public List<MembershipSale>? SearchMemberRevenueByMonth(DateTime month)
    {
        string message;
        var result = _searchMemberSalesByMonth.SearchMemberRevenueByMonth(month, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }

    public List<MembershipSale>? SearchMemberRevenueBetweenDays(DateTime start, DateTime end)
    {
        string message;
        var result = _searchMemberSalesByMonth.SearchMemberRevenueBetweenDays(start, end, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }


    // ITEM ITEM ITEM ITEM ITEM
    public List<ItemSales> SearchItemSalesBetweenDays(DateTime start, DateTime end)
    {
        string message;
        var result = _searchItemAll.SearchItemSalesBetweenDays(start, end, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }
    
    public List<ItemSales> SearchItemSalesByDays(DateTime day)
    {
        string message;
        var result = _searchItemAll.SearchItemSalesByDays(day, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }
    
    public List<ItemSales> SearchItemSalesByMonth(DateTime month)
    {
        string message;
        var result = _searchItemAll.SearchItemSalesByMonth(month, out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }
    
    
    public List<ItemSales> SearchItemSalesAll()
    {
        string message;
        var result = _searchItemAll.SearchItemSalesAll(out message);
        if (result is null)
        {
            _messageBox.ShowErrorMessage(message);
            return result;
        }

        return result;
    }
}