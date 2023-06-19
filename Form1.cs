using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {

        Kumbara kumbara = new Kumbara();
        public double ToplamParaHacmi;
        Banknote ikiYuz = new Banknote
        {
            Adi = BanknoteAdi.IkiYuzLira.ToString(),
            Boy = 160,
            En = 72,
            Degeri = 200,




        };
        Banknote Yuz = new Banknote
        {
            Adi = BanknoteAdi.YuzLira.ToString(),
            Boy = 154,
            En = 72,
            Degeri = 100

        };
        Banknote Elli = new Banknote
        {
            Adi = BanknoteAdi.ElliLira.ToString(),
            Boy = 148,
            En = 68,
            Degeri = 50


        };

        Banknote yirmi = new Banknote
        {
            Adi = BanknoteAdi.YirmiLira.ToString(),
            Boy = 142,
            En = 68,
            Degeri = 20

        };
        Banknote on = new Banknote
        {
            Adi = BanknoteAdi.OnLira.ToString(),
            Boy = 136,
            En = 64,
            Degeri = 10

        };
        Banknote bes = new Banknote
        {
            Adi = BanknoteAdi.BesLira.ToString(),
            Boy = 130,
            En = 64,
            Degeri = 5

        };
        public Form1()
        {
            InitializeComponent();
            cmbBankNote.Items.AddRange(Enum.GetNames(typeof(BanknoteAdi)));
            cmbBankNote.Items.AddRange(Enum.GetNames(typeof(CoinAdi)));
            kumbara.kirilmaSayisi = 0;
            kumbara.yapistiMi = false;
            kumbara.ParaListesi = new List<string>();

        }

        private void btnParaAt_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;

            pictureBox1.Image = Properties.Resources.dolu;
            imgBankNote.Refresh();
            imgBankNote.Visible = false;
            btnkir.Visible = true;
            kumbara.ParaListesi.Add(cmbBankNote.Text);
            listBox1.Items.Add(string.Format(cmbBankNote.Text));
            lblToplamHacim.Text = "Toplam Para Hacmi" + ToplamParaHacmi.ToString();

            if (ToplamParaHacmi > kumbara.kumbaraHacmi)
            {
                throw new Exceptions();
            }
        }

        private void cmbBankNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            Banknote banknote = new Banknote();
            Coin coin = new Coin();
            imgBankNote.Visible = true;

            BanknoteAdi cikacakbanknote;
            bool sonuc = Enum.TryParse<BanknoteAdi>(cmbBankNote.Text, out cikacakbanknote);

            if (sonuc)
            {
                banknote.BanknoteAdi = (BanknoteAdi)Enum.Parse(typeof(BanknoteAdi), cmbBankNote.Text);
                switch (banknote.BanknoteAdi)
                {
                    case BanknoteAdi.IkiYuzLira:
                        imgBankNote.Image = Properties.Resources._200;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += ikiYuz.Hacim();
                        break;
                    case BanknoteAdi.YuzLira:
                        imgBankNote.Image = Properties.Resources._100;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += Yuz.Hacim();
                        break;
                    case BanknoteAdi.ElliLira:
                        imgBankNote.Image = Properties.Resources._50;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += Elli.Hacim();
                        break;
                    case BanknoteAdi.YirmiLira:
                        imgBankNote.Image = Properties.Resources._20;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += yirmi.Hacim();
                        break;
                    case BanknoteAdi.OnLira:
                        imgBankNote.Image = Properties.Resources._10;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += on.Hacim();
                        break;
                    case BanknoteAdi.BesLira:
                        imgBankNote.Image = Properties.Resources._5;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        ToplamParaHacmi += bes.Hacim();
                        break;
                    default:
                        break;
                }
            }

            else
            {
                coin.CoinAdi = (CoinAdi)Enum.Parse(typeof(CoinAdi), cmbBankNote.Text);

                switch (coin.CoinAdi)
                {
                    case CoinAdi.BirLira:
                        imgBankNote.Image = Properties.Resources._1Lira;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;
                    case CoinAdi.ElliKurus:
                        imgBankNote.Image = Properties.Resources._50kurus;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;
                    case CoinAdi.YirmiBesKurus:
                        imgBankNote.Image = Properties.Resources._25kurus;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;
                    case CoinAdi.OnKurus:
                        imgBankNote.Image = Properties.Resources._10kurus;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;
                    case CoinAdi.BesKurus:
                        imgBankNote.Image = Properties.Resources._5kurus;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;
                    case CoinAdi.BirKurus:
                        imgBankNote.Image = Properties.Resources._1kurus;
                        imgBankNote.Refresh();
                        imgBankNote.Visible = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnkir_Click(object sender, EventArgs e)
        {
            string text = "";
            if (kumbara.kirilmaSayisi < 1)
            {
                text = "Kumbarayı Kırmak İstediğinize Emin  misiniz";
                pictureBox1.Image = Properties.Resources.kiriliyor;
                MessageBox.Show(text, "Kumbarayı Kır", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (MessageBoxButtons.OK == 0)
                {

                    kumbara.Break();
                    pictureBox1.Image = Properties.Resources.kirik;
                    btnYapistir.Visible = true;
                    btnkir.Visible = false;
                    btnParaAt.Visible = false;
                    kumbara.kirilmaSayisi = kumbara.kirilmaSayisi + 1;
                    listBox1.Visible = true;
                    ToplamParaHacmi = 0;



                }
            }
            else
            {
                text = "Kumbara bir daha yapıştırılmaz!Son Kez Kırabilirsiniz Devam Etmek İstiyor musunuz?";
                MessageBox.Show(text, "Kumbarayı Kır", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                btnYapistir.Visible = false;

                if (MessageBoxButtons.OK == 0)
                {

                    kumbara.Break();
                    pictureBox1.Image = Properties.Resources.kirik;
                    btnkir.Visible = false;
                    btnParaAt.Visible = false;
                    listBox1.Visible = true;




                }

            }

        
    }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            kumbara.yapistiMi = true;
            pictureBox1.Image = Properties.Resources.bos;
            btnYapistir.Visible = false;
            btnParaAt.Visible = true;
            imgBankNote.Visible = false;
            listBox1.Visible = false;
            listBox1.Items.Clear();
            ToplamParaHacmi = 0;
        }
    }
}
