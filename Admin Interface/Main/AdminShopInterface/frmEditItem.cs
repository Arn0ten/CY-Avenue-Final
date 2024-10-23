using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend.monolith.item;
using CarlosYulo.backend.monolith.shop;
using Guna.UI2.WinForms;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmEditItem : Form
    {
        private ItemController _itemController;
        public Item _item;
        public bool _success;


        public frmEditItem(ItemController itemController, Item item, bool success)
        {
            InitializeComponent();
            _itemController = itemController;
            _item = item;
            _success = success;
            PlaceHolder();
        }

        private void PlaceHolder()
        {
            txtItemID.PlaceholderText = _item.ItemId.ToString();
            txtItemName.PlaceholderText = _item.ItemName;
            txtItemPrice.PlaceholderText = _item.ItemPrice.ToString();
            txtItemLiabilities.PlaceholderText = _item.ItemLiabilityCost.ToString();
            txtItemDescription.PlaceholderText = _item.ItemDescription;
        }

        string GetTextIfNotEmpty(Guna2TextBox textBox) =>
            !string.IsNullOrWhiteSpace(textBox.Text) ? textBox.Text : null;

        int? GetIntIfValid(Guna2TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : (int?)null;
        }

        double? GetDoubleIfValid(Guna2TextBox textBox)
        {
            return double.TryParse(textBox.Text, out double result) ? result : (double?)null;
        }

        //X
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Save
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var name = GetTextIfNotEmpty(txtItemName);
            _item.ItemName = name ?? _item.ItemName;

            var descripion = GetTextIfNotEmpty(txtItemDescription);
            _item.ItemDescription = descripion ?? _item.ItemDescription;

            var quanitity = GetIntIfValid(txtItemQuantity);
            _item.ItemQuantity = quanitity ?? _item.ItemQuantity;

            var price = GetDoubleIfValid(txtItemPrice);
            _item.ItemPrice = price ?? _item.ItemPrice;

            var liability = GetDoubleIfValid(txtItemLiabilities);
            _item.ItemLiabilityCost = liability ?? _item.ItemLiabilityCost;

            _item.ItemCategory = cmbItemCategory.SelectedIndex >= 0
                ? cmbItemCategory.SelectedItem.ToString() // Get the selected item's text
                : _item.ItemCategory; // Keep the existing value if nothing is selected

            Console.WriteLine("Saving Item");
            Console.WriteLine(_item.ToString());
            // UPDATE
            try
            {
                if (!_itemController.UpdateDetails(_item))
                {
                    _success = false;
                    return;
                }

                MessageBox.Show("Staff updated successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _success = true;
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        //Browse
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _item.SetProfilePicture(openFileDialog.FileName);
                picItemPhoto.Image = _item.ItemPicture;
            }
        }


        private void frmEditItem_Load(object sender, EventArgs e)
        {
        }
    }
}