using _20520944_TH3.Model;
using _20520944_TH3.Properties;
using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20520944_TH3.mainForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _20520944_TH3
{
    public partial class play : Form
    {
        bool _pause = true;
        public play()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }
        WMPLib.WindowsMediaPlayer axWindowsMediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        //axWindowsMediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        //AxWindowsMediaPlayer axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
        List<Music> play_;
        class_history_music history_play;
        public play(List<Music> musicin) : this()
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            play_ = musicin;
            for (int i = 0; i < play_.Count; i++)
            {
                listBox1.Items.Add(play_[i].Mp3_4);
            }
            //lb_name_lyrics.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            listBox1.SelectedIndex = 0;
            //lb_name_lyrics.Text = play_[listBox1.SelectedIndex].Name + " Lyrics";
            lb_lyrics.Text = play_[listBox1.SelectedIndex].Lyrics;
            lb_name.Text = play_[listBox1.SelectedIndex].Name;
            lb_singer.Text = play_[listBox1.SelectedIndex].Singer;
            axWindowsMediaPlayer1.settings.mute = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = play_[listBox1.SelectedIndex].Mp3_4;
            timer1.Start();
            trackBar.Value = 100;
            lb_volume.Text = trackBar.Value.ToString();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            history_play = new class_history_music(play_[listBox1.SelectedIndex].Name, DateTime.Now.ToString());
            history_music_play.Add(history_play);
            if (_pause)
            {
                axWindowsMediaPlayer1.controls.pause();
                btn_Pause.BackgroundImage = Resources.play;
                _pause = false;
            }   
            else
            {
                btn_Pause.BackgroundImage = Resources.pause;
                axWindowsMediaPlayer1.controls.play();
                _pause = true;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar.Value;
            lb_volume.Text = trackBar.Value.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex -= 1;
                axWindowsMediaPlayer1.URL = play_[listBox1.SelectedIndex].Mp3_4;
                axWindowsMediaPlayer1.controls.play();
                //lb_name_lyrics.Text = play_[listBox1.SelectedIndex].Name + " Lyrics";
                lb_lyrics.Text = play_[listBox1.SelectedIndex].Lyrics;
                lb_name.Text = play_[listBox1.SelectedIndex].Name + " - " + play_[listBox1.SelectedIndex].Singer;
                timer1.Start();

            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < play_.Count - 1)
            {
                listBox1.SelectedIndex += 1;
                axWindowsMediaPlayer1.URL = play_[listBox1.SelectedIndex].Mp3_4;
                axWindowsMediaPlayer1.controls.play();
                //lb_name_lyrics.Text = play_[listBox1.SelectedIndex].Name + " Lyrics";
                lb_lyrics.Text = play_[listBox1.SelectedIndex].Lyrics;
                lb_name.Text = play_[listBox1.SelectedIndex].Name + " - " + play_[listBox1.SelectedIndex].Singer;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.controls.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.controls.currentPosition;
            }
            lbtime.Text = axWindowsMediaPlayer1.controls.currentPositionString;
            lbduration.Text = axWindowsMediaPlayer1.controls.currentItem.durationString.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.controls.stop();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                axWindowsMediaPlayer1.URL = play_[listBox1.SelectedIndex].Mp3_4;
                axWindowsMediaPlayer1.controls.play();
                //lb_name_lyrics.Text = play_[listBox1.SelectedIndex].Name + " Lyrics";
                lb_lyrics.Text = play_[listBox1.SelectedIndex].Lyrics;
                lb_name.Text = play_[listBox1.SelectedIndex].Name + " - " + play_[listBox1.SelectedIndex].Singer;
                timer1.Start();
                history_play = new class_history_music(play_[listBox1.SelectedIndex].Name, DateTime.Now.ToString());
                history_music_play.Add(history_play);
            }
        }
    }
}
