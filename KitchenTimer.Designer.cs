namespace zerodori_listening_player
{
    partial class KitchenTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenTimer));
            this.button_main = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sec = new System.Windows.Forms.NumericUpDown();
            this.label_hms = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sec)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_main
            // 
            this.button_main.FlatAppearance.BorderSize = 0;
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_main.Location = new System.Drawing.Point(24, 12);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(256, 64);
            this.button_main.TabIndex = 0;
            this.button_main.Text = "00:00:00";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.Button_main_Click);
            // 
            // button_start
            // 
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Image = ((System.Drawing.Image)(resources.GetObject("button_start.Image")));
            this.button_start.Location = new System.Drawing.Point(121, 96);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(64, 32);
            this.button_start.TabIndex = 1;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_hour.Location = new System.Drawing.Point(49, 17);
            this.numericUpDown_hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_hour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(74, 56);
            this.numericUpDown_hour.TabIndex = 2;
            this.numericUpDown_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_hour.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDown_hour.ValueChanged += new System.EventHandler(this.NumericUpDown_hour_ValueChanged);
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_min.Location = new System.Drawing.Point(121, 17);
            this.numericUpDown_min.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(74, 56);
            this.numericUpDown_min.TabIndex = 3;
            this.numericUpDown_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_min.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDown_min.ValueChanged += new System.EventHandler(this.NumericUpDown_min_sec_ValueChanged);
            // 
            // numericUpDown_sec
            // 
            this.numericUpDown_sec.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_sec.Location = new System.Drawing.Point(191, 17);
            this.numericUpDown_sec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_sec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_sec.Name = "numericUpDown_sec";
            this.numericUpDown_sec.Size = new System.Drawing.Size(74, 56);
            this.numericUpDown_sec.TabIndex = 4;
            this.numericUpDown_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_sec.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDown_sec.ValueChanged += new System.EventHandler(this.NumericUpDown_min_sec_ValueChanged);
            // 
            // label_hms
            // 
            this.label_hms.Location = new System.Drawing.Point(46, 76);
            this.label_hms.Name = "label_hms";
            this.label_hms.Size = new System.Drawing.Size(222, 16);
            this.label_hms.TabIndex = 5;
            this.label_hms.Text = "        hour                  min                  sec";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.TopMostToolStripMenuItem_Click);
            // 
            // KitchenTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 153);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label_hms);
            this.Controls.Add(this.numericUpDown_sec);
            this.Controls.Add(this.numericUpDown_min);
            this.Controls.Add(this.numericUpDown_hour);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenTimer";
            this.Text = "zlp - Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitchenTimer_FormClosing);
            this.SizeChanged += new System.EventHandler(this.KitchenTimer_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sec)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_hour;
        private System.Windows.Forms.NumericUpDown numericUpDown_min;
        private System.Windows.Forms.NumericUpDown numericUpDown_sec;
        private System.Windows.Forms.Label label_hms;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
    }
}