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
            this.label1 = new System.Windows.Forms.Label();
            this.rewind_sec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forward_sec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_default = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rewind (巻き戻し)";
            // 
            // rewind_sec
            // 
            this.rewind_sec.Location = new System.Drawing.Point(128, 10);
            this.rewind_sec.Name = "rewind_sec";
            this.rewind_sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewind_sec.Size = new System.Drawing.Size(32, 20);
            this.rewind_sec.TabIndex = 1;
            this.rewind_sec.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sec";
            // 
            // forward_sec
            // 
            this.forward_sec.Location = new System.Drawing.Point(128, 36);
            this.forward_sec.Name = "forward_sec";
            this.forward_sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.forward_sec.Size = new System.Drawing.Size(32, 20);
            this.forward_sec.TabIndex = 4;
            this.forward_sec.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fast forward (早送り)";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(60, 101);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(128, 32);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(128, 62);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(64, 22);
            this.button_default.TabIndex = 7;
            this.button_default.Text = "Default";
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 149);
            this.Controls.Add(this.button_default);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forward_sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rewind_sec);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Setting";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rewind_sec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forward_sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_default;
    }
}