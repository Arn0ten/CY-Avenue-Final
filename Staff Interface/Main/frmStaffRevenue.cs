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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmStaffRevenue : Form
    {
        fncControl Control;
        public frmStaffRevenue()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            var FormRevenueReport = new frmRevenueReport();
            Control.blurOverlay(FormRevenueReport);
        }
    }
}
