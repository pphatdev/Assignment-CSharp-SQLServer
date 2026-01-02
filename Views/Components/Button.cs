using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace AssignmentCSharpAndSqlServer
{
    public class RoundedButton : Button
    {
        // Fields for customization
        private int borderRadius = 0; // Set to 0 to enable percentage-based calculation by default
        private float borderSize = 0;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Custom Appearance")]
        public int BorderRadius
        {
            get
            {
                // If 0, calculate a percentage of height. 
                // Note: 5% is very small (2px for a 40px button). 
                // Using 25% for a visible "rounded" effect, or adjust the multiplier below.
                if (borderRadius == 0)
                {
                    int calc = (int)(this.Height * 0.25);
                    return calc < 2 ? 2 : calc;
                }
                return borderRadius;
            }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Custom Appearance")]
        public float BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Custom Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
        }

        // Method to create the graphics path for the rounded rectangle
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Ensure curveSize doesn't exceed dimensions
            if (curveSize > rect.Width) curveSize = rect.Width;
            if (curveSize > rect.Height) curveSize = rect.Height;
            if (curveSize <= 0) curveSize = 1;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            int activeRadius = BorderRadius;

            if (activeRadius > 2) // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, activeRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, activeRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.White, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // 1. Set region to cut the hard corners
                    this.Region = new Region(pathSurface);

                    // 2. Draw surface border for anti-aliasing (smooths the cut)
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // 3. Draw control border if size > 0
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += (s, ev) => this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redraw on resize to update the calculation
        }
    }
}