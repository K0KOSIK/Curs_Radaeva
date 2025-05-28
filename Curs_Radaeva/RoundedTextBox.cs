using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_Radaeva
{
    [Designer("System.Windows.Forms.Design.TextBoxDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class RoundedTextBox : TextBox
    {
        private int _borderRadius = 20;

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var path = GetRoundRectangle(ClientRectangle))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Заливка фона
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Рисуем границу
                using (var pen = new Pen(ForeColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundRectangle(Rectangle rect)
        {
            int radius = BorderRadius * 2;
            var path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
