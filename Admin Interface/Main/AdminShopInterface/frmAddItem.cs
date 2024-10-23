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

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddItem : Form
    {
        private ItemController _itemController;
        public Item _item;
        public bool _success;

        public frmAddItem(ItemController itemController,Item item, bool success)
        {
            InitializeComponent();
            _itemController = itemController;
            _item = item;
            _success = success;
            
            txtItemPrice.KeyPress += NumericTextBox_KeyPress;
            txtItemQuantity.KeyPress += NumericTextBox_KeyPress;
            txtMarketprice.KeyPress += NumericTextBox_KeyPress;
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
        
        
        //X
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            _item.ItemName = txtItemName.Text;
            _item.ItemPrice = string.IsNullOrWhiteSpace(txtItemPrice.Text) ? 0 : Convert.ToDouble(txtItemPrice.Text);
            _item.ItemQuantity = string.IsNullOrWhiteSpace(txtItemQuantity.Text) ? 0 : Convert.ToInt32(txtItemQuantity.Text);
            _item.ItemLiabilityCost = string.IsNullOrWhiteSpace(txtMarketprice.Text) ? 0 : Convert.ToDouble(txtMarketprice.Text);

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
            
            // SAVE NEW ITEM
            if (!_itemController.Create(_item))
            {
                _success = false;
                return;
            }
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