using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace AssignmentCSharpAndSqlServer
{
    [DefaultEvent("_TextChanged")]
    public class RoundedTextBox : UserControl
    {
        // Fields
        private Color borderColor = Color.Gray; // Changed from MediumSlateBlue to Gray
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.SkyBlue; // Changed from HotPink to SkyBlue
        private int borderRadius = 10;
        private bool isFocused = false;

        // Inner Textbox
        private TextBox textBox1;

        // Events
        public event EventHandler? _TextChanged;

        // Constructor
        public RoundedTextBox()
        {
            textBox1 = new TextBox();
            this.SuspendLayout();

            // TextBox settings
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.BackColor = this.BackColor;
            textBox1.ForeColor = this.ForeColor;

            // Event passthrough
            textBox1.TextChanged += (s, e) => _TextChanged?.Invoke(this, e);
            textBox1.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            textBox1.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            textBox1.KeyPress += (s, e) => this.OnKeyPress(e);

            // Container settings
            this.Padding = new Padding(12, 8, 12, 8);
            this.Size = new Size(250, 35);
            this.BackColor = Color.White;
            this.ForeColor = Color.DimGray;
            this.Controls.Add(textBox1);

            this.DoubleBuffered = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Properties
        [Category("Custom Appearance")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

        [Category("Custom Appearance")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        [Category("Custom Appearance")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }

        [Category("Custom Appearance")]
        public Color BorderFocusColor { get => borderFocusColor; set { borderFocusColor = value; } }

        [Category("Custom Appearance")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }

        [Category("Custom Appearance")]
        public bool PasswordChar { get => textBox1.UseSystemPasswordChar; set => textBox1.UseSystemPasswordChar = value; }

        [Category("Custom Appearance")]
        public override string? Text { get => textBox1.Text; set => textBox1.Text = value ?? string.Empty; }

        [Category("Custom Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        // Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0.5f, 0.5f, this.Width - 1, this.Height - 1);

            if (borderRadius > 1) // Rounded Style
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.White, 2))
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    this.Region = new Region(pathSurface);

                    // Fill background to prevent "not clean" edges
                    using (SolidBrush backBrush = new SolidBrush(this.BackColor))
                    {
                        graph.FillPath(backBrush, pathSurface);
                    }

                    if (underlinedStyle) // Line Style
                    {
                        graph.DrawPath(penSurface, pathSurface);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else // Fully Rounded Style
                    {
                        graph.DrawPath(penSurface, pathSurface);
                        penBorder.Alignment = PenAlignment.Inset;
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Normal Square Style
            {
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            if (curveSize > rect.Width) curveSize = rect.Width;
            if (curveSize > rect.Height) curveSize = rect.Height;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}