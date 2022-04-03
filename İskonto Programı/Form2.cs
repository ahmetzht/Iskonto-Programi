using System;
//Ahmet Zahit Özel
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//Ahmet Zahit Özel

namespace Delka_İskonto
{
    public partial class Form2 : Form
    {//Ahmet Zahit Özel
        public Form2()
        {
            InitializeComponent();
        }
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        public string islem = String.Empty;
        public double sayi1 = 0;


        private void Form2_Load(object sender, EventArgs e)
        {//Ahmet Zahit Özel
            textBox1.Focus();
        }


        private void iconcerrar_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {//Ahmet Zahit Özel
                Form.ActiveForm.Close();
            }
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {//Ahmet Zahit Özel
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {//Ahmet Zahit Özel
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {//Ahmet Zahit Özel
            formTasiniyor = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {//Ahmet Zahit Özel
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//Ahmet Zahit Özel
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = 0;
            switch (islem)
            {
                case "":
                    sonuc = sayi1 * sayi2 / 100;
                    sonuc = sayi1 + sonuc;
                    break;
                default:
                    MessageBox.Show("İşlem seçmelisiniz!", "Hata");
                    break;
            }

            label1.Text = sonuc.ToString();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {//Ahmet Zahit Özel
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {//Ahmet Zahit Özel
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {//Ahmet Zahit Özel
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {//Ahmet Zahit Özel
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox1.Text.Length;
        }
    }
}
