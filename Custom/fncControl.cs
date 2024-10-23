using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csCY_Avenue.Custom
{
    internal class fncControl
    {
        // Pampa blur sa Dialog background
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


        //Panel loader 
        public void LoadFormInPanel(Panel panel, Form form)
        {
            panel.Controls.Clear();
            if (form != null && form.IsHandleCreated)
            {
                form.Hide();
                form.Dispose();
            }
            panel.Controls.Clear();
            form = (Form)Activator.CreateInstance(form.GetType());
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }


    }
}
