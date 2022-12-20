namespace _20520944_TH3
{
    partial class play
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_singer = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_name_lyrics = new System.Windows.Forms.Label();
            this.lb_lyrics = new System.Windows.Forms.Label();
            this.lb_volume = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbduration = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.exit = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lb_lyrics);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1106, 627);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.Violet;
            this.lb_singer.Location = new System.Drawing.Point(14, 726);
            this.lb_singer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(123, 49);
            this.lb_singer.TabIndex = 12;
            this.lb_singer.Text = "Ca sĩ";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Violet;
            this.lb_name.Location = new System.Drawing.Point(13, 646);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(277, 56);
            this.lb_name.TabIndex = 13;
            this.lb_name.Text = "Tên bài hát";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(637, 659);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(469, 90);
            this.trackBar.TabIndex = 20;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Plum;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(1108, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 1012);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_name_lyrics
            // 
            this.lb_name_lyrics.AutoSize = true;
            this.lb_name_lyrics.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_lyrics.ForeColor = System.Drawing.Color.Plum;
            this.lb_name_lyrics.Location = new System.Drawing.Point(1113, 9);
            this.lb_name_lyrics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name_lyrics.Name = "lb_name_lyrics";
            this.lb_name_lyrics.Size = new System.Drawing.Size(194, 56);
            this.lb_name_lyrics.TabIndex = 23;
            this.lb_name_lyrics.Text = "Playing";
            // 
            // lb_lyrics
            // 
            this.lb_lyrics.AutoSize = true;
            this.lb_lyrics.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lyrics.ForeColor = System.Drawing.Color.White;
            this.lb_lyrics.Location = new System.Drawing.Point(4, 0);
            this.lb_lyrics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lyrics.Name = "lb_lyrics";
            this.lb_lyrics.Size = new System.Drawing.Size(147, 51);
            this.lb_lyrics.TabIndex = 10;
            this.lb_lyrics.Text = "Lyrics";
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.ForeColor = System.Drawing.Color.Violet;
            this.lb_volume.Location = new System.Drawing.Point(1039, 724);
            this.lb_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(66, 25);
            this.lb_volume.TabIndex = 24;
            this.lb_volume.Text = "00:00";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.ForeColor = System.Drawing.Color.Violet;
            this.lbtime.Location = new System.Drawing.Point(124, 842);
            this.lbtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(66, 25);
            this.lbtime.TabIndex = 25;
            this.lbtime.Text = "00:00";
            // 
            // lbduration
            // 
            this.lbduration.AutoSize = true;
            this.lbduration.ForeColor = System.Drawing.Color.Violet;
            this.lbduration.Location = new System.Drawing.Point(900, 842);
            this.lbduration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbduration.Name = "lbduration";
            this.lbduration.Size = new System.Drawing.Size(66, 25);
            this.lbduration.TabIndex = 26;
            this.lbduration.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(129, 807);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(837, 23);
            this.progressBar1.TabIndex = 27;
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::_20520944_TH3.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(1645, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(58, 65);
            this.exit.TabIndex = 21;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.BackgroundImage = global::_20520944_TH3.Properties.Resources.pause;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pause.FlatAppearance.BorderSize = 0;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(452, 881);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Pause.Size = new System.Drawing.Size(134, 112);
            this.btn_Pause.TabIndex = 19;
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.White;
            this.btn_Next.BackgroundImage = global::_20520944_TH3.Properties.Resources.next;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(675, 892);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Next.Size = new System.Drawing.Size(117, 90);
            this.btn_Next.TabIndex = 18;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.BackgroundImage = global::_20520944_TH3.Properties.Resources.previous;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(235, 892);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Back.Size = new System.Drawing.Size(117, 90);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1706, 1084);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbduration);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.lb_name_lyrics);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_name_lyrics;
        private System.Windows.Forms.Label lb_lyrics;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbduration;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}