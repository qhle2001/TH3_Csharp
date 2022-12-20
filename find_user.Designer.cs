namespace _20520944_TH3
{
    partial class find_user
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiHátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghệSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lờiBàiHátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảToolStripMenuItem,
            this.bàiHátToolStripMenuItem,
            this.nghệSĩToolStripMenuItem,
            this.caSĩToolStripMenuItem,
            this.lờiBàiHátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1595, 65);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tấtCảToolStripMenuItem
            // 
            this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            this.tấtCảToolStripMenuItem.Size = new System.Drawing.Size(105, 59);
            this.tấtCảToolStripMenuItem.Text = "All";
            this.tấtCảToolStripMenuItem.Click += new System.EventHandler(this.tấtCảToolStripMenuItem_Click);
            // 
            // bàiHátToolStripMenuItem
            // 
            this.bàiHátToolStripMenuItem.Name = "bàiHátToolStripMenuItem";
            this.bàiHátToolStripMenuItem.Size = new System.Drawing.Size(145, 59);
            this.bàiHátToolStripMenuItem.Text = "Song";
            this.bàiHátToolStripMenuItem.Click += new System.EventHandler(this.bàiHátToolStripMenuItem_Click_1);
            // 
            // nghệSĩToolStripMenuItem
            // 
            this.nghệSĩToolStripMenuItem.Name = "nghệSĩToolStripMenuItem";
            this.nghệSĩToolStripMenuItem.Size = new System.Drawing.Size(176, 59);
            this.nghệSĩToolStripMenuItem.Text = "Singer";
            this.nghệSĩToolStripMenuItem.Click += new System.EventHandler(this.nghệSĩToolStripMenuItem_Click_1);
            // 
            // caSĩToolStripMenuItem
            // 
            this.caSĩToolStripMenuItem.Name = "caSĩToolStripMenuItem";
            this.caSĩToolStripMenuItem.Size = new System.Drawing.Size(164, 59);
            this.caSĩToolStripMenuItem.Text = "Artist";
            this.caSĩToolStripMenuItem.Click += new System.EventHandler(this.caSĩToolStripMenuItem_Click_1);
            // 
            // lờiBàiHátToolStripMenuItem
            // 
            this.lờiBàiHátToolStripMenuItem.Name = "lờiBàiHátToolStripMenuItem";
            this.lờiBàiHátToolStripMenuItem.Size = new System.Drawing.Size(171, 59);
            this.lờiBàiHátToolStripMenuItem.Text = "Lyrics";
            this.lờiBàiHátToolStripMenuItem.Click += new System.EventHandler(this.lờiBàiHátToolStripMenuItem_Click_1);
            // 
            // fpn
            // 
            this.fpn.AutoScroll = true;
            this.fpn.BackColor = System.Drawing.Color.Pink;
            this.fpn.Location = new System.Drawing.Point(0, 70);
            this.fpn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(1591, 1105);
            this.fpn.TabIndex = 2;
            this.fpn.Paint += new System.Windows.Forms.PaintEventHandler(this.fpn_Paint);
            // 
            // find_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "find_user";
            this.Size = new System.Drawing.Size(1595, 1180);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiHátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghệSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lờiBàiHátToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fpn;
    }
}
