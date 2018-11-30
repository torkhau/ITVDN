using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte IsChesked()
        {
            if (this.radioButton1.Checked)
            {
                return 1;
            }
            if (this.radioButton2.Checked)
            {
                return 2;
            }
            if (this.radioButton3.Checked)
            {
                return 3;
            }
            if (this.radioButton4.Checked)
            {
                return 4;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Res = "";
            switch (IsChesked())
            {
                case 1 :
                    Res = Convert.ToString(Int32.Parse(this.textBox1.Text) % Int32.Parse(this.textBox2.Text));
                    break;
                case 2 :
                    Res = Convert.ToString(Math.Pow(Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text)));
                    break;
                case 3 :
                    Res = Convert.ToString(Int32.Parse(this.textBox1.Text) * Int32.Parse(this.textBox2.Text));
                    break;
                case 4:
                    Res = Convert.ToString(Int32.Parse(this.textBox1.Text) / (float)Int32.Parse(this.textBox2.Text));
                    break;
                default:
                    Res = "ERROR";
                    break;
            };
            this.textBox3.Text = Res;
        }
    }
}
