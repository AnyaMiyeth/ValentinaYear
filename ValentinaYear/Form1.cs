using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValentinaYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
           var Edad = DateTime.Now.Year-fecha.Year ;
            textBox2.Text = Edad.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
