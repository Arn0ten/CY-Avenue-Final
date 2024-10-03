using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace csLaundrySystem
{
    public class CustomizableCornerPanel : Panel
    {
        private int cornerRadius = 20;

        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                Invalidate(); // Redraw the panel when the corner radius changes
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawRoundedPanel(e.Graphics);
        }

        private void DrawRoundedPanel(Graphics g)
        {
            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top left corner
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top right corner
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom right corner
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom left corner
            path.CloseFigure();

            Region = new Region(path);

            // Fill the panel background
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, path);
            }

            // Optional: Draw a border
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                g.DrawPath(pen, path);
            }
        }

        // Properties 1for border color and width
        public Color BorderColor { get; set; } = Color.Black;
        public float BorderWidth { get; set; } = 1.0f;
    }
}
