using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // D:\Asosiy\Docs\Projects\C#\Fayllar
            string fayl = @"D:\Asosiy\Docs\Projects\C#\Fayllar\info.txt";
            StreamReader sw = new StreamReader(fayl);
            var context = sw.ReadToEnd();
            richTextBox1.Text = context;
            sw.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"D:\Asosiy\Docs\Projects\C#\Fayllar\Pochtalar_Merge.csv", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);
            
            StreamReader sr2 = new StreamReader(@"D:\Asosiy\Docs\Projects\C#\Fayllar\Boboqandov_DGU.png");

            richTextBox1.Clear();
            richTextBox1.Text = sr2.ReadToEnd();
        }
    }
}
