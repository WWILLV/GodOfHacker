using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GodOfHacker
{
    public partial class FM_God : Form
    {
        public FM_God()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 97; i++)
            {
                progressBar1.Value++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 97; i++)
            {
                progressBar1.Value++;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已经锤爆出题人的狗头！");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            FM_show fs = new FM_show(text_cumTitle.Text,text_cumText.Text, (int)numericUpDown1.Value);
            fs.Owner = this;
            fs.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/WWILLV/GodOfHacker/");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://music.163.com/#/m/song?id=333750&userid=340656630");
        }
    }
}
