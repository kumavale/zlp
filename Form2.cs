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

        enum items {
            APPLICATION,
            SHORTCUTS,
            ABOUT
        }
        items current_item = items.APPLICATION;

        public Form2()
        {
            InitializeComponent();
            rewind_sec.MaxLength  = 3;
            forward_sec.MaxLength = 3;

            // 初期画面はアプリケーション設定

            // 設定の読み込み
            // Application
            rewind_sec.Text  = Form1.rewind_sec.ToString();
            forward_sec.Text = Form1.forward_sec.ToString();
            // Shortcuts
            textBox_sc_speed_up.Text = Form1.key_speed_up.ToString();
            textBox_sc_speed_down.Text = Form1.key_speed_down.ToString();
            textBox_sc_prev.Text = Form1.key_prev.ToString();
            textBox_sc_rewind.Text = Form1.key_rewind.ToString();
            textBox_sc_start_stop.Text = Form1.key_start_stop.ToString();
            textBox_sc_forward.Text = Form1.key_forward.ToString();
            textBox_sc_next.Text = Form1.key_next.ToString();
            textBox_sc_loop.Text = Form1.key_loop.ToString();
            textBox_sc_auto.Text = Form1.key_auto.ToString();
            // About
            linkLabel_license.Text = "MIT";
            linkLabel_source.Text = "github.com/yorimoi/zlp";

            // ボタンをマウスオーバー時のテキスト表示
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.SetToolTip(linkLabel_license, "https://github.com/yorimoi/zlp/blob/master/LICENSE");
            tt.SetToolTip(linkLabel_source, "https://github.com/yorimoi/zlp");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button_application.PerformClick();
            // ↓だめ
            button_application.Focus();
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            if (current_item == items.APPLICATION)
            {
                rewind_sec.Text  = "5";
                forward_sec.Text = "5";
            }
            else if (current_item == items.SHORTCUTS)
            {
                ;
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (current_item == items.APPLICATION)
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
            else if (current_item == items.SHORTCUTS)
            {
                ;
            }

        }

        private void Button_application_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            shortcuts_visible(false);
            about_visible(false);

            // Applicationの項目表示
            application_visible(true);
            set_backcolor(items.APPLICATION);
        }

        private void Button_shortcuts_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            application_visible(false);
            about_visible(false);

            // Shortcutsの項目表示
            shortcuts_visible(true);
            set_backcolor(items.SHORTCUTS);
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            application_visible(false);
            shortcuts_visible(false);

            // Aboutの項目表示
            about_visible(true);
            set_backcolor(items.ABOUT);
        }

        // 選択中ボタン背景色の指定
        private void set_backcolor(items i) {
            current_item = i;
            switch(i) {
                case items.APPLICATION:
                    button_application.BackColor = lime;
                    button_shortcuts.BackColor = none;
                    button_about.BackColor = none;
                    break;
                case items.SHORTCUTS:
                    button_application.BackColor = none;
                    button_shortcuts.BackColor = lime;
                    button_about.BackColor = none;
                    break;
                case items.ABOUT:
                    button_application.BackColor = none;
                    button_shortcuts.BackColor = none;
                    button_about.BackColor = lime;
                    break;
            }
        }

        private void LinkLabel_license_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yorimoi/zlp/blob/master/LICENSE");
        }

        private void LinkLabel_source_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yorimoi/zlp");
        }

        // Applicationの項目表示
        private void application_visible(bool v)
        {
            button_apply.Visible = v;
            label_forward.Visible =
            label_rewind.Visible =
            label_sec1.Visible =
            label_sec2.Visible =
            rewind_sec.Visible =
            forward_sec.Visible =
            button_default.Visible = v;
        }

        // Shortcutsの項目表示
        private void shortcuts_visible(bool v)
        {
            button_apply.Visible = v;
            label_sc_speed_up.Visible =
            label_sc_speed_down.Visible =
            label_sc_prev.Visible =
            label_sc_rewind.Visible =
            label_sc_start_stop.Visible =
            label_sc_forward.Visible =
            label_sc_next.Visible =
            label_sc_loop.Visible =
            label_sc_auto.Visible = v;
            textBox_sc_speed_up.Visible =
            textBox_sc_speed_down.Visible =
            textBox_sc_prev.Visible =
            textBox_sc_rewind.Visible =
            textBox_sc_start_stop.Visible =
            textBox_sc_forward.Visible =
            textBox_sc_next.Visible =
            textBox_sc_loop.Visible =
            textBox_sc_auto.Visible = v;
            button_sc_cross_speed_up.Visible =
            button_sc_cross_speed_down.Visible =
            button_sc_cross_prev.Visible =
            button_sc_cross_rewind.Visible =
            button_sc_cross_start_stop.Visible =
            button_sc_cross_forward.Visible =
            button_sc_cross_next.Visible =
            button_sc_cross_loop.Visible =
            button_sc_cross_auto.Visible = v;
        }

        // Aboutの項目表示
        private void about_visible(bool v)
        {
            picture_icon.Visible =
            label_name_short.Visible =
            label_name_full.Visible =
            label_version.Visible =
            label_author.Visible =
            label_license.Visible =
            linkLabel_license.Visible =
            label_source.Visible =
            linkLabel_source.Visible = v;
        }

        // ショートカットの有効キー確認
        private bool is_valid_key(char key)
        {
            if(
                ('A' <= key && key <= 'Z') ||
                ('0' <= key && key <= '9') ||
                (':' <= key && key <= '@') ||
                ('[' <= key && key <= '^') ||
                (17  <= key && key <= 20)  ||  // Space,PageUp,PageDown,End
                (27  <= key             )  ||  // Home
                (32  <= key && key <= 35)  ||  // Arrow keys
                (112 <= key && key <= 123)     // F1 - F12
               ){
                return true;
            }
            return false;
        }

        private void TextBox_sc_speed_up_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(is_valid_key(e.KeyChar)){
                e.Handled = true;
                Console.WriteLine("[" + e.KeyChar + "]");
            }
        }
    }
}
