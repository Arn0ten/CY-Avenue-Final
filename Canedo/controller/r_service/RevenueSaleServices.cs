using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.backend.monolith.shop.i_revenue;
using csCY_Avenue.Canedo.backend.entities;

namespace CarlosYulo.backend.monolith.revenue;

public class RevenueSaleServices
{
    private readonly RevenueGenerateFinalReport _finalReport;
    private readonly RevenueGeneratePartialReport _partialReport;
    private readonly RevenueGenerateItemSaleReport _itemSaleReport;
    private readonly RevenueGenerateMembershipSalesReport _membershipSalesReport;
    private readonly RevenueGeneratePendingMembership _pendingMembershipReport;
    private readonly RevenueGenerateItemInvoice _itemInvoice;
    private readonly ErrorMessageBox _messageBox;

    public RevenueSaleServices(
        RevenueGenerateFinalReport finalReport,
        RevenueGeneratePartialReport partialReport,
        RevenueGenerateItemSaleReport itemSaleReport,
        RevenueGenerateMembershipSalesReport membershipSalesReport,
        RevenueGeneratePendingMembership pendingMembershipReport,
        RevenueGenerateItemInvoice itemInvoice)
    {
        _finalReport = finalReport;
        _partialReport = partialReport;
        _itemSaleReport = itemSaleReport;
        _membershipSalesReport = membershipSalesReport;
        _pendingMembershipReport = pendingMembershipReport;
        _itemInvoice = itemInvoice;
        _messageBox = new ErrorMessageBox();
    }

    public FinalRevenueReport? GenerateFinalRevenueReport(DateTime month)
    {
        string message;
        var finalRevenueReport = _finalReport.GenerateFinalRevenueReport(month, out message);
        if (finalRevenueReport is null)
        {
            _messageBox.ShowErrorMessage(message);
            return null;
        }

        return finalRevenueReport;
    }


    public PartialRevenueReport? CreatePartialRevenueReport(DateTime date)
    {
        string message;
        var partialRevenueReport = _partialReport.CreatePartialRevenueReport(date, out message);
        if (partialRevenueReport is null)
        {
            _messageBox.ShowErrorMessage(message);
            return partialRevenueReport;
        }

        return partialRevenueReport;
    }

    public List<ItemSales>? GenerateItemSales(List<Item> itemSold)
    {
        string message;
        var itemSalesReport = _itemSaleReport.GenerateItemSales(itemSold, out message);
        if (itemSalesReport is null)
        {
            _messageBox.ShowErrorMessage(message);
            return itemSalesReport;
        }

        return itemSalesReport;
    }

    public MembershipSale? GenerateMembershipSales(Client client, MembershipSaleType membershipSaleType)
    {
        string message;
        var membershipSaleReport = _membershipSalesReport.GetMembershipSales(client, membershipSaleType, out message);
        if (membershipSaleReport is null)
        {
            _messageBox.ShowErrorMessage(message);
            return null;
        }

        return membershipSaleReport;
    }

    public MembershipPending? GeneratePendingMembership(Client client)
    {
        return _pendingMembershipReport.GeneratePendingMembership(client);
    }


    public bool GenerateItemInvoice(ItemInvoice itemInvoice)
    {
        string message;
        if (!_itemInvoice.GenerateItemInvoice(itemInvoice, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }
        return true;
    }
}