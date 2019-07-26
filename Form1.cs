using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using WMPLib;
using Shell32;
using System.Collections;
using System.Text.RegularExpressions;
using System.Configuration;

namespace zerodori_listening_player
{
    public partial class Form1 : Form
    {
        const int TITLE = 21;
        const int SHARP = 26;
        const int LENGTH = 27;

        enum SHIFT
        {
            PREV,
            NEXT
        }

        Timer timer_main = new Timer();
        Timer timer_label = new Timer();

        bool is_loop;                      // ループ再生のon/off
        bool playing;                      // 再生中か否か
        byte freeze = 0;                   // タイトルラベルをスクロールしない時間

        const string mp3_dir = @"sounds";  // 音声ファイルを格納するディレクトリ
        string mp3_file;                 // 現在選択されている音声ファイル名
        string[] mp3_file_paths;           // 全ての音声ファイルパス
        int mp3_now;                  // 現在選択されている番号
        int mp3_length;               // 再生時間(秒)
        int mp3_count;                // 音声ファイルの最大数(追加可能)


        WindowsMediaPlayer mp = new WindowsMediaPlayer();

        Shell sh = new Shell();
        Folder f;
        FolderItem fi;


        public Form1()
        {
            InitializeComponent();

            // フォームが表示されたときの処理
            Shown += delegate
            {
                //シークバーにフォーカスがあると、再生位置が表示されないのでここで再生ボタンにフォーカスを与える
                button_start_stop.Focus();
            };

            // 自動再生をOFF
            mp.settings.autoStart = false;

            // 再生位置のシーク
            bar_seek.ValueChanged += delegate
            {
                if (bar_seek.Focused)
                {
                    mp.controls.currentPosition = (double)bar_seek.Value;
                }
            };

            // メインタイマーの設定
            timer_main.Interval = 100;
            timer_main.Tick += delegate
            {
                // 再生位置, 再生時間の表示
                if (mp.playState == WMPPlayState.wmppsPlaying || mp.playState == WMPPlayState.wmppsPaused)
                {
                    bar_seek.Maximum = (int)(mp.controls.currentItem.duration);
                    //bar_seek.Maximum = mp3_length;
                    bar_seek.Value = (int)(mp.controls.currentPosition);
                    time_now.Text = ((int)mp.controls.currentPosition / 60).ToString("0") + ":" + ((int)mp.controls.currentPosition % 60).ToString("00");
                }

                // ループ再生
                if (is_loop && mp.playState == WMPPlayState.wmppsStopped)
                {
                    mp.settings.rate = double.Parse(list_speed.Text);
                    mp.controls.play();
                }
            };
            timer_main.Start();

            // ラベルスクロール用タイマーの設定
            timer_label.Interval = 200;
            timer_main.Tick += delegate
            {
                if (label_title.Size.Width > this.Width)
                {
                    if (label_title.Left < this.Width - label_title.Size.Width - 10 - 40)
                    {
                        freeze = 0;
                        label_title.Left = 10;
                    }
                    else if (label_title.Left == 10 && freeze < 15)
                    {
                        ++freeze;
                    }
                    else
                        label_title.Left -= 1;
                }
            };
            timer_label.Start();


            // レイアウトの調整
            // 音量バーを最背面へ
            bar_volume.SendToBack();
            // 速度ドロップダウンへの入力を禁止
            list_speed.DropDownStyle = ComboBoxStyle.DropDownList;
            // 音量バーのつまみの画像
            //bar_volume.Thumbs
            // フォームのサイズを固定
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 初期値の指定
            list_speed.SelectedIndex = 2; // 1.0
            is_loop = false;
            playing = false;
            mp3_now = 1;

            // 音声ファイル一覧の読み込み
            mp3_count = Directory.GetFiles(mp3_dir, "*.mp3", SearchOption.AllDirectories).Length;
            if (mp3_count == 0)
            {
                MessageBox.Show("音声ファイルが見つかりません",
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
            mp3_file_paths = Directory.GetFiles(mp3_dir, "*.mp3", SearchOption.AllDirectories);
            Array.Sort(mp3_file_paths, new SortByNumber());

            // 前回の設定を読み込み, 適用
            mp3_now = int.Parse(ConfigurationManager.AppSettings["now"]);
            if (mp3_now > mp3_count)
                mp3_now = 1;
            mp3_file = Path.GetFileName(mp3_file_paths[mp3_now - 1]);
            list_speed.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["speed"]);
            mp.settings.volume = int.Parse(ConfigurationManager.AppSettings["volume"]);
            bar_volume.Value = mp.settings.volume;
            is_loop = bool.Parse(ConfigurationManager.AppSettings["loop"]);
            button_loop.BackColor = is_loop ? Color.LightGray : SystemColors.Control;
            mp.URL = mp3_file_paths[mp3_now - 1];

            init();
        }

        private void button_start_stop_Click(object sender, EventArgs e)
        {
            playing = !playing;
            mp_ctl();
        }

        private void button_loop_Click(object sender, EventArgs e)
        {
            is_loop = !is_loop;
            button_loop.BackColor = is_loop ? Color.LightGray : SystemColors.Control;
        }

        private void change_mp3()
        {
            mp3_file = Path.GetFileName(mp3_file_paths[mp3_now - 1]);
            mp.URL = mp3_file_paths[mp3_now - 1];
            mp.settings.rate = double.Parse(list_speed.Text);
            f = sh.NameSpace(Path.GetDirectoryName(mp.URL));
            fi = f.ParseName(mp3_file);
            mp3_number.Text = int.Parse(f.GetDetailsOf(fi, SHARP)).ToString("000");
            playing = false;
            label_title.Left = 10;
            freeze = 0;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            shift_sound(SHIFT.NEXT);
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            shift_sound(SHIFT.PREV);
        }
        private void shift_sound(SHIFT s)
        {
            if (s == SHIFT.PREV)
            {
                --mp3_now;
                if (mp3_now == 0)
                    mp3_now = mp3_count;

                // 8倍遅い
                //mp3_now = (((mp3_now - 2) % mp3_count) + mp3_count) % mp3_count + 1;
            }
            else if (s == SHIFT.NEXT)
            {
                mp3_now = mp3_now % mp3_count + 1;
            }

            bar_seek.Value = 0;
            time_now.Text = "0:00";
            playing = false;
            mp_ctl();
            change_mp3();
            set_title();
            set_time();
            bar_seek.Maximum = mp3_length;
            mp.controls.currentPosition = 0;
        }

        private void set_title()
        {
            label_title.Text = f.GetDetailsOf(fi, TITLE);
        }

        private void set_time()
        {
            DateTime dt = DateTime.Parse(f.GetDetailsOf(fi, LENGTH));
            time_length.Text = dt.Minute + ":" + dt.Second;
            mp3_length = dt.Minute * 60 + dt.Second;
        }

        private void mp_ctl()
        {
            if (playing)
            {
                mp.controls.play();
                button_start_stop.Image = System.Drawing.Image.FromFile(@"resources\pause.png");
            }
            else
            {
                mp.controls.pause();
                button_start_stop.Image = System.Drawing.Image.FromFile(@"resources\regeneration.png");
            }
        }

        private void init()
        {
            time_now.Text = "0:00";
            change_mp3();
            set_title();
            set_time();
            mp.controls.pause();
            bar_seek.Maximum = mp3_length;
        }

        private void mp3_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            //if('０' <= key && key <= '９')
            //{
            //    key = (char)(key - '０' + '0');
            //    mp3_number.Text += key;
            //    this.mp3_number.Select(this.mp3_number.Text.Length, 0);
            //}

            if (e.KeyChar == (char)Keys.Enter)
            {
                button_start_stop.Focus();
                mp3_number.Text = mp3_number.Text.PadLeft(3, '0');
                mp3_now = int.Parse(mp3_number.Text);

                if (mp3_now < 1 || mp3_count < mp3_now)
                {
                    mp3_number.Text = "001";
                    mp3_now = 1;
                }

                mp3_number.Select(mp3_number.Text.Length, 0);

                change_mp3();
                set_time();
                set_title();
            }
        }

        private void bar_volume_Scroll(object sender, EventArgs e)
        {
            mp.settings.volume = bar_volume.Value;
        }

        [System.Security.Permissions.UIPermission(
            System.Security.Permissions.SecurityAction.Demand,
            Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // 左キーで 5秒戻り
            if ((keyData & Keys.KeyCode) == Keys.Left)
            {
                rewind();
                return true;
            }
            // 右キーで 5秒送り
            else if ((keyData & Keys.KeyCode) == Keys.Right)
            {
                forward();
                return true;
            }
            // Pキーで 前の音声
            else if ((keyData & Keys.KeyCode) == Keys.P)
            {
                shift_sound(SHIFT.PREV);
                return true;
            }
            // Nキーで 次の音声
            else if ((keyData & Keys.KeyCode) == Keys.N)
            {
                shift_sound(SHIFT.NEXT);
                return true;
            }
            // Lキーで ループ on/off
            else if ((keyData & Keys.KeyCode) == Keys.L)
            {
                is_loop = !is_loop;
                button_loop.BackColor = is_loop ? Color.LightGray : SystemColors.Control;
                return true;
            }
            // スペースキーでstart/stop
            else if ((keyData & Keys.KeyCode) == Keys.Space)
            {
                playing = !playing;
                mp_ctl();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void list_speed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.Handled = true;
        }

        private void bar_volume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.Handled = true;
        }

        private void bar_seek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.Handled = true;
        }

        private void bar_seek_MouseUp(object sender, MouseEventArgs e)
        {
            button_start_stop.Focus();
        }

        private void list_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            mp.settings.rate = double.Parse(list_speed.Text);
        }

        private void button_rewind_Click(object sender, EventArgs e)
        {
            rewind();
        }

        private void button_forward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void rewind()
        {
            int tmp_pos = (int)mp.controls.currentPosition;
            tmp_pos -= 5;
            if (tmp_pos <= 0)
                mp.controls.currentPosition = tmp_pos = 0;
            else
                mp.controls.currentPosition = tmp_pos;

            bar_seek.Value = tmp_pos;
            time_now.Text = (tmp_pos / 60).ToString("0") + ":" + (tmp_pos % 60).ToString("00");
        }

        private void forward()
        {
            int tmp_pos = (int)mp.controls.currentPosition;
            tmp_pos += 5;
            if (tmp_pos >= mp3_length)
                mp.controls.currentPosition = tmp_pos = mp3_length;
            else
                mp.controls.currentPosition = tmp_pos;

            bar_seek.Value = tmp_pos;
            time_now.Text = (tmp_pos / 60).ToString("0") + ":" + (tmp_pos % 60).ToString("00");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            cfg.AppSettings.Settings["now"].Value = mp3_now.ToString();
            cfg.AppSettings.Settings["speed"].Value = list_speed.SelectedIndex.ToString();
            cfg.AppSettings.Settings["volume"].Value = mp.settings.volume.ToString();
            cfg.AppSettings.Settings["loop"].Value = is_loop.ToString();

            cfg.Save();
        }
    }

    public class SortByNumber : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            int num1, num2;

            Regex re = new Regex(@"[^0-9]");

            s1 = re.Replace(Path.GetFileName(s1), "");
            s2 = re.Replace(Path.GetFileName(s2), "");

            num1 = int.Parse(s1);
            num2 = int.Parse(s2);

            return num1 - num2;
        }
    }
}
