namespace DeberFiguras
{
    partial class FrmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pentagonoToolStripMenuItem,
            this.romboToolStripMenuItem,
            this.romboideToolStripMenuItem,
            this.trapezoideToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentagonoToolStripMenuItem.Text = "Pentagono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboToolStripMenuItem.Text = "Rombo";
            this.romboToolStripMenuItem.Click += new System.EventHandler(this.romboToolStripMenuItem_Click);
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboideToolStripMenuItem.Text = "Romboide";
            this.romboideToolStripMenuItem.Click += new System.EventHandler(this.romboideToolStripMenuItem_Click);
            // 
            // trapezoideToolStripMenuItem
            // 
            this.trapezoideToolStripMenuItem.Name = "trapezoideToolStripMenuItem";
            this.trapezoideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trapezoideToolStripMenuItem.Text = "Trapezoide";
            this.trapezoideToolStripMenuItem.Click += new System.EventHandler(this.trapezoideToolStripMenuItem_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 28);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 422);
            this.panelContenedor.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapezoideToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
    }
}