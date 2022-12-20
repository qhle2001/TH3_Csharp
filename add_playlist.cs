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

namespace _20520944_TH3
{
    public partial class add_playlist : Form
    {
        user_playlist form_out;
        public add_playlist(user_playlist uc_in)
        {
            InitializeComponent();
            this.form_out = uc_in;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < _playlist.Count; i++)
            {
                if (textBox1.Text == _playlist[i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                _playlist.Add(textBox1.Text);
                form_out.load_list_view();
                this.Close();
            }
            else
            {
                MessageBox.Show("Playlist đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool flag = true;
                for (int i = 0; i < _playlist.Count; i++)
                {
                    if (textBox1.Text == _playlist[i])
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    _playlist.Add(textBox1.Text);
                    form_out.load_list_view();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Playlist đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddTo_Click(object sender, EventArgs e)
        {

        }
    }
}
