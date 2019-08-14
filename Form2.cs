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
using System.Configuration;
using System.Runtime.InteropServices;

namespace zerodori_listening_player
{
    public partial class Form2 : Form
    {
        [DllImport("USER32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        readonly Color lime  = Color.FromArgb(128, 255, 128);
        readonly Color alice = Color.AliceBlue;
        readonly Color white = Color.White;
        readonly Color none  = Color.Transparent;

        Form1 f1;

        enum items {
            APPLICATION,
            SHORTCUTS,
            ABOUT
        }
        private items current_item;

        const string title = "zlp - Setting";
        const string changing_title = "*zlp - Setting";


        public Form2(Form1 form)
        {
            f1 = form;

            InitializeComponent();
            rewind_sec.MaxLength  = 3;
            forward_sec.MaxLength = 3;

            // 初期画面はアプリケーション設定
            current_item = items.APPLICATION;

            // 設定の読み込み
            // Application
            rewind_sec.Text  = Form1.rewind_sec.ToString();
            forward_sec.Text = Form1.forward_sec.ToString();
            trackBar_opacity.Value = (int)(f1.Opacity * 100);
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
            label_version.Text = "Version: " + ConfigurationManager.AppSettings["version"];
            label_author.Text = "Author: " + ConfigurationManager.AppSettings["authors"];
            linkLabel_license.Text = "MIT";
            linkLabel_source.Text = "github.com/yorimoi/zlp";

            // ボタンをマウスオーバー時のテキスト表示
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.SetToolTip(linkLabel_license, "https://github.com/yorimoi/zlp/blob/master/LICENSE");
            tt.SetToolTip(linkLabel_source, "https://github.com/yorimoi/zlp");

            // キャレットの削除
            textBox_sc_speed_up.GotFocus   += (s, e) => { HideCaret(textBox_sc_speed_up.Handle); };
            textBox_sc_speed_down.GotFocus += (s, e) => { HideCaret(textBox_sc_speed_down.Handle); };
            textBox_sc_prev.GotFocus       += (s, e) => { HideCaret(textBox_sc_prev.Handle); };
            textBox_sc_rewind.GotFocus     += (s, e) => { HideCaret(textBox_sc_rewind.Handle); };
            textBox_sc_start_stop.GotFocus += (s, e) => { HideCaret(textBox_sc_start_stop.Handle); };
            textBox_sc_forward.GotFocus    += (s, e) => { HideCaret(textBox_sc_forward.Handle); };
            textBox_sc_next.GotFocus       += (s, e) => { HideCaret(textBox_sc_next.Handle); };
            textBox_sc_loop.GotFocus       += (s, e) => { HideCaret(textBox_sc_loop.Handle); };
            textBox_sc_auto.GotFocus       += (s, e) => { HideCaret(textBox_sc_auto.Handle); };

            // KeysEnumと表示文字列の変換
            string[] textBoxes = {
                textBox_sc_speed_up.Text,
                textBox_sc_speed_down.Text,
                textBox_sc_prev.Text,
                textBox_sc_rewind.Text,
                textBox_sc_start_stop.Text,
                textBox_sc_forward.Text,
                textBox_sc_next.Text,
                textBox_sc_loop.Text,
                textBox_sc_auto.Text
            };

            for(int i=0; i<textBoxes.Length; ++i) {
                switch(textBoxes[i]) {
                    case "None":            textBoxes[i] = "";   break;
                    case "D0":              textBoxes[i] = "0";  break;
                    case "D1":              textBoxes[i] = "1";  break;
                    case "D2":              textBoxes[i] = "2";  break;
                    case "D3":              textBoxes[i] = "3";  break;
                    case "D4":              textBoxes[i] = "4";  break;
                    case "D5":              textBoxes[i] = "5";  break;
                    case "D6":              textBoxes[i] = "6";  break;
                    case "D7":              textBoxes[i] = "7";  break;
                    case "D8":              textBoxes[i] = "8";  break;
                    case "D9":              textBoxes[i] = "9";  break;
                    case "Oem1":            textBoxes[i] = ":";  break;
                    case "Oemplus":         textBoxes[i] = ";";  break;
                    case "Oemcomma":        textBoxes[i] = ",";  break;
                    case "OemMinus":        textBoxes[i] = "-";  break;
                    case "OemPeriod":       textBoxes[i] = ".";  break;
                    case "OemQuestion":     textBoxes[i] = "/";  break;
                    case "Oemtilde":        textBoxes[i] = "@";  break;
                    case "OemOpenBrackets": textBoxes[i] = "[";  break;
                    case "Oem5":            textBoxes[i] = "\\"; break;
                    case "Oem6":            textBoxes[i] = "]";  break;
                    case "Oem7":            textBoxes[i] = "^";  break;
                }
            }

            textBox_sc_speed_up.Text   = textBoxes[0];
            textBox_sc_speed_down.Text = textBoxes[1];
            textBox_sc_prev.Text       = textBoxes[2];
            textBox_sc_rewind.Text     = textBoxes[3];
            textBox_sc_start_stop.Text = textBoxes[4];
            textBox_sc_forward.Text    = textBoxes[5];
            textBox_sc_next.Text       = textBoxes[6];
            textBox_sc_loop.Text       = textBoxes[7];
            textBox_sc_auto.Text       = textBoxes[8];

            changed(false);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button_application.PerformClick();
        }

        private void changed(bool c)
        {
            if(c) {
                this.Text = changing_title;
            }
            else {
                this.Text = title;
            }
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            changed(true);

            if (current_item == items.APPLICATION)
            {
                rewind_sec.Text  = "5";
                forward_sec.Text = "5";
                trackBar_opacity.Value = 100;
            }
            else if (current_item == items.SHORTCUTS)
            {
                textBox_sc_speed_up.Text = "Up";
                textBox_sc_speed_down.Text = "Down";
                textBox_sc_prev.Text = "P";
                textBox_sc_rewind.Text = "Left";
                textBox_sc_start_stop.Text = "Space";
                textBox_sc_forward.Text = "Right";
                textBox_sc_next.Text = "N";
                textBox_sc_loop.Text = "L";
                textBox_sc_auto.Text = "A";
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            // Application
            if(int.TryParse(rewind_sec.Text,  out Form1.rewind_sec)  == false)
                rewind_sec.Text  = "5";
            if(int.TryParse(forward_sec.Text, out Form1.forward_sec) == false)
                forward_sec.Text = "5";

            if (Form1.rewind_sec < 0) {
                Form1.rewind_sec *= -1;
                rewind_sec.Text = Form1.rewind_sec.ToString();
            }
            if (Form1.forward_sec < 0) {
                Form1.forward_sec *= -1;
                forward_sec.Text = Form1.forward_sec.ToString();
            }

            f1.Opacity = trackBar_opacity.Value * 0.01;


            // Shortcuts
            string[] textBoxes = {
                textBox_sc_speed_up.Text,
                textBox_sc_speed_down.Text,
                textBox_sc_prev.Text,
                textBox_sc_rewind.Text,
                textBox_sc_start_stop.Text,
                textBox_sc_forward.Text,
                textBox_sc_next.Text,
                textBox_sc_loop.Text,
                textBox_sc_auto.Text
            };

            for(int i=0; i<textBoxes.Length; ++i) {
                switch(textBoxes[i]) {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":  textBoxes[i] = "D" + textBoxes[i]; break;
                    case ":":  textBoxes[i] = "Oem1"; break;
                    case ";":  textBoxes[i] = "Oemplus"; break;
                    case ",":  textBoxes[i] = "Oemcomma"; break;
                    case "-":  textBoxes[i] = "OemMinus"; break;
                    case ".":  textBoxes[i] = "OemPeriod"; break;
                    case "/":  textBoxes[i] = "OemQuestion"; break;
                    case "@":  textBoxes[i] = "Oemtilde"; break;
                    case "[":  textBoxes[i] = "OemOpenBrackets"; break;
                    case "\\": textBoxes[i] = "Oem5"; break;
                    case "]":  textBoxes[i] = "Oem6"; break;
                    case "^":  textBoxes[i] = "Oem7"; break;
                }
            }

            Enum.TryParse<Keys>(textBoxes[0], out Form1.key_speed_up);
            Enum.TryParse<Keys>(textBoxes[1], out Form1.key_speed_down);
            Enum.TryParse<Keys>(textBoxes[2], out Form1.key_prev);
            Enum.TryParse<Keys>(textBoxes[3], out Form1.key_rewind);
            Enum.TryParse<Keys>(textBoxes[4], out Form1.key_start_stop);
            Enum.TryParse<Keys>(textBoxes[5], out Form1.key_forward);
            Enum.TryParse<Keys>(textBoxes[6], out Form1.key_next);
            Enum.TryParse<Keys>(textBoxes[7], out Form1.key_loop);
            Enum.TryParse<Keys>(textBoxes[8], out Form1.key_auto);

            changed(false);
        }

        private void Button_application_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            shortcuts_visible(false);
            about_visible(false);

            // Applicationの項目表示
            button_apply.Visible =
            button_default.Visible = true;
            application_visible(true);
            set_backcolor(items.APPLICATION);
        }

        private void Button_shortcuts_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            application_visible(false);
            about_visible(false);

            // Shortcutsの項目表示
            button_apply.Visible =
            button_default.Visible = true;
            shortcuts_visible(true);
            set_backcolor(items.SHORTCUTS);
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            // 他の項目を全て非表示
            application_visible(false);
            shortcuts_visible(false);
            button_apply.Visible =
            button_default.Visible = false;

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
            label_forward.Visible =
            label_rewind.Visible =
            label_sec1.Visible =
            label_sec2.Visible =
            rewind_sec.Visible =
            forward_sec.Visible =
            label_opacity.Visible =
            trackBar_opacity.Visible = v;
        }

        // Shortcutsの項目表示
        private void shortcuts_visible(bool v)
        {
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
        private bool is_valid_key(int code)
        {
            if(
                ('A' <= code && code <= 'Z') ||
                ('0' <= code && code <= '9') ||
                (186 <= code && code <= 192) ||  // :;,-./@
                (219 <= code && code <= 222) ||  // [\]^
                (32  <= code && code <=  40) ||  // Space,PageUp,PageDown,End,Home,Arrow keys
                (112 <= code && code <= 123) ||  // F1 - F12
                (8   == code)                ||  // BackSpace
                (46  == code)                    // Delete
               ){
                return true;
            }
            return false;
        }

        private string keycode_to_value(Keys key)
        {
            int code = (int)key;
            if(
                ('A' <= code && code <= 'Z') ||
                ('0' <= code && code <= '9')
               ){
                return ((char)code).ToString();
            }
            if(
                (32  <= code && code <=  40) ||  // Space,PageUp,PageDown,End,Home,Arrow keys
                (112 <= code && code <= 123)     // F1 - F12
              ) {
                return key.ToString();
            }
            switch(code)
            {
                case   8:
                case  46: return "";
                case 186: return ":";
                case 187: return ";";
                case 188: return ",";
                case 189: return "-";
                case 190: return ".";
                case 191: return "/";
                case 192: return "@";
                case 219: return "[";
                case 220: return "\\";
                case 221: return "]";
                case 222: return "^";
            }
            return "";
        }

        private void TextBox_sc_KeyUp(object sender, KeyEventArgs e)
        {
            if(is_valid_key((int)e.KeyCode)){
                ((TextBox)sender).Text = keycode_to_value(e.KeyCode);
                changed(true);
            }
        }

        private void Button_sc_cross_speed_up_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_speed_up.Text = "";
            textBox_sc_speed_up.Focus();
        }

        private void Button_sc_cross_speed_down_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_speed_down.Text = "";
            textBox_sc_speed_down.Focus();
        }

        private void Button_sc_cross_prev_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_prev.Text = "";
            textBox_sc_prev.Focus();
        }

        private void Button_sc_cross_rewind_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_rewind.Text = "";
            textBox_sc_rewind.Focus();
        }

        private void Button_sc_cross_start_stop_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_start_stop.Text = "";
            textBox_sc_start_stop.Focus();
        }

        private void Button_sc_cross_forward_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_forward.Text = "";
            textBox_sc_forward.Focus();
        }

        private void Button_sc_cross_next_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_next.Text = "";
            textBox_sc_next.Focus();
        }

        private void Button_sc_cross_loop_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_loop.Text = "";
            textBox_sc_loop.Focus();
        }

        private void Button_sc_cross_auto_Click(object sender, EventArgs e)
        {
            changed(true);
            textBox_sc_auto.Text = "";
            textBox_sc_auto.Focus();
        }

        // テキストボックス選択時の枠線の色の指定
        // TODO
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //textBox_sc_speed_up.BorderStyle = BorderStyle.None;
            //Pen p = new Pen(Color.Blue);
            //Graphics g = e.Graphics;
            //g.DrawRectangle(p,
            //    new Rectangle(textBox_sc_speed_up.Location.X,
            //                  textBox_sc_speed_up.Location.Y,
            //                  textBox_sc_speed_up.Width,
            //                  textBox_sc_speed_up.Height + 6));
            //g.FillRectangle(Brushes.White,
            //                textBox_sc_speed_up.Location.X + 1,
            //                textBox_sc_speed_up.Location.Y + 1,
            //                textBox_sc_speed_up.Width - 2,
            //                textBox_sc_speed_up.Height + 4);
        }

        private void TextBox_sc_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = alice;
        }

        private void TextBox_sc_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = white;
        }

        private void Application_TextChanged(object sender, EventArgs e)
        {
            changed(true);
        }

        private void Label_sec1_Click(object sender, EventArgs e)
        {
            rewind_sec.Focus();
        }

        private void Label_sec2_Click(object sender, EventArgs e)
        {
            forward_sec.Focus();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && this.Text == changing_title)
            {
                string message = "Do you want to save changes?";
                DialogResult result = MessageBox.Show(
                    message,
                    "zlp",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    button_apply_Click(null, null);
                }
                else if (result == DialogResult.No)
                {
                    // Do nothing
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
