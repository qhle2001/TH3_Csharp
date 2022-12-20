using _20520944_TH3.Model;
using _20520944_TH3.Properties;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _20520944_TH3.Home;
using static _20520944_TH3.mainForm;
using static System.Net.Mime.MediaTypeNames;

namespace _20520944_TH3
{
    public partial class information_for_history : Form
    {
        Home formout;
        bool love = true;
        int quantity;
        public information_for_history(Home ucin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            formout = ucin;
            pictureBox1.Image = ucin.music_out.Image;
            label1.Text = ucin.music_out.Name;
            label10.Text = ucin.music_out.Singer;
            label3.Text = ucin.music_out.Author;
            label2.Text = ucin.music_out.Type;
            lstShow.View = View.Details;
            quantity = 0;
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    quantity++;
                }
            }
            lbquantity.Text = quantity.ToString();
            lstShow.GridLines = true;
            lstShow.Columns.Add("Lần thứ", -2, HorizontalAlignment.Left);
            lstShow.Columns.Add("Thời gian", -2, HorizontalAlignment.Left);
            load_listview();
        }
        private void load_listview()
        {
            int count = 0;
            lstShow.Items.Clear();
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    count++;
                    ListViewItem item = new ListViewItem();
                    item.Text = count.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = history_music_play[i].Date });
                    lstShow.Items.Add(item);
                }
            }
            lstShow.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            lstShow.ForeColor = Color.Black;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            List<Music> music_play = new List<Music>();
            music_play.Add(formout.music_out);
            play formplay = new play(music_play);
            formplay.ShowDialog();
            quantity = 0;
            for (int i = 0; i < history_music_play.Count; i++)
            {
                if (history_music_play[i].Name == formout.music_out.Name)
                {
                    quantity++;
                }
            }
            lbquantity.Text = quantity.ToString();
            load_listview();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            form_download form = new form_download(formout.music_out.Mp3_4);
            form.ShowDialog();
        }

        private void btn_Love_Click(object sender, EventArgs e)
        {
            if (love)
            {
                btn_Love.BackgroundImage = Resources.Heartt;
                bool flag = true;
                for (int i = 0; i < love_music.Count; i++)
                {
                    if (love_music[i].Name == formout.music_out.Name)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    love_music.Add(formout.music_out);
                }
                love = false;
            }
            else
            {
                btn_Love.BackgroundImage = Resources.love;
                love = true;
            }
        }
    }
}
