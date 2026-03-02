using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitim1
{
    public partial class Egitim : Form
    {
        public Egitim()
        {
            InitializeComponent();
        }

        private void Egitim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Butona Tıklandı";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            { 
                button1.Enabled = false;
            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (kullaniciadi.Text == "Admin" && sifre.Text == "sifre")
            {
                label1.Text = "Hoşgeldin Emmi";
            }
            else
            {
                MessageBox.Show("Giriş Başarısız"); // kısayolu mbox tab tab ekrana mesaj vermemizi sağlar
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(comboBox1.SelectedValue.ToString(),(float)numericUpDown1.Value);
        }
    }
}
