﻿using csCY_Avenue.Custom;
using System;
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
    public partial class frmRevenue : Form
    {
        fncControl Control;
        public frmRevenue()
        {
            InitializeComponent();
            Control = new fncControl();
        }


        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            var FormRevenueReport = new frmRevenueReport();
            Control.blurOverlay(FormRevenueReport);
        }

        private void dgvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
