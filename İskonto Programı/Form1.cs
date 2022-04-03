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
    public partial class Form1 : Form
    {
        public Form1()
        {//Ahmet Zahit Özel
            InitializeComponent();
        }
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, oran, ilk, kdvsiz, satisfiyati, sonuc, isk, ort, isk2, sonuc2, sonuc3;
            fiyat = Convert.ToDouble(textBox1.Text);
            oran = Convert.ToDouble(textBox2.Text);


            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {//Ahmet Zahit Özel
                ilk = (fiyat * oran) / 100;
                kdvsiz = fiyat - ilk;
                satisfiyati = (kdvsiz * 18) / 100;
                sonuc = kdvsiz + satisfiyati;
                ort = Convert.ToDouble(sonuc);
                ort = Math.Round(ort, 6);
                label1.Text = sonuc.ToString();
            }
            else
            {//Ahmet Zahit Özel
                isk2 = Convert.ToDouble(textBox3.Text);
                ilk = (fiyat * oran) / 100;
                kdvsiz = fiyat - ilk;
                isk = (kdvsiz * isk2) / 100;
                satisfiyati = (kdvsiz * 18) / 100;
                sonuc = kdvsiz + satisfiyati;
                sonuc2 = isk + satisfiyati;
                sonuc3 = sonuc - sonuc2;
                ort = Convert.ToDouble(sonuc);
                ort = Math.Round(ort, 6);
                label1.Text = sonuc3.ToString();


            }
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
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {//Ahmet Zahit Özel
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox2.Text.Length;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectionStart = 0;
            textBox3.SelectionLength = textBox3.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            //Ahmet Zahit Özel
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }
    }
}
//Ahmet Zahit Özel