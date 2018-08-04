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
    public partial class FM_plugin : Form
    {
        string name, input, palmparameter;
        public FM_plugin()
        {
            InitializeComponent();
        }
        public void pluginset()
        {
            string output = DateTime.Now.ToString() + "\r\n";
            output += ("插件名：" + name + "\r\n" + "\r\n输入：" + input + "\r\n" 
                + "\r\n参数:" + palmparameter + "\r\n");
            output += ">>>\r\n";
            output += "执行成功！\r\n";
            plugin_out.Text = output;
        }
        public void init(string name,string input,string palmparameter)
        {
            this.name = name;
            this.input = input;
            this.palmparameter = palmparameter;
            pluginset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
