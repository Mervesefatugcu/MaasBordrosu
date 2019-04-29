using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordrosu
{
    public partial class PersonelBilgileri : Form
    {
       
        public PersonelBilgileri()
        {
            InitializeComponent();
          
        }
       
        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";
            SqlDataAdapter daMedeniDurum = new SqlDataAdapter("SELECT DISTINCT MedeniDurumID From MedeniDurum", cn);
            DataSet dsMedeniDurum = new DataSet();
            cn.Open();
            daMedeniDurum.Fill(dsMedeniDurum);
            cn.Close();
            cmbMedeniDurum.DataSource = dsMedeniDurum.Tables[0].DefaultView;
            // cmbMedeniDurum.DisplayMember = "MedeniDurum";
            cmbMedeniDurum.ValueMember = "MedeniDurumID";



            SqlDataAdapter daEsCalismaDurumu = new SqlDataAdapter("SELECT DISTINCT EsCalismaDurumID From EsCalismaDurumu", cn);
            DataSet dsEsCalismaDurumu = new DataSet();
            cn.Open();
            daEsCalismaDurumu.Fill(dsEsCalismaDurumu);
            cn.Close();
           cmbEsCalismaDurumu.DataSource = dsEsCalismaDurumu.Tables[0].DefaultView;
            // cmbEsCalısmaDurumu.DisplayMember = "EsCalismaDurum";
            cmbEsCalismaDurumu.ValueMember = "EsCalismaDurumID";

            SqlDataAdapter daCocukSayisi = new SqlDataAdapter("SELECT DISTINCT CocukSayisiID From CocukSayisi", cn);
            DataSet dsCocukSayisi = new DataSet();
            cn.Open();
            daCocukSayisi.Fill(dsCocukSayisi);
            cn.Close();
            cmbCocukSayisi.DataSource = dsCocukSayisi.Tables[0].DefaultView;
            //cmbCocukSayisi.DisplayMember = "CocukSayisi";
            cmbCocukSayisi.ValueMember = "CocukSayisiID";

            SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT * From Personel", cn);
            DataSet dsPersonel = new DataSet();
            cn.Open();
            daPersonel.Fill(dsPersonel);
            cn.Close();
            dgvPersonelBilgileri.DataSource = dsPersonel.Tables[0].DefaultView;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            int medenidurum = Convert.ToInt32(cmbMedeniDurum.Text);
            int cocuksayisi = Convert.ToInt32(cmbCocukSayisi.Text);
            int esdurumu = Convert.ToInt32(cmbEsCalismaDurumu.Text);

            SqlConnection cn = new SqlConnection();
             cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";
            cn.Open();
            SqlCommand cmdPersonel = new SqlCommand( "INSERT INTO Personel(Ad,Soyad,MedeniDurumID,CocukSayisiID,EsCalismaDurumu,GirisTarih) values (@ad,@soyad,@medenidurum,@cocuksayisi,@escalismadurumu,@tarih)",cn);
            cmdPersonel.Parameters.AddWithValue("@ad",txtPersonelAd.Text);
            cmdPersonel.Parameters.AddWithValue("@soyad", txtPersonelSoyad.Text);
            cmdPersonel.Parameters.AddWithValue("@medenidurum",cmbMedeniDurum.Text);
            cmdPersonel.Parameters.AddWithValue("@cocuksayisi",cmbCocukSayisi.Text);
            cmdPersonel.Parameters.AddWithValue("@escalismadurumu",cmbEsCalismaDurumu.Text);
            cmdPersonel.Parameters.AddWithValue("@tarih",dtGirisTarihi.Value);

            cmdPersonel.ExecuteNonQuery();
            MessageBox.Show("Kayıt gerçekleştirildi.");
            cn.Close();

            SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT * FROM Personel",cn);
            DataSet dsPersonel = new DataSet();
            cn.Open();
            daPersonel.Fill(dsPersonel);
            dgvPersonelBilgileri.DataSource = dsPersonel.Tables[0].DefaultView;
            cn.Close();


            
          

        }
    }
    
}
