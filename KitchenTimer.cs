using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace zerodori_listening_player
{
    public partial class KitchenTimer : Form
    {
        enum items
        {
            MAIN,
            SETTING
        }

        private FormWindowState formWindowState;
        private items current_item;
        private int sec;
        private bool playing;

        public KitchenTimer()
        {
            InitializeComponent();

            this.MinimumSize = new Size(320, 192);
            this.formWindowState = this.WindowState;

            current_item = items.MAIN;
            visible_setting(false);

            int sec = int.Parse(ConfigurationManager.AppSettings["timer_sec"]);

            numericUpDown_hour.Value = sec / 3600;
            numericUpDown_min.Value = sec % 3600 / 60;
            numericUpDown_sec.Value = sec % 60;

            set_timer();
            rearrangement();
        }

        private void KitchenTimer_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                this.formWindowState = this.WindowState;
                rearrangement();
            }
        }

        private void rearrangement()
        {
            int client_w = ClientSize.Width;
            int client_h = ClientSize.Height;
            int button_main_w = button_main.Width;
            int button_start_w = button_start.Width;
            int button_updown_w = numericUpDown_hour.Width;
            int button_updown_h = numericUpDown_hour.Height;
            int button_updown_basis = (button_updown_w * 3) / 2;
            int label_hms_w = label_hms.Width;
            int label_hms_h = label_hms.Height;

            button_main.Location = new Point(client_w / 2 - button_main_w / 2, client_h / 8);
            button_start.Location = new Point(client_w / 2 - button_start_w / 2, (client_h / 5) * 3);

            numericUpDown_hour.Location = new Point(client_w / 2 - button_updown_basis, client_h / 8);
            numericUpDown_min.Location = new Point(client_w / 2 - button_updown_basis + button_updown_w, client_h / 8);
            numericUpDown_sec.Location = new Point(client_w / 2 - button_updown_basis + button_updown_w * 2, client_h / 8);
            label_hms.Location = new Point(client_w / 2 - label_hms_w / 2, numericUpDown_hour.Location.Y - label_hms_h);
        }

        private void Button_main_Click(object sender, EventArgs e)
        {
            current_item = items.SETTING;
            playing = false;
            set_image(playing);
            visible_main(false);
            visible_setting(true);
        }

        private void visible_main(bool v)
        {
            button_main.Visible = v;
        }

        private void visible_setting(bool v)
        {
            numericUpDown_hour.Visible =
            numericUpDown_min.Visible =
            numericUpDown_sec.Visible =
            label_hms.Visible = v;
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if (current_item == items.MAIN)
            {
                playing = !playing;
                set_image(playing);
            }
            else if (current_item == items.SETTING)
            {
                set_timer();
                visible_main(true);
                visible_setting(false);
                current_item = items.MAIN;
            }
        }

        private void set_image(bool p)
        {
            if (p)
            {
                button_start.Image = System.Drawing.Image.FromFile(@"resources\pause.png");
            }
            else
            {
                button_start.Image = System.Drawing.Image.FromFile(@"resources\regeneration.png");
            }
        }

        private void set_timer()
        {
            playing = false;

            int h = (int)numericUpDown_hour.Value;
            int m = (int)numericUpDown_min.Value;
            int s = (int)numericUpDown_sec.Value;

            sec = h * 3600 + m * 60 + s;

            view_timer();
        }

        private void view_timer()
        {
            button_main.Text =
                (sec / 3600).ToString().PadLeft(2, '0') + ":" +
                (sec % 3600 / 60).ToString().PadLeft(2, '0') + ":" +
                (sec % 60).ToString().PadLeft(2, '0');
        }

        private void NumericUpDown_hour_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_hour.Value == 24)
            {
                numericUpDown_hour.Value = 0;
            }
            else if (numericUpDown_hour.Value == -1)
            {
                numericUpDown_hour.Value = 23;
            }
        }

        private void NumericUpDown_min_sec_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value == 60)
            {
                ((NumericUpDown)sender).Value = 0;
            }
            else if (((NumericUpDown)sender).Value == -1)
            {
                ((NumericUpDown)sender).Value = 59;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(playing)
            {
                if (sec <= 0)
                {
                    if(this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = this.formWindowState;
                    }
                    this.Activate();
                    System.Media.SystemSounds.Beep.Play();
                    playing = false;
                    set_image(playing);
                }
                else
                {
                    --sec;
                    view_timer();
                }
            }
        }

        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            topMostToolStripMenuItem.Checked = !topMostToolStripMenuItem.Checked;
        }

        private void KitchenTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            int h = (int)numericUpDown_hour.Value;
            int m = (int)numericUpDown_min.Value;
            int s = (int)numericUpDown_sec.Value;
            sec = h * 3600 + m * 60 + s;

            cfg.AppSettings.Settings["timer_sec"].Value = sec.ToString();

            cfg.Save();
        }
    }
}
