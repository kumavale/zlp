using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zerodori_listening_player
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            rewind_sec.MaxLength  = 3;
            forward_sec.MaxLength = 3;

            // 設定の読み込み
            rewind_sec.Text  = Form1.rewind_sec.ToString();
            forward_sec.Text = Form1.forward_sec.ToString();
            
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
    }
}
