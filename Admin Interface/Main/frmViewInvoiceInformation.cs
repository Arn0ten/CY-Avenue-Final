﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmViewInvoiceInformation : Form
    {
        public frmViewInvoiceInformation()
        {
            InitializeComponent();
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Pay
        private void btnInvoicePay_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormPay = new frmPay();
            blurOverlay(FormPay);

        }

        // Blur Dialog
        public void blurOverlay(Form formDialog, Color backgroundColor = default)
        {
            var overlayForm = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = backgroundColor == default ? Color.Black : backgroundColor,
                Size = new Size(1366, 768),
                Location = new Point(0, 0),
                ShowInTaskbar = false,
                TopMost = true
            };
            overlayForm.Show();
            formDialog.Owner = overlayForm;
            formDialog.TopMost = true;
            formDialog.ShowDialog();
            overlayForm.Dispose();

        }


    }
}