﻿using csCY_Avenue.Custom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Admin_Interface.Main.AdminShopInterface
{
    public partial class frmShopTransactions : Form
    {
        fncControl Control;
        public frmShopTransactions()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmShopTransactions_Load(object sender, EventArgs e)
        {
            update();
        }



        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("lubot");
            row.Add("Gear");
            row.Add("120");
            row.Add("02/27/2002");          
            row.Add("Paid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("lubot");
            row.Add("Gear");
            row.Add("120");
            row.Add("02/27/2002");
            row.Add("Paid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("lubot");
            row.Add("Gear");
            row.Add("120");
            row.Add("02/27/2002");
            row.Add("Paid");
            dgvInvoice.Rows.Add(row.ToArray());


        }


        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var FormViewTransaction = new frmViewTransaction();
                Control.blurOverlay(FormViewTransaction);
            }
        }



        //Na pindot
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
