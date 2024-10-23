using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend.monolith.item;
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.preload;


namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmShopManagement : Form
    {
        private ItemController _itemController;
        private List<Item> _items = PreloadItemData.Items;
        fncControl Control;

        public frmShopManagement()
        {
            _itemController = ServiceLocator.GetService<ItemController>();
            InitializeComponent();
            Control = new fncControl();
            Load += frmItem_Load;
            dgvItem.SelectionChanged += dgvStaff_SelectionChanged;
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            LoadItemDataGrid();
        }

        // REAL TIME CLICK UPDATE SIDE PANEL
        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvItem.SelectedRows[0]; // Get the first selected row

                int membershipId = Convert.ToInt32(selectedRow.Cells["clmItemId"].Value);

                Item selectedClient = _items.FirstOrDefault(c => c.ItemId == membershipId);

                UpdateDetailsPanel(selectedRow, selectedClient);
            }
        }

        // LOAD DATA
        private void LoadItemDataGrid()
        {
            dgvItem.Rows.Clear();
            foreach (var item in _items)
            {
                int rowIndex = dgvItem.Rows.Add();
                DataGridViewRow row = dgvItem.Rows[rowIndex];

                row.Cells["clmItemId"].Value = item.ItemId;
                row.Cells["clmName"].Value = item.ItemName;
                row.Cells["clmCategory"].Value = item.ItemCategory;
                row.Cells["clmPrice"].Value = item.ItemPrice;
                row.Cells["clmStock"].Value = item.ItemQuantity;
            }
        }

        //
        private void loadDataGridLive(Item item)
        {
            int rowIndex = dgvItem.Rows.Add();
            DataGridViewRow row = dgvItem.Rows[rowIndex];

            row.Cells["clmItemId"].Value = item.ItemId;
            row.Cells["clmName"].Value = item.ItemName;
            row.Cells["clmCategory"].Value = item.ItemCategory;
            row.Cells["clmMPrice"].Value = item.ItemPrice;
            row.Cells["clmStock"].Value = item.ItemQuantity;
        }

        // UPDATE LIVE
        private void UpdateDataGridLive(Item item, int itemId)
        {
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (Convert.ToInt32(row.Cells["clmItemId"].Value) == itemId)
                {
                    row.Cells["clmItemId"].Value = item.ItemId;
                    row.Cells["clmName"].Value = item.ItemName;
                    row.Cells["clmCategory"].Value = item.ItemCategory;
                    row.Cells["clmMPrice"].Value = item.ItemPrice;
                    row.Cells["clmStock"].Value = item.ItemQuantity;

                    break;
                }
            }
        }


        // UPDATE PANEL EVERY CLICK ROW
        private void UpdateDetailsPanel(DataGridViewRow row, Item item)
        {
            // Update the controls that are part of the DataGridView
            txtItemName.Text = row.Cells["clmName"].Value?.ToString();
            txtItemID.Text = row.Cells["clmItemId"].Value?.ToString();
            txtItemCategory.Text = row.Cells["clmCategory"].Value?.ToString();
            txtItemStock.Text = row.Cells["clmStock"].Value?.ToString();

            // Update the extra controls using the Client object
            if (item != null)
            {
                txtItemDescription.Text = item.ItemDescription;
                picItemPhoto.Image = item.ItemPicture ?? null;
                lblPrice.Text =  $"₱{item.ItemPrice:0.00}";
                lblLiabilityPrice.Text = $"₱{item.ItemLiabilityCost:0.00}";
            }
        }


        //Add
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            bool success = false;
            var FormAddItem = new frmAddItem(_itemController, newItem, success);
            Control.blurOverlay(FormAddItem);

            if (FormAddItem._success)
            {
                loadDataGridLive(FormAddItem._item);
                _items.Add(FormAddItem._item);
            }
        }

        //Edit Item
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Check if the StaffID is a valid integer
            if (!int.TryParse(txtItemID.Text, out int staffId))
            {
                MessageBox.Show("Invalid item ID");
                return;
            }

            var itemIndex = _items.FindIndex(emp => emp.ItemId == staffId);
            var item = _items[itemIndex];

            // Open the edit form if employee exists
            bool success = false;
            var FormEditItem = new frmEditItem(_itemController, item, success);
            Control.blurOverlay(FormEditItem);

            // success
            if (FormEditItem._success)
            {
                _items[itemIndex] = FormEditItem._item;
                UpdateDataGridLive(item, staffId);
            }
        }

        //Delete
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
        }
    }
}