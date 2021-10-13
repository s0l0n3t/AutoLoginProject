using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;// dll'den aldığımız sınıf için.
using Microsoft.Win32;// registry için.
using System.Diagnostics;

namespace AutoLoginİnterface
{
    public partial class Form1 : Form
    {
        public static string Nick_İD;
        public static string Nick_PW;
        
        public Form1()
        {
            Regstry_GET();
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;// boyut değişimi engelleme.
/*         this.MaximumSize = new Size(353, 228);
           this.MinimumSize = new Size(353, 228); */
// Boyut değişimi engelleme.
            InitializeComponent();
             

    }
        //#######################################################
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        //#######################################################
        // user32.dll dosyasından sınıf almak.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 270);
            this.Text = "AutoLogin v1.0";
            timer1.Interval = 10;
            timer2.Interval = 50;
            Opacity = 100;
            this.TopMost = true; // Formu önde tutma.
            MaximizeBox = false;// Max hale getirme.
            MinimizeBox = false;// Küçültme.
            ControlBox = false;// Kapatma olayı.
            ShowInTaskbar = false;// alt tabdan uygulama kısayolu gösterimi.
            timer1.Start();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Null
            
        }
        public static void Regstry_GET()
        {
            Nick_İD = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HWIService",true).GetValue("İD").ToString();
            Nick_PW = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HWIService",true).GetValue("PW").ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Nick_İD.ToString() && textBox2.Text == Nick_PW.ToString())
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Başarılı bir şekilde giriş yapılmıştır.","Başarılı",MessageBoxButtons.OK);
                // Eğer başarılı olursa.
                Application.ExitThread();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Giriş Başarısız.","Error",MessageBoxButtons.OK);
                // Eğer başarısız olursa.
                if (DialogResult == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    timer1.Start();
                    timer2.Start();
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                if (textBox1.Text == Nick_İD.ToString() && textBox2.Text == Nick_PW.ToString())
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Başarılı bir şekilde giriş yapılmıştır.", "Başarılı", MessageBoxButtons.OK);
                    // Eğer başarılı olursa.
                    Application.ExitThread();
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Giriş Başarısız.", "Error", MessageBoxButtons.OK);
                    // Eğer başarısız olursa.
                    if (DialogResult == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        timer1.Start();
                        timer2.Start();
                    }
                }
            }
                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (textBox1.Text == Nick_İD.ToString() && textBox2.Text == Nick_PW.ToString())
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Başarılı bir şekilde giriş yapılmıştır.", "Başarılı", MessageBoxButtons.OK);
                    // Eğer başarılı olursa.
                    Application.ExitThread();
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Giriş Başarısız.", "Error", MessageBoxButtons.OK);
                    // Eğer başarısız olursa.
                    if (DialogResult == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        timer1.Start();
                        timer2.Start();
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            // İşlemi sonlandır.
           
        }

        private void Form1_Move(object sender, EventArgs e)
        {
             this.Location = new Point(500,270);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           //Null
        }

        private void Form1_PaddingChanged(object sender, EventArgs e)
        {
            //Null
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SetForegroundWindow(this.Handle);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
            
        }
    }
}
