﻿using _20520944_TH3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20520944_TH3.Model;
using static _20520944_TH3.mainForm;

namespace _20520944_TH3
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        List<Music> musicout;
        List<Music> play_music;
        public string text_out;
        public Home(List<Music> musicin, string text) : this()
        {
            musicout = musicin;
            text_out = text;
            choose_list_music();
        }

        public List<int> quantity_play_of_1_song;
        public List<string> name_song;

        private void load_fpn(Music music_load)
        {
            Label lbl = new Label();
            lbl.Text = music_load.Name;
            lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(90, 20);

            Label lbl2 = new Label();
            lbl2.Text = music_load.Singer;
            lbl2.Font = new Font("Arial", 12, FontStyle.Regular);
            lbl2.AutoSize = true;
            lbl2.Location = new Point(90, 45);

            PictureBox ptb = new PictureBox();
            ptb.Tag = music_load.Name;
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Size = new Size(70, 70);
            ptb.Image = music_load.Image;
            ptb.Location = new Point(10, 10);

            Panel pn = new Panel();
            pn.Size = new Size(400, 90);
            pn.Controls.Add(ptb);
            pn.Controls.Add(lbl);
            pn.Controls.Add(lbl2);
            fpn.Controls.Add(pn);
            play_music.Add(music_load);
            ptb.Click += new EventHandler(ptb_click);
        }
        private void show_list_music_homeand_love()
        {
            play_music = new List<Music>();
            if (text_out != "History")
            {
                for (int i = 0; i < musicout.Count; i++)
                {
                    if (text_out != "Liked Songs")
                    {
                        if (i == 0 || i == 10 || i == 20 || i == 30)
                        {
                            Panel pn_type = new Panel();
                            Label lbl_type = new Label();
                            lbl_type.Text = musicout[i].Type;
                            lbl_type.AutoSize = true;
                            lbl_type.Font = new Font("Comics", 20, FontStyle.Bold);
                            lbl_type.Location = new Point(1, 10);
                            pn_type.Size = new Size(1200, 50);
                            pn_type.Controls.Add(lbl_type);
                            fpn.Controls.Add(pn_type);
                        }
                    }
                    load_fpn(musicout[i]);
                }
            }
            if (text_out == "History")
            {
                quantity_play_of_1_song = new List<int>();
                name_song = new List<string>();
                for (int i = 0; i < history_music_play.Count; i++)
                {
                    bool flag = false;
                    for (int check = 0; check < i; check++)
                    {
                        if (history_music_play[i].Name == history_music_play[check].Name)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        int count = 1;
                        for (int j = i + 1; j < history_music_play.Count; j++)
                        {
                            if (history_music_play[i].Name == history_music_play[j].Name)
                            {
                                count++;
                            }
                        }
                        quantity_play_of_1_song.Add(count);
                        name_song.Add(history_music_play[i].Name);
                    }
                }
                for (int i = 0; i < name_song.Count; i++)
                {
                    for (int j = 0; j < musicout.Count; j++)
                    {
                        if (musicout[j].Name == name_song[i])
                        {
                            load_fpn(musicout[j]);
                        }
                    }
                }
            }
        }

        private void show_list_music_category()
        {
            play_music = new List<Music>();
            string a = text_out.Trim().ToLower();
            string[] split_a = a.Split(' ');
            for (int i = 0; i < musicout.Count; i++)
            {
                int count = 0;
                string temp = musicout[i].Type.ToLower();
                string[] split_temp = temp.Split(' ');
                for (int j = 0; j < split_a.Length; j++)
                {
                    for (int z = 0; z < split_temp.Length; z++)
                    {
                        if (split_a[j] == split_temp[z])
                        {
                            count++;
                        }
                    }
                }

                if (count == split_a.Length)
                {
                    load_fpn(musicout[i]);
                }
            }
        }

        private void choose_list_music()
        {
            if (text_out != "Home" && text_out != "Liked Songs" && text_out != "History")
            {
                show_list_music_category();
            }
            else
            {
                show_list_music_homeand_love();
            }
        }
        public Music music_out;
        private void ptb_click(object sender, EventArgs e)
        {
            for (int i = 0; i < musicout.Count; i++)
            {
                if (musicout[i].Name == ((PictureBox)sender).Tag)
                {
                    music_out = musicout[i];
                    if (text_out != "History")
                    {
                        Information newform = new Information(this);
                        newform.ShowDialog();
                    }
                    else
                    {
                        information_for_history newform = new information_for_history(this);
                        newform.ShowDialog();
                    }
                }
            }
        }
        internal void load_list_love()
        {
            if (text_out == "History")
            {
                fpn.Controls.Clear();
                show_list_music_homeand_love();
            }
            else
            {
                for (int i = 0; i < musicout.Count; i++)
                {
                    if (musicout[i].Name == music_out.Name)
                    {
                        musicout.Remove(musicout[i]);
                    }
                }
                fpn.Controls.Clear();
                show_list_music_homeand_love();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (play_music.Count > 0)
            {
                play newform = new play(play_music);
                newform.ShowDialog();
            }
        }
    }
}
