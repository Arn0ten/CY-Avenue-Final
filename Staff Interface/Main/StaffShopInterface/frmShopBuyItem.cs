using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Custom;
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
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.preload;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmShopBuyItem : Form
    {
        fncControl Control;
        private bool _VIP;
        private List<Item> _items = PreloadItemData.Items;
        private List<Item> _addToCart = new List<Item>();
        private ItemController _itemController;
        private Item selectedClient = new Item();
        private double totalPrice = 0;
        private double discountedTotal = 0;


        public frmShopBuyItem(bool VIP)
        {
            InitializeComponent();
            Control = new fncControl();
            _VIP = VIP;
            _items = PreloadItemData.Items;
            Load += frmItem_Load;
            _itemController = ServiceLocator.GetService<ItemController>();


            dgvItemAvailable.SelectionChanged += dgvItem_SelectionChanged;
            txtItemQuantity.KeyPress += txtItemQuantity_KeyPress; // Restrict input to integers
            dgvCart.CellContentClick += dgvCart_CellContentClick;
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            LoadItemDataGrid();
            if (_VIP)
            {
                lblVipDiscount.Text = "10%";
                lblDiscountedAmount.Text = "\u20b1: 0.00";
            }
        }

        private void dgvItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItemAvailable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvItemAvailable.SelectedRows[0]; // Get the first selected row

                // Check if the cell value is null or not an integer
                if (selectedRow.Cells["clmListItemId"].Value != null &&
                    int.TryParse(selectedRow.Cells["clmListItemId"].Value.ToString(), out int itemId))
                {
                    selectedClient = _items.FirstOrDefault(c => c.ItemId == itemId);
                    txtItemID.Text = selectedClient?.ItemId.ToString() ?? "N/A";
                }
                else
                {
                    // Handle invalid or null itemId (e.g., show a message or set a default value)
                    txtItemID.Text = "N/A";
                }
            }
        }


        private void LoadItemDataGrid()
        {
            dgvItemAvailable.Rows.Clear();
            foreach (var item in _items)
            {
                int rowIndex = dgvItemAvailable.Rows.Add();
                DataGridViewRow row = dgvItemAvailable.Rows[rowIndex];

                row.Cells["clmListItemId"].Value = item.ItemId;
                row.Cells["clmListName"].Value = item.ItemName;
                row.Cells["clmListCategory"].Value = item.ItemCategory;
                row.Cells["clmListPrice"].Value = item.ItemPrice;
                row.Cells["clmListStock"].Value = item.ItemQuantity;
            }
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(txtItemQuantity.Text, out int quantity))
                {
                    if (selectedClient != null && selectedClient.ItemQuantity >= quantity)
                    {
                        selectedClient.ItemQuantity -= quantity;
                        selectedClient.QuantityToBuy = quantity;

                        // Update DataGridView to reflect new quantity
                        foreach (DataGridViewRow row in dgvItemAvailable.Rows)
                        {
                            if (row.Cells["clmListItemId"].Value != null &&
                                int.TryParse(row.Cells["clmListItemId"].Value.ToString(), out int itemId) &&
                                itemId == selectedClient.ItemId)
                            {
                                row.Cells["clmListStock"].Value = selectedClient.ItemQuantity;
                                break;
                            }
                        }

                        loadAddToCart(selectedClient);
                    }
                    else
                    {
                        MessageBox.Show("Not enough quantity available.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.");
                }
            }
        }

        private void loadAddToCart(Item item)
        {
            // Add item to cart list and display it in dgvCart
            _addToCart.Add(item);
            dgvCart.Rows.Add(
                item.ItemId,
                item.ItemName,
                item.QuantityToBuy,
                (double)item.ItemPrice * item.QuantityToBuy
            );
            loadTotalShit(); // Recalculate total after adding an item
        }

        private void loadTotalShit()
        {
            totalPrice = 0; // Reset totalPrice before summing

            double discount = _VIP ? 0.10 : 0.0;

            // Loop through each row in dgvCart to sum the prices
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["clmTotalPrice"].Value != null &&
                    double.TryParse(row.Cells["clmTotalPrice"].Value.ToString(), out double itemTotal))
                {
                    totalPrice += itemTotal;
                }
            }
            
            // Update the labels with the total and discounted total
            lblItemTotalAmount.Text = $"₱{totalPrice:F2}"; // Original total
            if (_VIP)
            {
                discountedTotal = totalPrice * (1 - discount);
                lblDiscountedAmount.Text = $"₱{discountedTotal:F2}"; // Discounted total
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["clmDelete"].Index && e.RowIndex >= 0)
            {
                int itemId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["clmItemID"].Value);
                int quantityToRevert = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["clmQuantity"].Value);

                // Locate item to remove in cart
                Item itemToRemove = _addToCart.FirstOrDefault(i => i.ItemId == itemId);

                if (itemToRemove != null)
                {
                    _addToCart.Remove(itemToRemove);
                    dgvCart.Rows.RemoveAt(e.RowIndex);

                    // Revert stock quantity in available items list
                    Item originalItem = _items.FirstOrDefault(i => i.ItemId == itemId);
                    if (originalItem != null)
                    {
                        originalItem.ItemQuantity += quantityToRevert;

                        // Update available stock display
                        foreach (DataGridViewRow row in dgvItemAvailable.Rows)
                        {
                            if (row.Cells["clmListItemId"].Value != null &&
                                int.TryParse(row.Cells["clmListItemId"].Value.ToString(), out int gridItemId) &&
                                gridItemId == itemId)
                            {
                                row.Cells["clmListStock"].Value = originalItem.ItemQuantity;
                                break;
                            }
                        }

                        loadTotalShit(); // Recalculate total after removing an item
                    }
                }
            }
        }


        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            double calculate = 0;
            foreach (var total in _addToCart)
            {
                Console.WriteLine(total.ToString());
            }

            Console.WriteLine("Total: " + totalPrice);
            Console.WriteLine("Discounted: " + discountedTotal);
            

            this.Close();
            var FormPurchase = new frmPurchase(_addToCart, _VIP);
            Control.blurOverlay(FormPurchase);
        }


        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PreloadItemData.PreloadItems();
        }

        //Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            PreloadItemData.PreloadItems();
            var FormShopCheckBuyer = new frmShopCheckBuyer();
            FormShopCheckBuyer.Show();
        }


        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}