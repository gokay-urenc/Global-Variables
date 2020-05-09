using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin;

        private void Form1_Load(object sender, EventArgs e)
        {
            metin = "Hello World.";
            MessageBox.Show(metin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metin += "\nHello World.";
            MessageBox.Show(metin);
        }
    }
}