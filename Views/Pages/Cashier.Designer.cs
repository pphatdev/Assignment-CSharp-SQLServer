namespace AssignmentCSharpAndSqlServer.Views.Pages
{
    partial class Cashier
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productCardsPanel = new Panel();
            productDetailPanel = new Panel();
            SuspendLayout();
            // 
            // productCardsPanel
            // 
            productCardsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productCardsPanel.AutoScroll = true;
            productCardsPanel.BackColor = Color.White;
            productCardsPanel.BorderStyle = BorderStyle.FixedSingle;
            productCardsPanel.Location = new Point(20, 20);
            productCardsPanel.Margin = new Padding(10);
            productCardsPanel.Name = "productCardsPanel";
            productCardsPanel.Size = new Size(750, 573);
            productCardsPanel.TabIndex = 0;
            // 
            // productDetailPanel
            // 
            productDetailPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            productDetailPanel.BackColor = Color.WhiteSmoke;
            productDetailPanel.BorderStyle = BorderStyle.FixedSingle;
            productDetailPanel.Location = new Point(790, 20);
            productDetailPanel.Name = "productDetailPanel";
            productDetailPanel.Size = new Size(390, 573);
            productDetailPanel.TabIndex = 1;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productDetailPanel);
            Controls.Add(productCardsPanel);
            Name = "Cashier";
            Size = new Size(1200, 613);
            ResumeLayout(false);
        }

        #endregion

        private Panel productCardsPanel;
        private Panel productDetailPanel;
    }
}
