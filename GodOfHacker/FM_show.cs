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
    public partial class FM_show : Form
    {
        string _title = "成功";
        string _text = "成功";
        public FM_show()
        {
            InitializeComponent();
            change();
        }
        public FM_show(string a,string b,int time)
        {
            //System.Threading.Thread.Sleep(time);
            title = a;
            text = b;
            InitializeComponent();
            change();
        }
        public string title { set { _title = value; } }
        public string text { set { _text = value; } }
        private void change()
        {
            this.Text = _title;
            label1.Text = _text;
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value++;
            }
        }
    }
}
