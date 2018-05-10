namespace UI
{
    partial class frmSegreteria
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
            this.anagraficheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagraficheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2126, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anagraficheToolStripMenuItem
            // 
            this.anagraficheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunniToolStripMenuItem,
            this.esamiToolStripMenuItem,
            this.corsiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.esciToolStripMenuItem});
            this.anagraficheToolStripMenuItem.Name = "anagraficheToolStripMenuItem";
            this.anagraficheToolStripMenuItem.Size = new System.Drawing.Size(187, 45);
            this.anagraficheToolStripMenuItem.Text = "Anagrafiche";
            // 
            // alunniToolStripMenuItem
            // 
            this.alunniToolStripMenuItem.Name = "alunniToolStripMenuItem";
            this.alunniToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.alunniToolStripMenuItem.Text = "Alunni";
            this.alunniToolStripMenuItem.Click += new System.EventHandler(this.alunniToolStripMenuItem_Click);
            // 
            // esamiToolStripMenuItem
            // 
            this.esamiToolStripMenuItem.Name = "esamiToolStripMenuItem";
            this.esamiToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.esamiToolStripMenuItem.Text = "Esami";
            // 
            // corsiToolStripMenuItem
            // 
            this.corsiToolStripMenuItem.Name = "corsiToolStripMenuItem";
            this.corsiToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.corsiToolStripMenuItem.Text = "Corsi";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(323, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // frmSegreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2126, 958);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSegreteria";
            this.Text = "Segreteria Studenti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anagraficheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esamiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
    }
}

