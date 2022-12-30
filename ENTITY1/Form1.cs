using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;

namespace ENTITY1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DbSinavOgrenciEntities Db = new DbSinavOgrenciEntities();
        private void BtnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-0PJTRUB;Initial Catalog=DbSinavOgrenci;User ID=mithat;Password=1234;");
            SqlCommand Komut = new SqlCommand("SELECT * FROM TBLDERSLER",Baglanti);
            SqlDataAdapter Bagla= new SqlDataAdapter(Komut); 
            DataTable Dt = new DataTable();
            Bagla.Fill(Dt);
            dataGridView1.DataSource = Dt;


        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            //DbSinavOgrenciEntities Db= new DbSinavOgrenciEntities();
            // dataGridView1.DataSource = Db.TBLOGRENCI.ToList();
            // dataGridView1.Columns[3].Visible= false;
            // dataGridView1.Columns[4].Visible = false;
            OgrenciListele();
        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Db.TBLNOTLAR.ToList();
            NotListe();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI Ogrenci = new TBLOGRENCI();
            Ogrenci.Ad = TxtAd.Text;
            Ogrenci.Soyad = TxtSoyad.Text;
            Db.TBLOGRENCI.Add(Ogrenci);// türetmiş olduğum öğrenci  nesnesindekileri ekle
            Db.SaveChanges();   //değişiklikleri kaydet
            OgrenciListele();
            Temizle();
            MessageBox.Show("İşlem Başarılı");
           
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult A = MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "", MessageBoxButtons.YesNoCancel);
            if (A==DialogResult.OK)
            {
                int Id = Convert.ToInt32(TxtId.Text);//ıd değerini int olarak çevirdik
                var x = Db.TBLOGRENCI.Find(Id);//ogrenci tablosunda Id değerini bulduk
                Db.TBLOGRENCI.Remove(x);//bulunan değeri sildik
                MessageBox.Show("İşlem Başarılı");
                OgrenciListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bir Daha Yapmayacağın Bir İşe Kalkışma");
                Temizle();
            }

        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text!=""&& TxtSoyad.Text!=""&&TxtFoto.Text!="")
            {
                int Id = int.Parse(TxtId.Text);
                var y = Db.TBLOGRENCI.Find(Id);
                y.Ad = TxtAd.Text;
                y.Soyad = TxtSoyad.Text;
                y.FOTOGRAF = TxtFoto.Text;
                Db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                OgrenciListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen ÖğrenciAlanındaki Bütün Kutucukları Doldurduğunuzdan Emin Olunuz");
            }
        
        }
        private void OgrenciListele() 
        {
            var SorguOgrenci = from item in Db.TBLOGRENCI select new { item.Id, item.Ad, item.Soyad };
            dataGridView1.DataSource = SorguOgrenci.ToList();
        }
        private void NotListe() 
        {
            var NotListeSorgu = from item in Db.TBLNOTLAR
                        select new { item.NOTID, item.TBLOGRENCI.Ad,item.TBLOGRENCI.Soyad, item.DERS, item.SINAV1, item.SINAV2, item.SINAV3 };
            dataGridView1.DataSource = NotListeSorgu.ToList();
        }
        
       
        private void Temizle() 
        {
            TxtAd.Text = "";
            TxtDersAd.Text = "";
            TxtDersId.Text = "";
            TxtDurum.Text = "";
            TxtSoyad.Text = "";
            TxtFoto.Text = "";
            TxtId.Text = "";
        }

        private void BtnListeProcedure_Click(object sender, EventArgs e) //store procedure oluşturup onu model kısmına yükledik ve çağırdık
        {
            dataGridView1.DataSource = Db.NOTLISTESI();//store procedure 
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.TBLOGRENCI.Where(x => x.Ad == TxtAd.Text | x.Soyad==TxtSoyad.Text ).ToList(); //sorgu satırı
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = TxtAd.Text;
            var Degerler = from Item in Db.TBLOGRENCI where Item.Ad.Contains(aranan) select Item;// ad kutusunda text olunca tabloya listele
            dataGridView1.DataSource = Degerler.ToList();
        }

        private void BtnLinq_Click(object sender, EventArgs e)
        {
            if (RBtnAd.Checked==true)
            {
                List<TBLOGRENCI> Liste1 = Db.TBLOGRENCI.OrderBy(p => p.Ad).ToList();// orderby alfabetik sıralama yapar
                dataGridView1.DataSource = Liste1;
            }
            else if (radioButton1.Checked==true)
            {
                List<TBLOGRENCI> Liste2 = Db.TBLOGRENCI.OrderByDescending(x => x.Ad).ToList();//orderbydescending alfabetik sıralamanın tersini yapar
                dataGridView1.DataSource = Liste2;
            }
            else if (radioButton2.Checked==true)
            {
                List<TBLOGRENCI> Liste3=Db.TBLOGRENCI.OrderBy(y=>y.Ad).Take(5).ToList();  //take ilk 5 kaydı almaya yaradı 
                dataGridView1.DataSource=Liste3;
            }
            else if (radiobutton5.Checked==true)
            {
                List<TBLOGRENCI> Liste5 = Db.TBLOGRENCI.Where(x => x.Ad.StartsWith("a")).ToList();
                dataGridView1.DataSource = Liste5;
            }
             if (radioButton3.Checked == true)
             {
                List<TBLOGRENCI> Liste5 = Db.TBLOGRENCI.Where(x => x.Ad.EndsWith("a")).ToList();
                dataGridView1.DataSource = Liste5;
             }
            if (radioButton4.Checked==true)
            {
                bool Deger = Db.TBLOGRENCI.Any();//veri var mı ?
                MessageBox.Show(Deger.ToString(), "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (radioButton6.Checked == true)
            {
                int Toplam = Db.TBLOGRENCI.Count();// kaç tane veri var ?
                MessageBox.Show(Toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtSinav1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in Db.TBLNOTLAR
                        join d2 in Db.TBLOGRENCI
                        on d1.OGR equals d2.Id
                        join d3 in Db.TBLDERSLER
                        on d1.DERS equals d3.DERSID
                        select new
                        {
                            ÖGRENCİ = d2.Ad+ " " + d2.Soyad,
                            DERS =d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2=d1.SINAV2,
                            SINAV3=d1.SINAV3,   
                            ORTALAMA=d1.ORTALAMA,   
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
