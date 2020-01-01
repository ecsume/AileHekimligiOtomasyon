using AileHekimligiOtomasyonu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileHekimligiOtomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();

            var kullanici = loginBLL.Login(textBox1.Text, textBox2.Text);

            if (kullanici.GirisId == -1)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                return;
            }

            HastaPages hastaPages = new HastaPages(kullanici);
            hastaPages.Show();
            this.Hide();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();

            var kullanici = loginBLL.Login("Hasta", "1");

            if (kullanici.GirisId == -1)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                return;
            }

            HastaPages hastaPages = new HastaPages(kullanici);
            hastaPages.Show();
            this.Hide();
        }
    }
}
