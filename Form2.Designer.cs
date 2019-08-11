namespace zerodori_listening_player
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
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_rewind
            // 
            this.label_rewind.AutoSize = true;
            this.label_rewind.Location = new System.Drawing.Point(121, 22);
            this.label_rewind.Name = "label_rewind";
            this.label_rewind.Size = new System.Drawing.Size(94, 13);
            this.label_rewind.TabIndex = 0;
            this.label_rewind.Tag = "";
            this.label_rewind.Text = "Rewind (巻き戻し)";
            // 
            // rewind_sec
            // 
            this.rewind_sec.Location = new System.Drawing.Point(236, 19);
            this.rewind_sec.Name = "rewind_sec";
            this.rewind_sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewind_sec.Size = new System.Drawing.Size(32, 20);
            this.rewind_sec.TabIndex = 1;
            this.rewind_sec.Tag = "";
            this.rewind_sec.Text = "5";
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
            // 
            // forward_sec
            // 
            this.forward_sec.Location = new System.Drawing.Point(236, 45);
            this.forward_sec.Name = "forward_sec";
            this.forward_sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.forward_sec.Size = new System.Drawing.Size(32, 20);
            this.forward_sec.TabIndex = 4;
            this.forward_sec.Tag = "";
            this.forward_sec.Text = "5";
            // 
            // label_forward
            // 
            this.label_forward.AutoSize = true;
            this.label_forward.Location = new System.Drawing.Point(121, 48);
            this.label_forward.Name = "label_forward";
            this.label_forward.Size = new System.Drawing.Size(106, 13);
            this.label_forward.TabIndex = 3;
            this.label_forward.Tag = "";
            this.label_forward.Text = "Fast forward (早送り)";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(184, 173);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(128, 32);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(236, 71);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(64, 22);
            this.button_default.TabIndex = 7;
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
            this.button_application.Location = new System.Drawing.Point(12, 12);
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
            this.button_shortcuts.Location = new System.Drawing.Point(12, 41);
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
            this.button_about.Location = new System.Drawing.Point(12, 70);
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
            this.label_license.Location = new System.Drawing.Point(118, 103);
            this.label_license.Name = "label_license";
            this.label_license.Size = new System.Drawing.Size(47, 13);
            this.label_license.TabIndex = 15;
            this.label_license.Text = "License:";
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(118, 126);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(71, 13);
            this.label_source.TabIndex = 16;
            this.label_source.Text = "Source code:";
            // 
            // linkLabel_license
            // 
            this.linkLabel_license.AutoSize = true;
            this.linkLabel_license.LinkVisited = true;
            this.linkLabel_license.Location = new System.Drawing.Point(187, 103);
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
            this.linkLabel_source.Location = new System.Drawing.Point(187, 125);
            this.linkLabel_source.Name = "linkLabel_source";
            this.linkLabel_source.Size = new System.Drawing.Size(114, 13);
            this.linkLabel_source.TabIndex = 18;
            this.linkLabel_source.TabStop = true;
            this.linkLabel_source.Text = "github.com/yorimoi/zlp";
            this.linkLabel_source.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_source_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 217);
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
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).EndInit();
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
    }
}