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

namespace XmlApp_with_two_prices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var path = @"C:\Users\tawer\OneDrive\Рабочий стол\C#_project\XML\LibXML\project - Copy.xml";

            var data = xml.LoadObjectFromFile<Root>(path);

            dataGridView1.DataSource = data.Children;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
