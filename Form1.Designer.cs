namespace zerodori_listening_player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start_stop = new System.Windows.Forms.Button();
            this.button_rewind = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.bar_seek = new System.Windows.Forms.TrackBar();
            this.mp3_number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_loop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bar_volume = new System.Windows.Forms.TrackBar();
            this.time_now = new System.Windows.Forms.Label();
            this.time_length = new System.Windows.Forms.Label();
            this.list_speed = new System.Windows.Forms.ComboBox();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bar_seek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start_stop
            // 
            this.button_start_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_start_stop.FlatAppearance.BorderSize = 0;
            this.button_start_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_start_stop.Image")));
            this.button_start_stop.Location = new System.Drawing.Point(113, 80);
            this.button_start_stop.Margin = new System.Windows.Forms.Padding(0);
            this.button_start_stop.Name = "button_start_stop";
            this.button_start_stop.Size = new System.Drawing.Size(32, 32);
            this.button_start_stop.TabIndex = 0;
            this.button_start_stop.UseVisualStyleBackColor = false;
            this.button_start_stop.Click += new System.EventHandler(this.button_start_stop_Click);
            // 
            // button_rewind
            // 
            this.button_rewind.BackColor = System.Drawing.Color.Transparent;
            this.button_rewind.FlatAppearance.BorderSize = 0;
            this.button_rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rewind.Image = ((System.Drawing.Image)(resources.GetObject("button_rewind.Image")));
            this.button_rewind.Location = new System.Drawing.Point(63, 80);
            this.button_rewind.Name = "button_rewind";
            this.button_rewind.Size = new System.Drawing.Size(32, 32);
            this.button_rewind.TabIndex = 1;
            this.button_rewind.UseVisualStyleBackColor = false;
            this.button_rewind.Click += new System.EventHandler(this.button_rewind_Click);
            // 
            // button_forward
            // 
            this.button_forward.BackColor = System.Drawing.Color.Transparent;
            this.button_forward.FlatAppearance.BorderSize = 0;
            this.button_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_forward.Image = ((System.Drawing.Image)(resources.GetObject("button_forward.Image")));
            this.button_forward.Location = new System.Drawing.Point(163, 80);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(32, 32);
            this.button_forward.TabIndex = 2;
            this.button_forward.UseVisualStyleBackColor = false;
            this.button_forward.Click += new System.EventHandler(this.button_forward_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Image = ((System.Drawing.Image)(resources.GetObject("button_next.Image")));
            this.button_next.Location = new System.Drawing.Point(213, 80);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(32, 32);
            this.button_next.TabIndex = 3;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.Color.Transparent;
            this.button_prev.FlatAppearance.BorderSize = 0;
            this.button_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev.Image = ((System.Drawing.Image)(resources.GetObject("button_prev.Image")));
            this.button_prev.Location = new System.Drawing.Point(13, 80);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(32, 32);
            this.button_prev.TabIndex = 4;
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // bar_seek
            // 
            this.bar_seek.Location = new System.Drawing.Point(74, 124);
            this.bar_seek.Maximum = 100;
            this.bar_seek.Name = "bar_seek";
            this.bar_seek.Size = new System.Drawing.Size(160, 45);
            this.bar_seek.TabIndex = 5;
            this.bar_seek.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bar_seek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bar_seek_KeyDown);
            this.bar_seek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_seek_MouseUp);
            // 
            // mp3_number
            // 
            this.mp3_number.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mp3_number.Location = new System.Drawing.Point(41, 12);
            this.mp3_number.MaxLength = 3;
            this.mp3_number.Name = "mp3_number";
            this.mp3_number.Size = new System.Drawing.Size(40, 20);
            this.mp3_number.TabIndex = 7;
            this.mp3_number.Text = "001";
            this.mp3_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mp3_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mp3_number_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_loop
            // 
            this.button_loop.BackColor = System.Drawing.Color.Transparent;
            this.button_loop.FlatAppearance.BorderSize = 0;
            this.button_loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_loop.Image = ((System.Drawing.Image)(resources.GetObject("button_loop.Image")));
            this.button_loop.Location = new System.Drawing.Point(263, 80);
            this.button_loop.Name = "button_loop";
            this.button_loop.Size = new System.Drawing.Size(32, 32);
            this.button_loop.TabIndex = 9;
            this.button_loop.UseVisualStyleBackColor = false;
            this.button_loop.Click += new System.EventHandler(this.button_loop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "speed";
            // 
            // bar_volume
            // 
            this.bar_volume.Location = new System.Drawing.Point(213, 12);
            this.bar_volume.Maximum = 100;
            this.bar_volume.Name = "bar_volume";
            this.bar_volume.Size = new System.Drawing.Size(67, 45);
            this.bar_volume.TabIndex = 12;
            this.bar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bar_volume.Value = 50;
            this.bar_volume.Scroll += new System.EventHandler(this.bar_volume_Scroll);
            this.bar_volume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bar_volume_KeyDown);
            // 
            // time_now
            // 
            this.time_now.AutoSize = true;
            this.time_now.Location = new System.Drawing.Point(38, 128);
            this.time_now.Name = "time_now";
            this.time_now.Size = new System.Drawing.Size(28, 13);
            this.time_now.TabIndex = 13;
            this.time_now.Text = "0:00";
            // 
            // time_length
            // 
            this.time_length.AutoSize = true;
            this.time_length.Location = new System.Drawing.Point(240, 128);
            this.time_length.Name = "time_length";
            this.time_length.Size = new System.Drawing.Size(34, 13);
            this.time_length.TabIndex = 14;
            this.time_length.Text = "12:34";
            // 
            // list_speed
            // 
            this.list_speed.FormattingEnabled = true;
            this.list_speed.Items.AddRange(new object[] {
            "0.5",
            "0.75",
            "1.0",
            "1.25",
            "1.5",
            "1.75",
            "2.0"});
            this.list_speed.Location = new System.Drawing.Point(139, 12);
            this.list_speed.Name = "list_speed";
            this.list_speed.Size = new System.Drawing.Size(56, 21);
            this.list_speed.TabIndex = 15;
            this.list_speed.SelectedIndexChanged += new System.EventHandler(this.list_speed_SelectedIndexChanged);
            this.list_speed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_speed_KeyDown);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(10, 48);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(174, 16);
            this.label_title.TabIndex = 16;
            this.label_title.Text = "001_Part 2とは？_Directions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 153);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.list_speed);
            this.Controls.Add(this.time_length);
            this.Controls.Add(this.time_now);
            this.Controls.Add(this.bar_volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_loop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mp3_number);
            this.Controls.Add(this.bar_seek);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_forward);
            this.Controls.Add(this.button_rewind);
            this.Controls.Add(this.button_start_stop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "zlp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bar_seek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start_stop;
        private System.Windows.Forms.Button button_rewind;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.TrackBar bar_seek;
        private System.Windows.Forms.TextBox mp3_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_loop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bar_volume;
        private System.Windows.Forms.Label time_now;
        private System.Windows.Forms.Label time_length;
        private System.Windows.Forms.ComboBox list_speed;
        private System.Windows.Forms.Label label_title;
    }
}

