using _20520944_TH3.Model;
using _20520944_TH3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20520944_TH3.mainForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20520944_TH3
{
    public partial class Information : Form
    {
        bool love = true;
        Home formout;
        Music musicout;
        string text;
        bool flag_check = false;
        public Information()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Information(Music musicin) : this()
        {
            musicout = musicin;
            pictureBox1.BackgroundImage = musicout.Image;
            label1.Text = musicout.Name;
            label8.Text = musicout.Name;
            label10.Text = musicout.Singer;
            label5.Text = musicout.Singer;
            label9.Text = musicout.Author;
            label6.Text = musicout.Type;
        }

        public Information(Home ucin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1.Hide();
            flag_check = true;
            formout = ucin;
            text = ucin.text_out;
            pictureBox1.BackgroundImage = ucin.music_out.Image;
            label1.Text = ucin.music_out.Name;
            label8.Text = ucin.music_out.Name;
            label10.Text = ucin.music_out.Singer;
            label5.Text = ucin.music_out.Singer;
            label9.Text = ucin.music_out.Author;
            label6.Text = ucin.music_out.Type;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.BringToFront();
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                add_song_in_playlist newform = new add_song_in_playlist(formout.music_out);
                newform.ShowDialog();
            }
            else
            {
                add_song_in_playlist newform = new add_song_in_playlist(musicout);
                newform.ShowDialog();
            }
        }

        private void btn_Lyrics_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                MessageBox.Show(formout.music_out.Lyrics, "Lyrics");
            }
            else
            {
                MessageBox.Show(musicout.Lyrics, "Lyrics");
            }
        }

        private void btn_Credits_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.SendToBack();
        }

        private void btn_Love_Click(object sender, EventArgs e)
        {
            if (love)
            {
                btn_Love.BackgroundImage = Resources.Heartt;
                bool flag = true;
                for (int i = 0; i < love_music.Count; i++)
                {
                    if (flag_check)
                    {
                        if (love_music[i].Name == formout.music_out.Name)
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (love_music[i].Name == musicout.Name)
                        {
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    if (flag_check)
                    {
                        love_music.Add(formout.music_out);
                    }
                    else
                    {
                        love_music.Add(musicout);
                    }
                }
                love = false;
            }
            else
            {
                btn_Love.BackgroundImage = Resources.love;
                love = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        WMPLib.WindowsMediaPlayer axWindowsMediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        List<Music> play_;
        private void btn_Play_Click(object sender, EventArgs e)
        {
            List<Music> music_play = new List<Music>();
            if (flag_check)
            {
                music_play.Add(formout.music_out);
            }
            else
            {
                music_play.Add(musicout);
            }
            play formplay = new play(music_play);
            formplay.ShowDialog();

        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (flag_check)
            {
                form_download form = new form_download(formout.music_out.Mp3_4);
                form.ShowDialog();
            }
            else
            {
                form_download form = new form_download(musicout.Mp3_4);
                form.ShowDialog();
            }
        }
    }
}
