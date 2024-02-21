using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldskil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                label1.Text = faktorial(num).ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public static int faktorial(int num)
        {
            if(num == 1) return 1;
            return num * faktorial(num - 1);
        }
    }
}
