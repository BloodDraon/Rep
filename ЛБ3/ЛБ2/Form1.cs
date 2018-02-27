using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛБ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            Demukron d = new Demukron();
            txtBox_output.Visible = true;
            d.start(txtBox_output);
        }
    }
}