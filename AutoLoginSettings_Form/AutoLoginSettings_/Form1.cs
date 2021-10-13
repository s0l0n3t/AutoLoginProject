using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLoginSettings_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static System.Drawing.Point Button_Local2;
        public static System.Drawing.Point Button_Localizate;
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            MaximizeBox = false; // Max hale getirme.
            MinimizeBox = false; // Min hale getirme.
            richTextBox1.ReadOnly = true; // rtf yazma kısıtlaması.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;// Boyut değişimi engeli.
            Button_Localizate = button2.Location;
            Button_Local2 = button1.Location;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void merhabaKullanımınızİçinTeşekkürlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paypal.com/furkantokgz@gmail.com","Thanks for your support.",MessageBoxButtons.OK);
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrote by s0l0n3t.","github.com/s0l0n3t",MessageBoxButtons.OK);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setup frm_setup = new Setup();
            frm_setup.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
