using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Win171108_EFKategoriUrunProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgEkran.AutoGenerateColumns = false;

            dgEkran.Columns["UrunID"].DataPropertyName = "UrunID";
            dgEkran.Columns["UrunAdi"].DataPropertyName = "UrunAdi";
            dgEkran.Columns["UrunMiktari"].DataPropertyName = "Miktar";
            dgEkran.Columns["KategoriAdi"].DataPropertyName = "KategoriAdi";


            btnEkle.Enabled = false;

            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                cmbKategoriFiltre.DataSource = db.Kategoriler.ToList();
                cmbKategoriFiltre.DisplayMember = "KategoriAdi";
                cmbKategoriFiltre.ValueMember = "KatID";
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {

            int katID = (int)cmbKategoriFiltre.SelectedValue;
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                var sonuc = from u in db.Urunler
                            where u.KatID == katID
                            select new
                            {
                                u.UrunID,
                                u.UrunAdi,
                                u.Miktar,
                                u.Kategoriler.KategoriAdi
                            };

                dgEkran.DataSource = sonuc.ToList();
            }

        }

        int id;

        private void btnAra_Click(object sender, EventArgs e)
        {
            id = 0;

            int.TryParse(Interaction.InputBox("Ürün ID", "Ürün Ara"), out id);

            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                try
                {
                    Urunler urn = db.Urunler.Find(id);

                    txtUrunId.Text = urn.UrunID.ToString();
                    txtUrunAdi.Text = urn.UrunAdi.ToString();
                    txtMiktar.Text = urn.Miktar.ToString();
                    cmbKategoriUrun.DataSource = db.Kategoriler.ToList();
                    cmbKategoriUrun.DisplayMember = "KategoriAdi";
                    cmbKategoriUrun.ValueMember = "KatID";
                    cmbKategoriUrun.SelectedValue = urn.KatID;

                    urunlisteleurun(id);
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Girdiğiniz ürün bulunamamıştır", "BİLGİ");
                }
            }
        }

        bool yenikayit = false;

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            yenikayit = true;
            textboxtemizle(grpbUrundetay);
            int sonID;
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                cmbKategoriUrun.DataSource = db.Kategoriler.ToList();
                cmbKategoriUrun.DisplayMember = "KategoriAdi";
                cmbKategoriUrun.ValueMember = "KatID";
                sonID = db.Urunler.Max(u => u.UrunID);
            }
            txtUrunId.Text = (sonID + 1).ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                Urunler urn = new Urunler();

                try
                {
                    urn.UrunAdi = txtUrunAdi.Text;
                    urn.Miktar = int.Parse(txtMiktar.Text);
                    urn.KatID = (int)cmbKategoriUrun.SelectedValue;
                }
                catch (Exception)
                {

                    MessageBox.Show("Eksik bilgi girdiniz", "UYARI");
                }

                db.Urunler.Add(urn);

                db.SaveChanges();

                urunlistelekategori((int)cmbKategoriUrun.SelectedValue);

                textboxtemizle(grpbUrundetay);

                btnEkle.Enabled = false;
                yenikayit = false;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!yenikayit)
            {
                int urnID = 0;
                if (dgEkran.SelectedRows.Count > 0)
                {
                    urnID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
                }

                using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
                {
                    Urunler urn = db.Urunler.Find(urnID);

                    urn.UrunAdi = txtUrunAdi.Text;
                    urn.Miktar = int.Parse(txtMiktar.Text);
                    urn.KatID = (int)cmbKategoriUrun.SelectedValue;

                    db.SaveChanges();

                }
                urunlistelekategori((int)cmbKategoriUrun.SelectedValue);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!yenikayit)
            {
                int urnID = 0;
                int katID = 0;
                if (dgEkran.SelectedRows.Count > 0)
                {
                    urnID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
                    katID = (int)cmbKategoriUrun.SelectedValue;
                }

                using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
                {
                    Urunler td = db.Urunler.Find(urnID);

                    db.Urunler.Remove(td);

                    db.SaveChanges();

                }

                urunlistelekategori(katID);
            }


        }

        private void dgEkran_SelectionChanged(object sender, EventArgs e)
        {
            int urnID = 0;


            if (dgEkran.SelectedRows.Count > 0)
            {
                urnID = (int)dgEkran.SelectedRows[0].Cells[0].Value;

                using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
                {
                    Urunler urn = db.Urunler.Find(urnID);

                    txtUrunAdi.Text = urn.UrunAdi.ToString();
                    txtMiktar.Text = urn.Miktar.ToString();
                    txtUrunId.Text = urn.UrunID.ToString();
                    cmbKategoriUrun.DataSource = db.Kategoriler.ToList();
                    cmbKategoriUrun.DisplayMember = "KategoriAdi";
                    cmbKategoriUrun.ValueMember = "KatID";
                    cmbKategoriUrun.SelectedValue = urn.KatID;
                }

            }


        }

        private void textboxtemizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textboxtemizle(item);
                }

            }
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                cmbKategoriUrun.DataSource = db.Kategoriler.ToList();
                cmbKategoriUrun.DisplayMember = "KategoriAdi";
                cmbKategoriUrun.ValueMember = "KatID";
            }
        }

        private void urunlisteleurun(int urunID)
        {
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                var sonuc = from u in db.Urunler
                            where u.UrunID == urunID
                            select new
                            {
                                u.UrunID,
                                u.UrunAdi,
                                u.Miktar,
                                u.Kategoriler.KategoriAdi
                            };

                dgEkran.DataSource = sonuc.ToList();
                dgEkran.SelectedRows[0].Selected = true;
            }
        }

        private void urunlistelekategori(int katID)
        {
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                var sonuc = from u in db.Urunler
                            where u.KatID == katID
                            select new
                            {
                                u.UrunID,
                                u.UrunAdi,
                                u.Miktar,
                                u.Kategoriler.KategoriAdi
                            };

                dgEkran.DataSource = sonuc.ToList();
                dgEkran.SelectedRows[0].Selected = true;
            }
        }

        private void btnTumUrunler_Click(object sender, EventArgs e)
        {
            using (KategoriUrunDbEntities db = new KategoriUrunDbEntities())
            {
                var sonuc = from u in db.Urunler
                            select new
                            {
                                u.UrunID,
                                u.UrunAdi,
                                u.Miktar,
                                u.Kategoriler.KategoriAdi
                            };

                dgEkran.DataSource = sonuc.ToList();
            }
        }
    }
}

