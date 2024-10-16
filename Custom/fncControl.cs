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
            panel.Controls.Clear(); // Clear existing controls from the panel

            if (form != null)
            {
                // Ensure the form is not disposed before using it
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(form.GetType());
                }

                form.TopLevel = false; // Set the form to be a non-top-level window
                form.Dock = DockStyle.Fill; // Fill the panel with the form
                panel.Controls.Add(form); // Add the form to the panel
                form.Show(); // Show the form
            }
        }



    }
}
