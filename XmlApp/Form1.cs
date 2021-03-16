using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibXML;

namespace XmlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var path = @"D:\С# projects\LibXML\project.xml";

            var data = xml.LoadObjectFromFile<root>(path);

            dataGridView1.DataSource = data.Children;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
