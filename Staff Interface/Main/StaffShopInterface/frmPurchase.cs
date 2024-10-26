using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Custom;
using csCY_Avenue.Staff_Interface.Main.StaffShopInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend.monolith.item;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.preload;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Database;
using CarlosYulo.backend;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPurchase : Form
    {
        fncControl Control;
        private ItemController _itemController;
        private RevenueController _revenueController;
        private List<Item> _addToCart;
        private bool _VIP;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmPurchase(List<Item> addToCart, bool VIP)
        {
            InitializeComponent();
            Control = new fncControl();
            _itemController = ServiceLocator.GetService<ItemController>();
            _revenueController = ServiceLocator.GetService<RevenueController>();

            //
            _addToCart = addToCart;
            _VIP = VIP;
            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();

            //
            LoadFormAGAIN();
            loadDataGrid();
        }

        private void LoadFormAGAIN()
        {
            int totalQuantity = 0;
            double subTotal = 0;

            foreach (var items in _addToCart)
            {
                totalQuantity += items.QuantityToBuy ?? 0;
                subTotal += items.ItemPrice * items.QuantityToBuy ?? 0;
            }

            lblTotalItems.Text = totalQuantity.ToString();
            lblDiscount.Text = _VIP ? "10%" : "N/A";
            lblSubtotal.Text = subTotal.ToString("N2");
            lblItemTotalAmount.Text = _VIP ? (subTotal - (subTotal * .10)).ToString("N2") : subTotal.ToString("N2");
        }

        private void loadDataGrid()
        {
            // Clear existing rows to avoid duplicates
            dgvItemList.Rows.Clear();

            // Loop through each item in the collection and add it to the DataGridView
            foreach (var item in _addToCart)
            {
                // Add a new row to the DataGridView for each item
                dgvItemList.Rows.Add(
                    item.ItemCategory,
                    item.ItemName,
                    item.QuantityToBuy,
                    item.ItemPrice
                );
            }
        }


        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Purchase
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (_itemController.BuyItem(_addToCart))
                {

                    // setting up for crystal report
                    double merchandise = 0;
                    double equipment = 0;
                    double supplement = 0;
                    foreach (var item in _addToCart)
                    {
                        // Get item price and quantity, using 0 if null
                        double itemPrice = item.ItemPrice ?? 0;
                        int quantityToBuy = item.QuantityToBuy ?? 0;

                        // Calculate total cost based on item category
                        if (item.ItemCategory == "Merchandise")
                        {
                            merchandise += itemPrice * quantityToBuy;
                        }
                        else if (item.ItemCategory == "Equipment")
                        {
                            equipment += itemPrice * quantityToBuy;
                        }
                        else if (item.ItemCategory == "Supplement")
                        {
                            supplement += itemPrice * quantityToBuy;
                        }
                    }

                    // Apply discount if _VIP is true
                    if (_VIP)
                    {
                        merchandise *= 0.90;
                        equipment *= 0.90;
                        supplement *= 0.90;
                    }

                    ItemInvoice invoice = new ItemInvoice()
                    {
                        Merchandise = merchandise,
                        Equipment = equipment,
                        Supplement = supplement,
                        Discount = _VIP ? 0.1 : 0,
                        TotalPrice = merchandise + equipment + supplement
                    };

                    // invoice
                    if (!_revenueController.GenerateItemInvoice(invoice))
                    {
                        // Handle failed invoice generation (e.g., show an error message)
                        MessageBox.Show("Failed to generate the invoice. Please try again.");
                        return;
                    }

                    // sales 
                    var sales = _revenueController.GenerateItemSales(_addToCart);
                    if (sales == null)
                    {
                        // Handle failed sales generation
                        MessageBox.Show("Failed to record sales. Please try again.");
                        return;
                    }

                    // preload
                    PreloadItemData.PreloadItems();
                    PreloadRevenueData.PreLoad();

                    // Add notification for purchase
                    notificationService.AddNotification(
                        "Purchase Successful",
                        $"Purchase completed successfully! Total: {invoice.TotalPrice:N2}.",
                        "Purchase"
                    );

                    MessageBox.Show(
                        $"Purchase completed! Total amount: {invoice.TotalPrice:N2}.",
                        "Purchase Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var FormPaidPurchase = new frmPaidPurchase(merchandise, equipment, supplement);
                    Control.blurOverlay(FormPaidPurchase);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // var FormBuyItem = new frmShopBuyItem();
            // FormBuyItem.Show();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}