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

namespace GodOfHacker
{
    public partial class FM_God : Form
    {
        public FM_God()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            if(!File.Exists("plugin.txt"))
            {
                string path = Application.StartupPath + "\\plugin.txt";
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名，还可以为word等文件
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                sw.Close(); //关闭文件
            }
        }

        public static List<string> readFileToList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader m_streamReader = new StreamReader(fs, System.Text.Encoding.Default);
            m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strLine = m_streamReader.ReadLine();
            while (strLine != null)
            {
                list.Add(strLine);
                strLine = m_streamReader.ReadLine();
            }
            m_streamReader.Close();
            return list;
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
            //http://music.163.com/#/m/song?id=333750&userid=340656630
            System.Diagnostics.Process.Start("http://music.163.com/outchain/player?type=2&id=333750&auto=1");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哪里有什么商店\r\n在plugin.txt里写入想要的插件，一行一个就行了");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            FM_plugin son = new FM_plugin();
            son.Owner = this;
            son.init(comboBox2.Text, textBox4.Text, textBox5.Text);
            progressBar2.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                progressBar2.Value++;
            }
            son.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage8")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Insert(0, "请选择插件");
                comboBox2.SelectedIndex = 0;
                foreach (var item in readFileToList(Application.StartupPath + "\\plugin.txt"))
                {
                    comboBox2.Items.Add(item);
                }
            }
        }
    }
}
