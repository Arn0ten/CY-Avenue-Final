using CarlosYulo.backend.monolith.item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend.monolith.shop;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceLocator = CarlosYulo.ServiceLocator;
using csCY_Avenue.Custom;
using csCY_Avenue.Database;
using CarlosYulo.backend;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddItem : Form
    {
        private ItemController _itemController;
        public Item _item;
        public bool _success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmAddItem(ItemController itemController, Item item, bool success)
        {
            InitializeComponent();
            _itemController = itemController;
            _item = item;
            _success = success;

            txtItemPrice.KeyPress += NumericTextBox_KeyPress;
            txtItemQuantity.KeyPress += NumericTextBox_KeyPress;
            txtMarketprice.KeyPress += NumericTextBox_KeyPress;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            // Assign input values to the Item object properties
            _item.ItemName = txtItemName.Text;
            _item.ItemPrice = string.IsNullOrWhiteSpace(txtItemPrice.Text) ? 0 : Convert.ToDouble(txtItemPrice.Text);
            _item.ItemQuantity = string.IsNullOrWhiteSpace(txtItemQuantity.Text) ? 0 : Convert.ToInt32(txtItemQuantity.Text);
            _item.ItemLiabilityCost = string.IsNullOrWhiteSpace(txtMarketprice.Text) ? 0 : Convert.ToDouble(txtMarketprice.Text);

            // Check and assign Item Description
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill out the following: description.");
                _success = false;
                return;
            }
            _item.ItemDescription = txtDescription.Text;

            // Check and assign Item Category
            if (cmbItemCategory.SelectedItem != null)
            {
                _item.ItemCategory = cmbItemCategory.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item category.");
                _success = false;
                return;
            }

            // Save new item using the item controller
            if (!_itemController.Create(_item))
            {
                _success = false;
                return;
            }

            // Add notification
            notificationService.AddNotification(
            "Item Addition",
                $"New Item '{txtItemName.Text}' added in the shop.",
                txtItemName.Text
            );
            MessageBox.Show(
                $"New item added in the shop. Name: '{txtItemName.Text}' Price: '{txtItemPrice.Text}'",
                "Item Added!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            _success = true;
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!_item.SetProfilePicture(openFileDialog.FileName, out string message))
                {
                    MessageBox.Show(message, "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _success = false;
                    return;
                }
                picItemPhoto.Image = _item.ItemPicture;
            }
        }
    }
}
