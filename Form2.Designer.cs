﻿namespace zerodori_listening_player
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_rewind = new System.Windows.Forms.Label();
            this.rewind_sec = new System.Windows.Forms.TextBox();
            this.label_sec1 = new System.Windows.Forms.Label();
            this.label_sec2 = new System.Windows.Forms.Label();
            this.forward_sec = new System.Windows.Forms.TextBox();
            this.label_forward = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_default = new System.Windows.Forms.Button();
            this.button_application = new System.Windows.Forms.Button();
            this.button_shortcuts = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.picture_icon = new System.Windows.Forms.PictureBox();
            this.label_name_short = new System.Windows.Forms.Label();
            this.label_name_full = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_license = new System.Windows.Forms.Label();
            this.label_source = new System.Windows.Forms.Label();
            this.linkLabel_license = new System.Windows.Forms.LinkLabel();
            this.linkLabel_source = new System.Windows.Forms.LinkLabel();
            this.label_author = new System.Windows.Forms.Label();
            this.label_sc_speed_up = new System.Windows.Forms.Label();
            this.label_sc_speed_down = new System.Windows.Forms.Label();
            this.label_sc_prev = new System.Windows.Forms.Label();
            this.button_sc_cross_speed_up = new System.Windows.Forms.Button();
            this.label_sc_rewind = new System.Windows.Forms.Label();
            this.button_sc_cross_speed_down = new System.Windows.Forms.Button();
            this.textBox_sc_speed_down = new System.Windows.Forms.TextBox();
            this.label_sc_auto = new System.Windows.Forms.Label();
            this.label_sc_loop = new System.Windows.Forms.Label();
            this.label_sc_next = new System.Windows.Forms.Label();
            this.label_sc_forward = new System.Windows.Forms.Label();
            this.label_sc_start_stop = new System.Windows.Forms.Label();
            this.button_sc_cross_prev = new System.Windows.Forms.Button();
            this.textBox_sc_prev = new System.Windows.Forms.TextBox();
            this.button_sc_cross_rewind = new System.Windows.Forms.Button();
            this.textBox_sc_rewind = new System.Windows.Forms.TextBox();
            this.button_sc_cross_start_stop = new System.Windows.Forms.Button();
            this.textBox_sc_start_stop = new System.Windows.Forms.TextBox();
            this.button_sc_cross_forward = new System.Windows.Forms.Button();
            this.textBox_sc_forward = new System.Windows.Forms.TextBox();
            this.button_sc_cross_next = new System.Windows.Forms.Button();
            this.textBox_sc_next = new System.Windows.Forms.TextBox();
            this.button_sc_cross_loop = new System.Windows.Forms.Button();
            this.textBox_sc_loop = new System.Windows.Forms.TextBox();
            this.button_sc_cross_auto = new System.Windows.Forms.Button();
            this.textBox_sc_auto = new System.Windows.Forms.TextBox();
            this.textBox_sc_speed_up = new System.Windows.Forms.TextBox();
            this.label_opacity = new System.Windows.Forms.Label();
            this.trackBar_opacity = new System.Windows.Forms.TrackBar();
            this.label_filepath = new System.Windows.Forms.Label();
            this.button_filepath = new System.Windows.Forms.Button();
            this.label_mp3dir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_rewind
            // 
            this.label_rewind.AutoSize = true;
            this.label_rewind.Location = new System.Drawing.Point(118, 22);
            this.label_rewind.Name = "label_rewind";
            this.label_rewind.Size = new System.Drawing.Size(49, 13);
            this.label_rewind.TabIndex = 0;
            this.label_rewind.Tag = "";
            this.label_rewind.Text = "Rewind: ";
            // 
            // rewind_sec
            // 
            this.rewind_sec.Location = new System.Drawing.Point(230, 19);
            this.rewind_sec.Name = "rewind_sec";
            this.rewind_sec.Size = new System.Drawing.Size(32, 20);
            this.rewind_sec.TabIndex = 1;
            this.rewind_sec.TabStop = false;
            this.rewind_sec.Tag = "";
            this.rewind_sec.Text = "5";
            this.rewind_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rewind_sec.TextChanged += new System.EventHandler(this.Application_TextChanged);
            // 
            // label_sec1
            // 
            this.label_sec1.AutoSize = true;
            this.label_sec1.Location = new System.Drawing.Point(268, 22);
            this.label_sec1.Name = "label_sec1";
            this.label_sec1.Size = new System.Drawing.Size(24, 13);
            this.label_sec1.TabIndex = 2;
            this.label_sec1.Tag = "";
            this.label_sec1.Text = "sec";
            this.label_sec1.Click += new System.EventHandler(this.Label_sec1_Click);
            // 
            // label_sec2
            // 
            this.label_sec2.AutoSize = true;
            this.label_sec2.Location = new System.Drawing.Point(268, 48);
            this.label_sec2.Name = "label_sec2";
            this.label_sec2.Size = new System.Drawing.Size(24, 13);
            this.label_sec2.TabIndex = 5;
            this.label_sec2.Tag = "";
            this.label_sec2.Text = "sec";
            this.label_sec2.Click += new System.EventHandler(this.Label_sec2_Click);
            // 
            // forward_sec
            // 
            this.forward_sec.Location = new System.Drawing.Point(230, 45);
            this.forward_sec.Name = "forward_sec";
            this.forward_sec.Size = new System.Drawing.Size(32, 20);
            this.forward_sec.TabIndex = 4;
            this.forward_sec.TabStop = false;
            this.forward_sec.Tag = "";
            this.forward_sec.Text = "5";
            this.forward_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.forward_sec.TextChanged += new System.EventHandler(this.Application_TextChanged);
            // 
            // label_forward
            // 
            this.label_forward.AutoSize = true;
            this.label_forward.Location = new System.Drawing.Point(118, 48);
            this.label_forward.Name = "label_forward";
            this.label_forward.Size = new System.Drawing.Size(71, 13);
            this.label_forward.TabIndex = 3;
            this.label_forward.Tag = "";
            this.label_forward.Text = "Fast forward: ";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(184, 257);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(128, 32);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(230, 229);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(82, 22);
            this.button_default.TabIndex = 7;
            this.button_default.TabStop = false;
            this.button_default.Tag = "";
            this.button_default.Text = "Default";
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // button_application
            // 
            this.button_application.BackColor = System.Drawing.Color.Transparent;
            this.button_application.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_application.FlatAppearance.BorderSize = 0;
            this.button_application.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_application.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_application.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_application.Location = new System.Drawing.Point(6, 12);
            this.button_application.Name = "button_application";
            this.button_application.Size = new System.Drawing.Size(85, 27);
            this.button_application.TabIndex = 8;
            this.button_application.Text = "Application";
            this.button_application.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_application.UseVisualStyleBackColor = false;
            this.button_application.Click += new System.EventHandler(this.Button_application_Click);
            // 
            // button_shortcuts
            // 
            this.button_shortcuts.BackColor = System.Drawing.Color.Transparent;
            this.button_shortcuts.FlatAppearance.BorderSize = 0;
            this.button_shortcuts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_shortcuts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_shortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shortcuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_shortcuts.Location = new System.Drawing.Point(6, 41);
            this.button_shortcuts.Name = "button_shortcuts";
            this.button_shortcuts.Size = new System.Drawing.Size(85, 27);
            this.button_shortcuts.TabIndex = 9;
            this.button_shortcuts.Text = "Shortcuts";
            this.button_shortcuts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_shortcuts.UseVisualStyleBackColor = false;
            this.button_shortcuts.Click += new System.EventHandler(this.Button_shortcuts_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_about.Location = new System.Drawing.Point(6, 70);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(85, 27);
            this.button_about.TabIndex = 10;
            this.button_about.Text = "About";
            this.button_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.Button_about_Click);
            // 
            // picture_icon
            // 
            this.picture_icon.Image = ((System.Drawing.Image)(resources.GetObject("picture_icon.Image")));
            this.picture_icon.Location = new System.Drawing.Point(121, 12);
            this.picture_icon.Name = "picture_icon";
            this.picture_icon.Size = new System.Drawing.Size(32, 33);
            this.picture_icon.TabIndex = 11;
            this.picture_icon.TabStop = false;
            // 
            // label_name_short
            // 
            this.label_name_short.AutoSize = true;
            this.label_name_short.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_name_short.Location = new System.Drawing.Point(159, 16);
            this.label_name_short.Name = "label_name_short";
            this.label_name_short.Size = new System.Drawing.Size(34, 24);
            this.label_name_short.TabIndex = 12;
            this.label_name_short.Text = "zlp";
            // 
            // label_name_full
            // 
            this.label_name_full.AutoSize = true;
            this.label_name_full.Location = new System.Drawing.Point(118, 48);
            this.label_name_full.Name = "label_name_full";
            this.label_name_full.Size = new System.Drawing.Size(123, 13);
            this.label_name_full.TabIndex = 13;
            this.label_name_full.Text = "Zerodori Listening Player";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(118, 63);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(72, 13);
            this.label_version.TabIndex = 14;
            this.label_version.Text = "Version: 0.0.1";
            // 
            // label_license
            // 
            this.label_license.AutoSize = true;
            this.label_license.Location = new System.Drawing.Point(118, 116);
            this.label_license.Name = "label_license";
            this.label_license.Size = new System.Drawing.Size(47, 13);
            this.label_license.TabIndex = 15;
            this.label_license.Text = "License:";
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(118, 132);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(71, 13);
            this.label_source.TabIndex = 16;
            this.label_source.Text = "Source code:";
            // 
            // linkLabel_license
            // 
            this.linkLabel_license.AutoSize = true;
            this.linkLabel_license.Location = new System.Drawing.Point(187, 116);
            this.linkLabel_license.Name = "linkLabel_license";
            this.linkLabel_license.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_license.TabIndex = 17;
            this.linkLabel_license.TabStop = true;
            this.linkLabel_license.Text = "MIT";
            this.linkLabel_license.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_license_LinkClicked);
            // 
            // linkLabel_source
            // 
            this.linkLabel_source.AutoSize = true;
            this.linkLabel_source.Location = new System.Drawing.Point(187, 131);
            this.linkLabel_source.Name = "linkLabel_source";
            this.linkLabel_source.Size = new System.Drawing.Size(114, 13);
            this.linkLabel_source.TabIndex = 18;
            this.linkLabel_source.TabStop = true;
            this.linkLabel_source.Text = "github.com/yorimoi/zlp";
            this.linkLabel_source.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_source_LinkClicked);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(118, 78);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(69, 13);
            this.label_author.TabIndex = 19;
            this.label_author.Text = "Author: kmgy";
            // 
            // label_sc_speed_up
            // 
            this.label_sc_speed_up.AutoSize = true;
            this.label_sc_speed_up.BackColor = System.Drawing.SystemColors.Control;
            this.label_sc_speed_up.Location = new System.Drawing.Point(118, 21);
            this.label_sc_speed_up.Name = "label_sc_speed_up";
            this.label_sc_speed_up.Size = new System.Drawing.Size(56, 13);
            this.label_sc_speed_up.TabIndex = 20;
            this.label_sc_speed_up.Text = "Speed up:";
            // 
            // label_sc_speed_down
            // 
            this.label_sc_speed_down.AutoSize = true;
            this.label_sc_speed_down.Location = new System.Drawing.Point(118, 44);
            this.label_sc_speed_down.Name = "label_sc_speed_down";
            this.label_sc_speed_down.Size = new System.Drawing.Size(70, 13);
            this.label_sc_speed_down.TabIndex = 21;
            this.label_sc_speed_down.Text = "Speed down:";
            // 
            // label_sc_prev
            // 
            this.label_sc_prev.AutoSize = true;
            this.label_sc_prev.Location = new System.Drawing.Point(118, 67);
            this.label_sc_prev.Name = "label_sc_prev";
            this.label_sc_prev.Size = new System.Drawing.Size(32, 13);
            this.label_sc_prev.TabIndex = 22;
            this.label_sc_prev.Text = "Prev:";
            // 
            // button_sc_cross_speed_up
            // 
            this.button_sc_cross_speed_up.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_speed_up.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_speed_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_speed_up.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_speed_up.Image")));
            this.button_sc_cross_speed_up.Location = new System.Drawing.Point(293, 20);
            this.button_sc_cross_speed_up.Name = "button_sc_cross_speed_up";
            this.button_sc_cross_speed_up.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_speed_up.TabIndex = 24;
            this.button_sc_cross_speed_up.TabStop = false;
            this.button_sc_cross_speed_up.UseVisualStyleBackColor = false;
            this.button_sc_cross_speed_up.Click += new System.EventHandler(this.Button_sc_cross_speed_up_Click);
            // 
            // label_sc_rewind
            // 
            this.label_sc_rewind.AutoSize = true;
            this.label_sc_rewind.Location = new System.Drawing.Point(118, 90);
            this.label_sc_rewind.Name = "label_sc_rewind";
            this.label_sc_rewind.Size = new System.Drawing.Size(46, 13);
            this.label_sc_rewind.TabIndex = 25;
            this.label_sc_rewind.Text = "Rewind:";
            // 
            // button_sc_cross_speed_down
            // 
            this.button_sc_cross_speed_down.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_speed_down.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_speed_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_speed_down.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_speed_down.Image")));
            this.button_sc_cross_speed_down.Location = new System.Drawing.Point(293, 43);
            this.button_sc_cross_speed_down.Name = "button_sc_cross_speed_down";
            this.button_sc_cross_speed_down.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_speed_down.TabIndex = 27;
            this.button_sc_cross_speed_down.TabStop = false;
            this.button_sc_cross_speed_down.UseVisualStyleBackColor = false;
            this.button_sc_cross_speed_down.Click += new System.EventHandler(this.Button_sc_cross_speed_down_Click);
            // 
            // textBox_sc_speed_down
            // 
            this.textBox_sc_speed_down.BackColor = System.Drawing.Color.White;
            this.textBox_sc_speed_down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_speed_down.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_speed_down.Location = new System.Drawing.Point(230, 42);
            this.textBox_sc_speed_down.Name = "textBox_sc_speed_down";
            this.textBox_sc_speed_down.ReadOnly = true;
            this.textBox_sc_speed_down.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_speed_down.TabIndex = 26;
            this.textBox_sc_speed_down.TabStop = false;
            this.textBox_sc_speed_down.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_speed_down.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_speed_down.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // label_sc_auto
            // 
            this.label_sc_auto.AutoSize = true;
            this.label_sc_auto.Location = new System.Drawing.Point(118, 205);
            this.label_sc_auto.Name = "label_sc_auto";
            this.label_sc_auto.Size = new System.Drawing.Size(32, 13);
            this.label_sc_auto.TabIndex = 29;
            this.label_sc_auto.Text = "Auto:";
            // 
            // label_sc_loop
            // 
            this.label_sc_loop.AutoSize = true;
            this.label_sc_loop.Location = new System.Drawing.Point(118, 182);
            this.label_sc_loop.Name = "label_sc_loop";
            this.label_sc_loop.Size = new System.Drawing.Size(34, 13);
            this.label_sc_loop.TabIndex = 30;
            this.label_sc_loop.Text = "Loop:";
            // 
            // label_sc_next
            // 
            this.label_sc_next.AutoSize = true;
            this.label_sc_next.Location = new System.Drawing.Point(118, 159);
            this.label_sc_next.Name = "label_sc_next";
            this.label_sc_next.Size = new System.Drawing.Size(32, 13);
            this.label_sc_next.TabIndex = 31;
            this.label_sc_next.Text = "Next:";
            // 
            // label_sc_forward
            // 
            this.label_sc_forward.AutoSize = true;
            this.label_sc_forward.Location = new System.Drawing.Point(118, 136);
            this.label_sc_forward.Name = "label_sc_forward";
            this.label_sc_forward.Size = new System.Drawing.Size(48, 13);
            this.label_sc_forward.TabIndex = 32;
            this.label_sc_forward.Text = "Forward:";
            // 
            // label_sc_start_stop
            // 
            this.label_sc_start_stop.AutoSize = true;
            this.label_sc_start_stop.Location = new System.Drawing.Point(118, 113);
            this.label_sc_start_stop.Name = "label_sc_start_stop";
            this.label_sc_start_stop.Size = new System.Drawing.Size(59, 13);
            this.label_sc_start_stop.TabIndex = 33;
            this.label_sc_start_stop.Text = "Start/Stop:";
            // 
            // button_sc_cross_prev
            // 
            this.button_sc_cross_prev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_prev.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_prev.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_prev.Image")));
            this.button_sc_cross_prev.Location = new System.Drawing.Point(293, 66);
            this.button_sc_cross_prev.Name = "button_sc_cross_prev";
            this.button_sc_cross_prev.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_prev.TabIndex = 35;
            this.button_sc_cross_prev.TabStop = false;
            this.button_sc_cross_prev.UseVisualStyleBackColor = false;
            this.button_sc_cross_prev.Click += new System.EventHandler(this.Button_sc_cross_prev_Click);
            // 
            // textBox_sc_prev
            // 
            this.textBox_sc_prev.BackColor = System.Drawing.Color.White;
            this.textBox_sc_prev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_prev.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_prev.Location = new System.Drawing.Point(230, 65);
            this.textBox_sc_prev.Name = "textBox_sc_prev";
            this.textBox_sc_prev.ReadOnly = true;
            this.textBox_sc_prev.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_prev.TabIndex = 34;
            this.textBox_sc_prev.TabStop = false;
            this.textBox_sc_prev.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_prev.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_prev.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_rewind
            // 
            this.button_sc_cross_rewind.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_rewind.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_rewind.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_rewind.Image")));
            this.button_sc_cross_rewind.Location = new System.Drawing.Point(293, 89);
            this.button_sc_cross_rewind.Name = "button_sc_cross_rewind";
            this.button_sc_cross_rewind.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_rewind.TabIndex = 37;
            this.button_sc_cross_rewind.TabStop = false;
            this.button_sc_cross_rewind.UseVisualStyleBackColor = false;
            this.button_sc_cross_rewind.Click += new System.EventHandler(this.Button_sc_cross_rewind_Click);
            // 
            // textBox_sc_rewind
            // 
            this.textBox_sc_rewind.BackColor = System.Drawing.Color.White;
            this.textBox_sc_rewind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_rewind.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_rewind.Location = new System.Drawing.Point(230, 88);
            this.textBox_sc_rewind.Name = "textBox_sc_rewind";
            this.textBox_sc_rewind.ReadOnly = true;
            this.textBox_sc_rewind.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_rewind.TabIndex = 36;
            this.textBox_sc_rewind.TabStop = false;
            this.textBox_sc_rewind.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_rewind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_rewind.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_start_stop
            // 
            this.button_sc_cross_start_stop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_start_stop.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_start_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_start_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_start_stop.Image")));
            this.button_sc_cross_start_stop.Location = new System.Drawing.Point(293, 112);
            this.button_sc_cross_start_stop.Name = "button_sc_cross_start_stop";
            this.button_sc_cross_start_stop.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_start_stop.TabIndex = 39;
            this.button_sc_cross_start_stop.TabStop = false;
            this.button_sc_cross_start_stop.UseVisualStyleBackColor = false;
            this.button_sc_cross_start_stop.Click += new System.EventHandler(this.Button_sc_cross_start_stop_Click);
            // 
            // textBox_sc_start_stop
            // 
            this.textBox_sc_start_stop.BackColor = System.Drawing.Color.White;
            this.textBox_sc_start_stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_start_stop.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_start_stop.Location = new System.Drawing.Point(230, 111);
            this.textBox_sc_start_stop.Name = "textBox_sc_start_stop";
            this.textBox_sc_start_stop.ReadOnly = true;
            this.textBox_sc_start_stop.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_start_stop.TabIndex = 38;
            this.textBox_sc_start_stop.TabStop = false;
            this.textBox_sc_start_stop.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_start_stop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_start_stop.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_forward
            // 
            this.button_sc_cross_forward.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_forward.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_forward.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_forward.Image")));
            this.button_sc_cross_forward.Location = new System.Drawing.Point(293, 135);
            this.button_sc_cross_forward.Name = "button_sc_cross_forward";
            this.button_sc_cross_forward.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_forward.TabIndex = 41;
            this.button_sc_cross_forward.TabStop = false;
            this.button_sc_cross_forward.UseVisualStyleBackColor = false;
            this.button_sc_cross_forward.Click += new System.EventHandler(this.Button_sc_cross_forward_Click);
            // 
            // textBox_sc_forward
            // 
            this.textBox_sc_forward.BackColor = System.Drawing.Color.White;
            this.textBox_sc_forward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_forward.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_forward.Location = new System.Drawing.Point(230, 134);
            this.textBox_sc_forward.Name = "textBox_sc_forward";
            this.textBox_sc_forward.ReadOnly = true;
            this.textBox_sc_forward.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_forward.TabIndex = 40;
            this.textBox_sc_forward.TabStop = false;
            this.textBox_sc_forward.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_forward.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_forward.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_next
            // 
            this.button_sc_cross_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_next.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_next.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_next.Image")));
            this.button_sc_cross_next.Location = new System.Drawing.Point(293, 158);
            this.button_sc_cross_next.Name = "button_sc_cross_next";
            this.button_sc_cross_next.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_next.TabIndex = 43;
            this.button_sc_cross_next.TabStop = false;
            this.button_sc_cross_next.UseVisualStyleBackColor = false;
            this.button_sc_cross_next.Click += new System.EventHandler(this.Button_sc_cross_next_Click);
            // 
            // textBox_sc_next
            // 
            this.textBox_sc_next.BackColor = System.Drawing.Color.White;
            this.textBox_sc_next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_next.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_next.Location = new System.Drawing.Point(230, 157);
            this.textBox_sc_next.Name = "textBox_sc_next";
            this.textBox_sc_next.ReadOnly = true;
            this.textBox_sc_next.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_next.TabIndex = 42;
            this.textBox_sc_next.TabStop = false;
            this.textBox_sc_next.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_next.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_next.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_loop
            // 
            this.button_sc_cross_loop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_loop.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_loop.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_loop.Image")));
            this.button_sc_cross_loop.Location = new System.Drawing.Point(293, 181);
            this.button_sc_cross_loop.Name = "button_sc_cross_loop";
            this.button_sc_cross_loop.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_loop.TabIndex = 45;
            this.button_sc_cross_loop.TabStop = false;
            this.button_sc_cross_loop.UseVisualStyleBackColor = false;
            this.button_sc_cross_loop.Click += new System.EventHandler(this.Button_sc_cross_loop_Click);
            // 
            // textBox_sc_loop
            // 
            this.textBox_sc_loop.BackColor = System.Drawing.Color.White;
            this.textBox_sc_loop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_loop.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_loop.Location = new System.Drawing.Point(230, 180);
            this.textBox_sc_loop.Name = "textBox_sc_loop";
            this.textBox_sc_loop.ReadOnly = true;
            this.textBox_sc_loop.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_loop.TabIndex = 44;
            this.textBox_sc_loop.TabStop = false;
            this.textBox_sc_loop.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_loop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_loop.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // button_sc_cross_auto
            // 
            this.button_sc_cross_auto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_sc_cross_auto.FlatAppearance.BorderSize = 0;
            this.button_sc_cross_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sc_cross_auto.Image = ((System.Drawing.Image)(resources.GetObject("button_sc_cross_auto.Image")));
            this.button_sc_cross_auto.Location = new System.Drawing.Point(293, 204);
            this.button_sc_cross_auto.Name = "button_sc_cross_auto";
            this.button_sc_cross_auto.Size = new System.Drawing.Size(18, 18);
            this.button_sc_cross_auto.TabIndex = 47;
            this.button_sc_cross_auto.TabStop = false;
            this.button_sc_cross_auto.UseVisualStyleBackColor = false;
            this.button_sc_cross_auto.Click += new System.EventHandler(this.Button_sc_cross_auto_Click);
            // 
            // textBox_sc_auto
            // 
            this.textBox_sc_auto.BackColor = System.Drawing.Color.White;
            this.textBox_sc_auto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_auto.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_auto.Location = new System.Drawing.Point(230, 203);
            this.textBox_sc_auto.Name = "textBox_sc_auto";
            this.textBox_sc_auto.ReadOnly = true;
            this.textBox_sc_auto.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_auto.TabIndex = 46;
            this.textBox_sc_auto.TabStop = false;
            this.textBox_sc_auto.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_auto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_auto.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // textBox_sc_speed_up
            // 
            this.textBox_sc_speed_up.BackColor = System.Drawing.Color.White;
            this.textBox_sc_speed_up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sc_speed_up.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sc_speed_up.Location = new System.Drawing.Point(230, 19);
            this.textBox_sc_speed_up.Name = "textBox_sc_speed_up";
            this.textBox_sc_speed_up.ReadOnly = true;
            this.textBox_sc_speed_up.Size = new System.Drawing.Size(82, 20);
            this.textBox_sc_speed_up.TabIndex = 48;
            this.textBox_sc_speed_up.TabStop = false;
            this.textBox_sc_speed_up.Enter += new System.EventHandler(this.TextBox_sc_Enter);
            this.textBox_sc_speed_up.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_sc_KeyUp);
            this.textBox_sc_speed_up.Leave += new System.EventHandler(this.TextBox_sc_Leave);
            // 
            // label_opacity
            // 
            this.label_opacity.AutoSize = true;
            this.label_opacity.Location = new System.Drawing.Point(118, 74);
            this.label_opacity.Name = "label_opacity";
            this.label_opacity.Size = new System.Drawing.Size(46, 13);
            this.label_opacity.TabIndex = 49;
            this.label_opacity.Text = "Opacity:";
            // 
            // trackBar_opacity
            // 
            this.trackBar_opacity.Location = new System.Drawing.Point(222, 71);
            this.trackBar_opacity.Maximum = 100;
            this.trackBar_opacity.Name = "trackBar_opacity";
            this.trackBar_opacity.Size = new System.Drawing.Size(90, 45);
            this.trackBar_opacity.TabIndex = 10;
            this.trackBar_opacity.TabStop = false;
            this.trackBar_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_opacity.ValueChanged += new System.EventHandler(this.Application_TextChanged);
            // 
            // label_filepath
            // 
            this.label_filepath.AutoSize = true;
            this.label_filepath.Location = new System.Drawing.Point(118, 100);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Size = new System.Drawing.Size(47, 13);
            this.label_filepath.TabIndex = 50;
            this.label_filepath.Text = "File path";
            // 
            // button_filepath
            // 
            this.button_filepath.Location = new System.Drawing.Point(284, 114);
            this.button_filepath.Name = "button_filepath";
            this.button_filepath.Size = new System.Drawing.Size(28, 20);
            this.button_filepath.TabIndex = 52;
            this.button_filepath.TabStop = false;
            this.button_filepath.Text = "...";
            this.button_filepath.UseVisualStyleBackColor = true;
            this.button_filepath.Click += new System.EventHandler(this.Button_filepath_Click);
            // 
            // label_mp3dir
            // 
            this.label_mp3dir.Location = new System.Drawing.Point(141, 114);
            this.label_mp3dir.Name = "label_mp3dir";
            this.label_mp3dir.Size = new System.Drawing.Size(137, 20);
            this.label_mp3dir.TabIndex = 53;
            this.label_mp3dir.TabStop = false;
            this.label_mp3dir.TextChanged += new System.EventHandler(this.Label_mp3dir_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 297);
            this.Controls.Add(this.label_mp3dir);
            this.Controls.Add(this.button_filepath);
            this.Controls.Add(this.label_filepath);
            this.Controls.Add(this.trackBar_opacity);
            this.Controls.Add(this.label_opacity);
            this.Controls.Add(this.button_sc_cross_speed_up);
            this.Controls.Add(this.textBox_sc_speed_up);
            this.Controls.Add(this.button_sc_cross_auto);
            this.Controls.Add(this.textBox_sc_auto);
            this.Controls.Add(this.button_sc_cross_loop);
            this.Controls.Add(this.textBox_sc_loop);
            this.Controls.Add(this.button_sc_cross_next);
            this.Controls.Add(this.textBox_sc_next);
            this.Controls.Add(this.button_sc_cross_forward);
            this.Controls.Add(this.textBox_sc_forward);
            this.Controls.Add(this.button_sc_cross_start_stop);
            this.Controls.Add(this.textBox_sc_start_stop);
            this.Controls.Add(this.button_sc_cross_rewind);
            this.Controls.Add(this.textBox_sc_rewind);
            this.Controls.Add(this.button_sc_cross_prev);
            this.Controls.Add(this.textBox_sc_prev);
            this.Controls.Add(this.label_sc_start_stop);
            this.Controls.Add(this.label_sc_forward);
            this.Controls.Add(this.label_sc_next);
            this.Controls.Add(this.label_sc_loop);
            this.Controls.Add(this.label_sc_auto);
            this.Controls.Add(this.button_sc_cross_speed_down);
            this.Controls.Add(this.textBox_sc_speed_down);
            this.Controls.Add(this.label_sc_rewind);
            this.Controls.Add(this.label_sc_prev);
            this.Controls.Add(this.label_sc_speed_down);
            this.Controls.Add(this.label_sc_speed_up);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.linkLabel_source);
            this.Controls.Add(this.linkLabel_license);
            this.Controls.Add(this.label_source);
            this.Controls.Add(this.label_license);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_name_full);
            this.Controls.Add(this.label_name_short);
            this.Controls.Add(this.picture_icon);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_shortcuts);
            this.Controls.Add(this.button_application);
            this.Controls.Add(this.button_default);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.label_sec2);
            this.Controls.Add(this.forward_sec);
            this.Controls.Add(this.label_forward);
            this.Controls.Add(this.label_sec1);
            this.Controls.Add(this.rewind_sec);
            this.Controls.Add(this.label_rewind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "zlp - Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rewind;
        private System.Windows.Forms.TextBox rewind_sec;
        private System.Windows.Forms.Label label_sec1;
        private System.Windows.Forms.Label label_sec2;
        private System.Windows.Forms.TextBox forward_sec;
        private System.Windows.Forms.Label label_forward;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_default;
        private System.Windows.Forms.Button button_application;
        private System.Windows.Forms.Button button_shortcuts;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.PictureBox picture_icon;
        private System.Windows.Forms.Label label_name_short;
        private System.Windows.Forms.Label label_name_full;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_license;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.LinkLabel linkLabel_license;
        private System.Windows.Forms.LinkLabel linkLabel_source;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_sc_speed_up;
        private System.Windows.Forms.Label label_sc_speed_down;
        private System.Windows.Forms.Label label_sc_prev;
        private System.Windows.Forms.Button button_sc_cross_speed_up;
        private System.Windows.Forms.Label label_sc_rewind;
        private System.Windows.Forms.Button button_sc_cross_speed_down;
        private System.Windows.Forms.TextBox textBox_sc_speed_down;
        private System.Windows.Forms.Label label_sc_auto;
        private System.Windows.Forms.Label label_sc_loop;
        private System.Windows.Forms.Label label_sc_next;
        private System.Windows.Forms.Label label_sc_forward;
        private System.Windows.Forms.Label label_sc_start_stop;
        private System.Windows.Forms.Button button_sc_cross_prev;
        private System.Windows.Forms.TextBox textBox_sc_prev;
        private System.Windows.Forms.Button button_sc_cross_rewind;
        private System.Windows.Forms.TextBox textBox_sc_rewind;
        private System.Windows.Forms.Button button_sc_cross_start_stop;
        private System.Windows.Forms.TextBox textBox_sc_start_stop;
        private System.Windows.Forms.Button button_sc_cross_forward;
        private System.Windows.Forms.TextBox textBox_sc_forward;
        private System.Windows.Forms.Button button_sc_cross_next;
        private System.Windows.Forms.TextBox textBox_sc_next;
        private System.Windows.Forms.Button button_sc_cross_loop;
        private System.Windows.Forms.TextBox textBox_sc_loop;
        private System.Windows.Forms.Button button_sc_cross_auto;
        private System.Windows.Forms.TextBox textBox_sc_auto;
        private System.Windows.Forms.TextBox textBox_sc_speed_up;
        private System.Windows.Forms.Label label_opacity;
        private System.Windows.Forms.TrackBar trackBar_opacity;
        private System.Windows.Forms.Label label_filepath;
        private System.Windows.Forms.Button button_filepath;
        private System.Windows.Forms.TextBox label_mp3dir;
    }
}