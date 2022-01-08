using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamUnwe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          DialogResult result=  colorDialog1.ShowDialog();
            if (result ==DialogResult.OK)
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        this.BackColor = colorDialog1.Color;
                        break;
                    case 1:
                        btnChangeColor.BackColor = colorDialog1.Color;
                        break;
                    case 2:
                        btnChangeColor.ForeColor = colorDialog1.Color;
                        break;
                }
            }
        }
    }
}
