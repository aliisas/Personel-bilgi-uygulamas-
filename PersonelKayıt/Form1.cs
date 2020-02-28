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

namespace PersonelKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //burada global olarak tanımladık, sqlden verilerimizi alma satırı
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6C7I4603;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        //burada yine global tanımladık, temizleme işlemi için
        void temizle()
        {
            txtid.Text = "";
            textad.Text = "";
            textsoyad.Text = "";
            meslek.Text = "";
            maas.Text ="";
            textsehir.Text ="";
            radioButton1.Checked = false;
            radioButton1.Checked = false;
            textad.Focus();//imleci textAd a odakladım
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabanıDataSet2.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet2.Tbl_Personel);

        }

        private void butliste_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet2.Tbl_Personel);
        }

        private void butkaydet_Click(object sender, EventArgs e)
        {

            //kayıt et işlemleri

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",textad.Text);//adı al
            komut.Parameters.AddWithValue("@p2",textsoyad.Text);//soyadı al
            komut.Parameters.AddWithValue("@p3",textsehir.Text);//sehir al
            komut.Parameters.AddWithValue("@p4",maas.Text);//maaşı al
            komut.Parameters.AddWithValue("@p5",meslek.Text);//meslek al
            komut.Parameters.AddWithValue("@p6",label8.Text);//medeni hali al
            komut.ExecuteNonQuery();//insert'e te delete update te eklenmesi gerekir
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "true";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "false";
            }
        }

        private void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {

        } 

        private void buttemizle_Click(object sender, EventArgs e)
        {
            temizle();  //bu temizleme işi veri girişi bittikten sonra tekrar veri girmek istersek tüm alanları sıfırlayıp
                        // ad kısmına imleci getiriyor
        }

        private void butistatistik_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //burada herhangi bir ismini üzerine tıklandığında tekrar onun bilgilerini ekran göstererek
            //bilgilerde revize işlemine yardımcı olur.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maas.Text=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }       

        private void dataGridView1_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {   //burasıda sadece evli mi bekar mı olduğunu göstermek için yazılan kod
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }

        private void butsil_Click(object sender, EventArgs e)
        {// kayıt sil işlemleri
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From  Tbl_Personel  Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1",txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");

        }

        private void butgüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutgün = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 Where Perid=@a7", baglanti);
            komutgün.Parameters.AddWithValue("@a1", textad.Text);
            komutgün.Parameters.AddWithValue("@a2", textsoyad.Text);
            komutgün.Parameters.AddWithValue("@a3", textsehir.Text);
            komutgün.Parameters.AddWithValue("@a4", maas.Text);
            komutgün.Parameters.AddWithValue("@a5", label8.Text);
            komutgün.Parameters.AddWithValue("@a6", meslek.Text);
            komutgün.Parameters.AddWithValue("@a7", txtid.Text);
            komutgün.ExecuteNonQuery();
            baglanti.Close();
           MessageBox.Show("Personel bilgisi güncellendi");
   
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
