using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string message = "Hello, World!";
            textBox1.Text = message;*/
            try
            {
                int yosh = Convert.ToInt32(textBox2.Text);
                if (yosh < 18)
                {
                    textBox1.Text = "Siz hali voyaga yetmagansiz!";
                }
                else
                {
                    textBox1.Text = "Xush kelibsiz!";
                }
            }
            catch (FormatException)
            {
                textBox1.Text = "Iltimos, butun son kiriting!";
            }
            finally
            {
                textBox1.AppendText("\nDastur tugadi");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
