using AileHekimligiOtomasyonu.BLL;
using AileHekimligiOtomasyonu.BLL.Model;
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
    public enum GirisTip
    {
        Doktor = 1,
        Hasta,
        Admin
    }

    public partial class HastaPages : Form
    {
        public HastaPages()
        {
            InitializeComponent();
        }
        LoginItem GirisBilgileri;
        public HastaPages(LoginItem model)
        {
            InitializeComponent();
            GirisBilgileri = model;

            if (model.GirisId > 0)
            {
                if (model.Tip == (int)GirisTip.Doktor)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage10);
                    tabControl1.TabPages.Remove(tabPage11);
                }
                else if (model.Tip == (int)GirisTip.Hasta)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage11);
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }
        public void GetSaglikOcagi()
        {
            SaglikOcagiBLL saglikOcagiBLL = new SaglikOcagiBLL();
            comboBox2.DataSource = saglikOcagiBLL.Listele();
            comboBox2.DisplayMember = "SaglikOcagiAd";
            comboBox2.ValueMember = "SaglikOcagiId";
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TaniModel taniModel = new TaniModel();
            taniModel.Aciklama = textBox14.Text;
            TaniBLL taniBLL = new TaniBLL();
            taniBLL.Kaydet(taniModel);
            GetList();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TaniModel t = (TaniModel)dataGridView3.SelectedRows[0].DataBoundItem;
            TaniBLL taniBLL = new TaniBLL();
            taniBLL.Sil(t.TaniId);
            GetList();
        }
        public void GetMuayeneList()
        {
            MuayeneBLL muayeneBLL = new MuayeneBLL();
            dataGridView7.DataSource = null;
            dataGridView7.DataSource = muayeneBLL.GridListe();
        }
        private void HastaPages_Load(object sender, EventArgs e)
        {
            GetMuayeneList();
            GetList();
            GetIlacList();
            GetHastaList();
            GetBugununHastalariList();
            GetSaglikOcagi();
            GetDoktorList();
            GetIlacCombo();
            GetTaniCombo();
            GetDoktorCombo();
            GetHastaCombo();
            HastaRandevuGecmisi();
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(15);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy hh:mm:ss";
        }
        public void GetIlacCombo()
        {
            IlacBLL ilacBLL = new IlacBLL();
            comboBox3.DataSource = ilacBLL.Listele();
            comboBox3.DisplayMember = "IlacAdi";
            comboBox3.ValueMember = "IlacId";
        }
        public void GetTaniCombo()
        {
            TaniBLL taniBLL = new TaniBLL();
            comboBox1.DataSource = taniBLL.Listele();
            comboBox1.DisplayMember = "Aciklama";
            comboBox1.ValueMember = "TaniId";
        }
        public void GetDoktorCombo()
        {
            DoktorBLL doktorBLL = new DoktorBLL();
            comboBox9.DataSource = doktorBLL.Listele();
            comboBox9.DisplayMember = "Ad";
            comboBox9.ValueMember = "DoktorId";
            comboBox5.DataSource = doktorBLL.Listele();
            comboBox5.DisplayMember = "Ad";
            comboBox5.ValueMember = "DoktorId";

            if (GirisBilgileri.Tip == (int)GirisTip.Doktor)
            {
                comboBox9.SelectedValue = GirisBilgileri.GirisId;
                comboBox5.SelectedValue = GirisBilgileri.GirisId;

                comboBox9.Enabled = false;
                comboBox5.Enabled = false;
            }
        }
        public void GetDoktorList()
        {
            DoktorBLL doktorBLL = new DoktorBLL();
            dataGridView6.DataSource = null;
            dataGridView6.DataSource = doktorBLL.DoktorListele();
            dataGridView10.DataSource = null;
            dataGridView10.DataSource = doktorBLL.DoktorListele();
        }
        public void GetList()
        {
            TaniBLL taniBLL = new TaniBLL();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = taniBLL.Listele();
            if (dataGridView3.Columns.Count > 0)
            {
                this.dataGridView3.Columns["Muayenes"].Visible = false;
            }

        }
        public void GetHastaList()
        {
            HastaBLL hastaBLL = new HastaBLL();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = hastaBLL.Listele();
            if (dataGridView2.Columns.Count > 0)
            {
                this.dataGridView2.Columns["Randevus"].Visible = false;
                this.dataGridView2.Columns["Muayenes"].Visible = false;
            }

            dataGridView5.DataSource = null;
            dataGridView5.DataSource = hastaBLL.Listele();
            if (dataGridView5.Columns.Count > 0)
            {
                this.dataGridView5.Columns["Randevus"].Visible = false;
                this.dataGridView5.Columns["Muayenes"].Visible = false;
            }

            dataGridView8.DataSource = null;
            dataGridView8.DataSource = hastaBLL.Listele();
            if (dataGridView8.Columns.Count > 0)
            {
                this.dataGridView8.Columns["Muayenes"].Visible = false;
                this.dataGridView8.Columns["Randevus"].Visible = false;
            }

        }
        public void GetHastaCombo()
        {
            HastaBLL hastaBLL = new HastaBLL();
            comboBox4.DataSource = hastaBLL.Listele();
            comboBox4.DisplayMember = "Adi";
            comboBox4.ValueMember = "HastaId";

            if (GirisBilgileri.Tip == (int)GirisTip.Hasta)
            {
                comboBox4.SelectedValue = GirisBilgileri.GirisId;
                //comboBox4.Enabled = false;
            }
        }

        public void GetBugununHastalariList()
        {
            RandevuBLL randevuBLL = new RandevuBLL();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = randevuBLL.BugununRandevuListesi();

        }
        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TaniModel taniModel = new TaniModel();
            taniModel.Aciklama = textBox12.Text;
            taniModel.TaniId = Convert.ToInt32(textBox12.Tag);
            TaniBLL taniBLL = new TaniBLL();
            taniBLL.Guncelle(taniModel);
            GetList();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
        public void GetIlacList()
        {
            IlacBLL ilacBLL = new IlacBLL();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = ilacBLL.Listele();
            if (dataGridView4.Columns.Count > 0)
            {
                this.dataGridView4.Columns["Muayenes"].Visible = false;
            }

        }
        private void Button12_Click(object sender, EventArgs e)
        {
            IlacModel a = (IlacModel)dataGridView4.SelectedRows[0].DataBoundItem;
            textBox13.Text = a.IlacAdi;
            textBox16.Text = a.Dozaj;
            textBox17.Text = a.KullanimSuresi.ToString();
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            IlacModel a = (IlacModel)dataGridView4.SelectedRows[0].DataBoundItem;
            IlacBLL ilacBLL = new IlacBLL();
            ilacBLL.Sil(a.IlacId);
            GetIlacList();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            IlacModel ilacModel = new IlacModel();
            ilacModel.IlacAdi = textBox13.Text;
            ilacModel.KullanimSuresi = Convert.ToInt32(textBox17.Text);
            ilacModel.Dozaj = textBox16.Text;
            IlacBLL ilacBLL = new IlacBLL();
            ilacBLL.Kaydet(ilacModel);
            GetIlacList();
        }
        public void GetSaglikO()
        {
            SaglikOcagiBLL saglikOcagiBLL = new SaglikOcagiBLL();
            comboBox8.DataSource = saglikOcagiBLL.Listele();
            comboBox8.DisplayMember = "SaglikOcagiAd";
            comboBox8.ValueMember = "SaglikOcagiId";
        }
        private void Button15_Click(object sender, EventArgs e)
        {

        }
        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            MuayeneModel mm = new MuayeneModel();
            HastaModel h = (HastaModel)dataGridView5.SelectedRows[0].DataBoundItem;
            mm.HastaId = h.HastaId;
            mm.IlacId = Convert.ToInt32(comboBox3.SelectedValue);
            mm.TaniId = Convert.ToInt32(comboBox1.SelectedValue);
            mm.Sikayet = richTextBox1.Text;
            mm.DoktorId = Convert.ToInt32(comboBox9.SelectedValue);
            MuayeneBLL muayeneBLL = new MuayeneBLL();
            muayeneBLL.Kaydet(mm);
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            HastaModel h = (HastaModel)dataGridView8.SelectedRows[0].DataBoundItem;
            textBox24.Text = h.Adi;
            textBox23.Text = h.Soyadi;
            textBox22.Text = h.TcKimlik;
            textBox21.Text = h.AnneAd;
            textBox19.Text = h.BabaAd;
            textBox18.Text = h.Email;
            textBox24.Tag = h.HastaId;
            comboBox11.Items.Add(h.Cinsiyet);
            dateTimePicker3.Value = h.DogumTarihi;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            
            DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                HastaModel h = (HastaModel)dataGridView8.SelectedRows[0].DataBoundItem;
                HastaBLL hbll = new HastaBLL();
                hbll.Sil(h.HastaId);
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi!");
            }
            GetHastaList();
        }
        Bitmap image;

        private void Button7_Click_1(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image files (*.BMP;*.JPG;*.PNG) | *.BMP;*.JPG;*.PNG" + "|All files (*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox2.Image = (Image)image;
                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                string Base64Text = Convert.ToBase64String(imageArray);
                richTextBox3.Text = Base64Text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image files (*.BMP;*.JPG;*.PNG) | *.BMP;*.JPG;*.PNG" + "|All files (*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = (Image)image;
                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                string Base64Text = Convert.ToBase64String(imageArray);
                richTextBox2.Text = Base64Text;
            }
        }
        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RandevuModel randevuModel = new RandevuModel();
            randevuModel.DoktorId = Convert.ToInt32(comboBox5.SelectedValue);
            randevuModel.HastaId = Convert.ToInt32(comboBox4.SelectedValue);
            randevuModel.RandevuTarihi = dateTimePicker2.Value;
            RandevuBLL randevuBLL = new RandevuBLL();
            randevuBLL.Kaydet(randevuModel);
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                TaniModel taniModel = new TaniModel();
                taniModel.Aciklama = textBox14.Text;
                taniModel.TaniId = Convert.ToInt32(textBox14.Tag);
                TaniBLL taniBLL = new TaniBLL();
                taniBLL.Kaydet(taniModel);
                GetList();
                GetKayıtMesaji();
            }
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                TaniModel taniModel = new TaniModel();
                taniModel.Aciklama = textBox12.Text;
                taniModel.TaniId = Convert.ToInt32(textBox12.Tag);
                TaniBLL taniBLL = new TaniBLL();
                taniBLL.Guncelle(taniModel);
                GetList();
                GetGuncelleMesaji();
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button13_Click_1(object sender, EventArgs e)
        {

        }

        private void Button14_Click_1(object sender, EventArgs e)
        {

        }

        private void Button15_Click_1(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Button10_Click_1(object sender, EventArgs e)
        {

        }

        private void Button11_Click_1(object sender, EventArgs e)
        {

        }

        private void Button12_Click_1(object sender, EventArgs e)
        {

        }
        public void GetKayıtMesaji()
        {
            MessageBox.Show("Kayıt başarıyla gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void GetGuncelleMesaji()
        {
            MessageBox.Show("Güncelleme başarıyla gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                LoginModel loginModel = new LoginModel();
                loginModel.KullaniciAd = textBox1.Text + textBox2.Text;
                loginModel.KullaniciSifre = "1";
                loginModel.Tip = 1;
                DoktorModel doktorModel = new DoktorModel();
                doktorModel.Ad = textBox1.Text;
                doktorModel.Soyad = textBox2.Text;
                doktorModel.SaglikOcagiId = Convert.ToInt32(comboBox2.SelectedValue);
                DoktorBLL doktorBLL = new DoktorBLL();
                var a= doktorBLL.Kaydet(doktorModel);
                loginModel.GirisID = a;
                LoginBLL loginBLL = new LoginBLL();
                loginBLL.Kaydet(loginModel);
                GetDoktorList();
                GetKayıtMesaji();
            }
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {

            if (dataGridView6.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                DoktorModelList k = (DoktorModelList)dataGridView6.SelectedRows[0].DataBoundItem;
                DoktorBLL doktorBLL = new DoktorBLL();
                DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    doktorBLL.Sil(k.Id);
                    MessageBox.Show("Silme işlemi gerçekleştirildi!");
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi!");
                }
                GetDoktorList();
            }
        }

        private void Button14_Click_2(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                DoktorModelList d = (DoktorModelList)dataGridView6.SelectedRows[0].DataBoundItem;
                textBox15.Text = d.Adi;
                textBox18.Text = d.Soyadi;
                textBox18.Tag = d.Id;
                GetSaglikO();
            }
        }

        private void Button15_Click_2(object sender, EventArgs e)
        {
            if (textBox15.Text == "" || textBox18.Text == "" || comboBox8.SelectedItem == null)
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                DoktorModel doktorModel = new DoktorModel();
                doktorModel.Ad = textBox15.Text;
                doktorModel.Soyad = textBox18.Text;
                doktorModel.DoktorId = Convert.ToInt32(textBox18.Tag);
                doktorModel.SaglikOcagiId = Convert.ToInt32(comboBox8.SelectedValue);
                DoktorBLL doktorBLL = new DoktorBLL();
                doktorBLL.Guncelle(doktorModel);
                GetDoktorList();
                GetGuncelleMesaji();
            }
        }

        private void Button13_Click_2(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                IlacModel ilacModel = new IlacModel();
                ilacModel.IlacAdi = textBox9.Text;
                ilacModel.KullanimSuresi = Convert.ToInt32(textBox11.Text);
                ilacModel.Dozaj = textBox10.Text;
                IlacBLL ilacBLL = new IlacBLL();
                ilacBLL.Kaydet(ilacModel);
                GetIlacList();
                GetKayıtMesaji();
            }
        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            
            if (dataGridView4.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                IlacModel a = (IlacModel)dataGridView4.SelectedRows[0].DataBoundItem;
                IlacBLL ilacBLL = new IlacBLL();
                DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    ilacBLL.Sil(a.IlacId);
                    MessageBox.Show("Silme işlemi gerçekleştirildi!");
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi!");
                }
                GetIlacList();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || dateTimePicker1.Value == null)
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                RandevuModel randevuModel = new RandevuModel();
                randevuModel.HastaId = Convert.ToInt32(comboBox4.SelectedValue);
                randevuModel.DoktorId = Convert.ToInt32(comboBox5.SelectedValue);
                randevuModel.RandevuTarihi = dateTimePicker2.Value;
                RandevuBLL rndBLL = new RandevuBLL();
                rndBLL.Kaydet(randevuModel);
                GetKayıtMesaji();
            }
        }

        private void Button16_Click_1(object sender, EventArgs e)
        {
            if (textBox24.Text == "" && textBox23.Text == "" && textBox22.Text == "" && textBox20.Text == "" && textBox21.Text == "" && textBox19.Text == "" && dateTimePicker3.Value == null && comboBox11.SelectedItem == null)
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                HastaModel hastaModel = new HastaModel();
                hastaModel.HastaId = Convert.ToInt32(textBox24.Tag);
                hastaModel.Adi = textBox24.Text;
                hastaModel.Soyadi = textBox23.Text;

                if (textBox22.Text.Length == 11)
                {
                    hastaModel.TcKimlik = textBox22.Text;
                }
                else
                {
                    MessageBox.Show("Tc kimlik 11 hane olmalıdır!");
                }
                if (textBox20.Text.Contains("@"))
                {
                    if (textBox20.Text.Contains(".com"))
                    {
                        hastaModel.Email = textBox20.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir email adresi giriniz!");
                }

                hastaModel.Cinsiyet = comboBox11.SelectedItem.ToString();
                hastaModel.DogumTarihi = dateTimePicker3.Value;
                hastaModel.AnneAd = textBox21.Text;
                hastaModel.BabaAd = textBox19.Text;
                hastaModel.Resim = richTextBox1.Text;
                HastaBLL hBLL = new HastaBLL();
                hBLL.Guncelle(hastaModel);
                GetHastaList();
                GetGuncelleMesaji();
            }
        }
        private void Button7_Click_2(object sender, EventArgs e)
        {
            if (textBox8.Text == "" && textBox7.Text == "" && textBox5.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox6.Text == "" && dateTimePicker1.Value == null && comboBox7.SelectedItem == null)
            { MessageBox.Show("Boş alanları doldurunuz!"); }
            else
            {
                LoginModel loginModel = new LoginModel();
                loginModel.GirisID = Convert.ToInt32(textBox24.Tag);
                loginModel.KullaniciSifre = "1";
                loginModel.Tip = 2;
                HastaModel hastaModel = new HastaModel();
                hastaModel.Adi = textBox8.Text;
                hastaModel.Soyadi = textBox7.Text;
                if (textBox5.Text.Contains("@"))
                {
                    if (textBox5.Text.Contains(".com"))
                    {
                        hastaModel.Email = textBox5.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir email adresi giriniz!");
                }

                if (textBox3.Text.Length == 11)
                {
                    hastaModel.TcKimlik = textBox3.Text;
                    loginModel.KullaniciAd = textBox3.Text;
                }
                else
                {
                    MessageBox.Show("Tc kimlik 11 hane olmalıdır!");
                }

                hastaModel.Cinsiyet = comboBox7.SelectedItem.ToString();
                hastaModel.DogumTarihi = dateTimePicker1.Value;
                hastaModel.AnneAd = textBox4.Text;
                hastaModel.BabaAd = textBox6.Text;
                hastaModel.Resim = richTextBox2.Text;
                HastaBLL hBLL = new HastaBLL();
                var a = hBLL.Kaydet(hastaModel);
                loginModel.GirisID = a;
                LoginBLL loginBLL = new LoginBLL();
                loginBLL.Kaydet(loginModel);
                GetHastaList();
                GetKayıtMesaji();
            }
        }
        private void Button17_Click_1(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0 || richTextBox1.Text == "" || comboBox1.SelectedItem == null || comboBox3.SelectedItem == null || comboBox9.SelectedItem == null)
            {
                MessageBox.Show("Eksik bilgi girişi yaptınız!");
            }
            else
            {
                MuayeneModel mm = new MuayeneModel();
                HastaModel h = (HastaModel)dataGridView5.SelectedRows[0].DataBoundItem;
                mm.HastaId = h.HastaId;
                mm.IlacId = Convert.ToInt32(comboBox3.SelectedValue);
                mm.TaniId = Convert.ToInt32(comboBox1.SelectedValue);
                mm.Sikayet = richTextBox1.Text;
                mm.DoktorId = Convert.ToInt32(comboBox9.SelectedValue);
                MuayeneBLL muayeneBLL = new MuayeneBLL();
                muayeneBLL.Kaydet(mm);
                GetMuayeneList();
                GetKayıtMesaji();
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                TaniModel t = (TaniModel)dataGridView3.SelectedRows[0].DataBoundItem;
                textBox12.Text = t.Aciklama;
                textBox12.Tag = t.TaniId;
            }
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                TaniModel t = (TaniModel)dataGridView3.SelectedRows[0].DataBoundItem;
                TaniBLL taniBLL = new TaniBLL();
                DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    taniBLL.Sil(t.TaniId);
                    MessageBox.Show("Silme işlemi gerçekleştirildi!");
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi!");
                }
                GetList();
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız!");
            }
            else
            {
                IlacModel a = (IlacModel)dataGridView4.SelectedRows[0].DataBoundItem;
                textBox13.Text = a.IlacAdi;
                textBox16.Text = a.Dozaj;
                textBox17.Text = a.KullanimSuresi.ToString();
                textBox13.Tag = a.IlacId;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || textBox16.Text == "" || textBox17.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            else
            {
                IlacModel ilacModel = new IlacModel();
                ilacModel.IlacAdi = textBox13.Text;
                ilacModel.KullanimSuresi = Convert.ToInt32(textBox17.Text);
                ilacModel.Dozaj = textBox16.Text;
                ilacModel.IlacId = Convert.ToInt32(textBox13.Tag);
                IlacBLL ilacBLL = new IlacBLL();
                ilacBLL.Guncelle(ilacModel);
                GetIlacList();
                GetGuncelleMesaji();
            }
        }

        private void Button10_Click_2(object sender, EventArgs e)
        {
            HastaRandevuGecmisi();
        }


        public void HastaRandevuGecmisi()
        {
            RandevuBLL randevuBLL = new RandevuBLL();
            var list = randevuBLL.HastaGecmisRandevu(GirisBilgileri.GirisId);

            dataGridView9.DataSource = list;
        }

        private void TabPage8_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
