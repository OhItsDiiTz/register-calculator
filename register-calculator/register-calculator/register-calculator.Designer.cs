namespace register_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            CalculateCostMenuItem = new ToolStripMenuItem();
            ClearItemsMenuItem = new ToolStripMenuItem();
            CB_ems_pd_discount = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { CalculateCostMenuItem, ClearItemsMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // CalculateCostMenuItem
            // 
            CalculateCostMenuItem.Name = "CalculateCostMenuItem";
            CalculateCostMenuItem.Size = new Size(68, 20);
            CalculateCostMenuItem.Text = "Calculate";
            CalculateCostMenuItem.Click += CalculateCostMenuItem_Click;
            // 
            // ClearItemsMenuItem
            // 
            ClearItemsMenuItem.Name = "ClearItemsMenuItem";
            ClearItemsMenuItem.Size = new Size(46, 20);
            ClearItemsMenuItem.Text = "Clear";
            ClearItemsMenuItem.Click += ClearItemsMenuItem_Click;
            // 
            // CB_ems_pd_discount
            // 
            CB_ems_pd_discount.AutoSize = true;
            CB_ems_pd_discount.Location = new Point(353, 27);
            CB_ems_pd_discount.Name = "CB_ems_pd_discount";
            CB_ems_pd_discount.Size = new Size(119, 19);
            CB_ems_pd_discount.TabIndex = 1;
            CB_ems_pd_discount.Text = "EMS/PD Discount";
            CB_ems_pd_discount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(CB_ems_pd_discount);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 0);
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CalculateCostMenuItem;
        private ToolStripMenuItem ClearItemsMenuItem;
        private CheckBox CB_ems_pd_discount;
    }
}
