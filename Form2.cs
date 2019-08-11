using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace zerodori_listening_player
{
    public partial class Form2 : Form
    {

        Color lime = Color.FromArgb(128, 255, 128);
        Color none = Color.Transparent;

        public Form2()
        {
            InitializeComponent();
            rewind_sec.MaxLength  = 3;
            forward_sec.MaxLength = 3;

            // 初期画面はアプリケーション設定

            // 設定の読み込み
            rewind_sec.Text  = Form1.rewind_sec.ToString();
            forward_sec.Text = Form1.forward_sec.ToString();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button_application.PerformClick();
            // ↓だめ
            button_application.Focus();
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            rewind_sec.Text  = "5";
            forward_sec.Text = "5";
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (rewind_sec.Text == "")
                rewind_sec.Text = "5";
            if (forward_sec.Text == "")
                forward_sec.Text = "5";

            Form1.rewind_sec  = int.Parse(rewind_sec.Text);
            Form1.forward_sec = int.Parse(forward_sec.Text);

            if (Form1.rewind_sec < 0) {
                Form1.rewind_sec *= -1;
                rewind_sec.Text = Form1.rewind_sec.ToString();
            }
            if (Form1.forward_sec < 0) {
                Form1.forward_sec *= -1;
                forward_sec.Text = Form1.forward_sec.ToString();
            }
        }

        // 良いやり方が分からない
        // 継承フォーム?
        // getElementsByClassName("Application")みたいなことしたい
        private void Button_application_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            button_about.BackColor = none;
            button_shortcuts.BackColor = none;

            picture_icon.Visible =
            label_name_short.Visible =
            label_name_full.Visible =
            label_version.Visible =
            label_license.Visible =
            linkLabel_license.Visible =
            label_source.Visible =
            linkLabel_source.Visible = false;

            // Applicationの項目表示
            button_apply.Visible =
            label_forward.Visible =
            label_rewind.Visible =
            label_sec1.Visible =
            label_sec2.Visible =
            forward_sec.Visible =
            rewind_sec.Visible =
            button_default.Visible = true;

            // 選択中ボタン背景色の指定
            button_application.BackColor = lime;

        }

        private void Button_shortcuts_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            button_application.BackColor = none;
            button_about.BackColor = none;

            label_forward.Visible =
            label_rewind.Visible =
            label_sec1.Visible =
            label_sec2.Visible =
            forward_sec.Visible =
            rewind_sec.Visible =
            picture_icon.Visible =
            label_name_short.Visible =
            label_name_full.Visible =
            label_version.Visible =
            label_license.Visible =
            linkLabel_license.Visible =
            label_source.Visible =
            linkLabel_source.Visible =
            button_default.Visible = false;

            // Shortcutsの項目表示
            button_apply.Visible = true;

            // 選択中ボタン背景色の指定
            button_shortcuts.BackColor = lime;
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            button_application.BackColor = none;
            button_shortcuts.BackColor = none;

            button_apply.Visible =
            label_forward.Visible =
            label_rewind.Visible =
            label_sec1.Visible =
            label_sec2.Visible =
            forward_sec.Visible =
            rewind_sec.Visible =
            button_default.Visible = false;

            // Aboutの項目表示
            picture_icon.Visible =
            label_name_short.Visible =
            label_name_full.Visible =
            label_version.Visible =
            label_license.Visible =
            linkLabel_license.Visible =
            label_source.Visible =
            linkLabel_source.Visible = true;

            linkLabel_license.Text = "MIT";
            linkLabel_source.Text = "github.com/yorimoi/zlp";

            // 選択中ボタン背景色の指定
            button_about.BackColor = lime;
        }

        private void LinkLabel_license_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yorimoi/zlp/blob/master/LICENSE");
        }

        private void LinkLabel_source_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yorimoi/zlp");
        }
    }
}
