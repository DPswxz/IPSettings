using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsIPSettings
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("fillIP.txt");
                txtIP.Text = sr.ReadLine();
                txtSubnetMask.Text = sr.ReadLine();
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {              
                StreamWriter sw = new StreamWriter("fillIP.txt", false);
                sw.WriteLine(txtIP.Text.ToString());
                sw.WriteLine(txtSubnetMask.Text.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
