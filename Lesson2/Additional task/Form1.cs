using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additional_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("-128..127"); //byte
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("0..255"); //ubyte
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("-32768..32767"); //short
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("0..65535"); //ushort
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("-2147483648..2147483647"); //int
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("0..4294967295"); //uint
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("-9223372036854775808..9223372036854775807"); //long
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("сюда можно вписать текст");
            MessageBox.Show("0..18446744073709551615"); //ulong
        }
    }
}
