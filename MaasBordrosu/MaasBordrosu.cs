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
    public partial class MaasBordrosu : Form
    {
        public MaasBordrosu()
        {
            InitializeComponent();
        }

        private void personelBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelBilgileri frmpersonel = new PersonelBilgileri();
            frmpersonel.Show();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {

           
            int PersonelId = Convert.ToInt32(txtPersonelID.Text);
            decimal BrutUcret1 = Convert.ToDecimal(txtDönem.Text);
            //AGI
           decimal AgiKatsayisi = ((BrutUcret1 * Convert.ToDecimal(0.5)) + (BrutUcret1 * Convert.ToDecimal(0.1 )* (1)) + (BrutUcret1 * Convert.ToDecimal(0.075) * 1)) *Convert.ToDecimal( 0.15);

            //SSKPrimiIsciPayi
            decimal SSKPrimiIsciPayi;
            SSKPrimiIsciPayi = BrutUcret1 *Convert.ToDecimal (0.14);

            //IssizlikSigortasiIsciPayi
           decimal IssizlikSigortasiIsciPayi;
            IssizlikSigortasiIsciPayi = BrutUcret1 *Convert.ToDecimal(0.01);


            //GelirVergisiMatrahi
            decimal GelirVergisiMatrahi;
            GelirVergisiMatrahi = BrutUcret1 - (SSKPrimiIsciPayi + IssizlikSigortasiIsciPayi);

            //GelirVergisi
            decimal GelirVergisi;
            GelirVergisi = GelirVergisiMatrahi * Convert.ToDecimal(0.15);

            //DamgaVergisi
            decimal DamgaVergisi;
            DamgaVergisi = BrutUcret1 * Convert.ToDecimal (0.00759);

            //KesintilerToplami
            decimal KesintilerToplami;
            KesintilerToplami = SSKPrimiIsciPayi + IssizlikSigortasiIsciPayi + GelirVergisi + DamgaVergisi;

            // OdenecekGelirVergisi
            decimal OdenecekGelirVergisi;
            OdenecekGelirVergisi = GelirVergisiMatrahi * Convert.ToDecimal(0.15);

            //NetÜcret
            decimal NetUcret;
            NetUcret = BrutUcret1 - KesintilerToplami + AgiKatsayisi;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";
            cn.Open();
            SqlCommand cmdMaasBordro = new SqlCommand("INSERT INTO Bordro(PersonelID,BrutUcret,SskIsciPayi,GelirVergisiMatrahi,GelirVergisi,DamgaVergisi,Agi,OdenecekGelirVergisi,KesintilerToplami,NetUcret) values (@personelid,@brütücret,@ssk,@gvm,@gv,@dv,@agi,@odenecekgv,@kesintilertoplami,@netücret)",cn);
            cmdMaasBordro.Parameters.AddWithValue("@personelid", PersonelId);
            cmdMaasBordro.Parameters.AddWithValue("@brütücret",BrutUcret1);
            cmdMaasBordro.Parameters.AddWithValue("@ssk",SSKPrimiIsciPayi);
            cmdMaasBordro.Parameters.AddWithValue("@gvm", GelirVergisiMatrahi);
            cmdMaasBordro.Parameters.AddWithValue("@gv", GelirVergisi);
            cmdMaasBordro.Parameters.AddWithValue("@dv", DamgaVergisi);
            cmdMaasBordro.Parameters.AddWithValue("@agi", AgiKatsayisi);
            cmdMaasBordro.Parameters.AddWithValue("@odenecekgv", OdenecekGelirVergisi);
            cmdMaasBordro.Parameters.AddWithValue("@kesintilertoplami", KesintilerToplami);
            cmdMaasBordro.Parameters.AddWithValue("@netücret", NetUcret);

           cmdMaasBordro.ExecuteNonQuery();
            cn.Close();

            SqlDataAdapter daMaasBordrosu = new SqlDataAdapter("SELECT * FROM Bordro", cn);
            DataSet dsMaasBordro = new DataSet();
            cn.Open();
            daMaasBordrosu.Fill(dsMaasBordro);
            dgvMaasBordrosu.DataSource = dsMaasBordro.Tables[0].DefaultView;
            cn.Close();


        }






        private void MaasBordrosu_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";
            SqlDataAdapter daMaasBordrosu = new SqlDataAdapter("SELECT * FROM Bordro", cn);
            DataSet dsMaasBordro = new DataSet();
            cn.Open();
            daMaasBordrosu.Fill(dsMaasBordro);
            dgvMaasBordrosu.DataSource = dsMaasBordro.Tables[0].DefaultView;
            cn.Close();
        }

        private void personelMaaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelMaas frmPersonelMaas = new PersonelMaas();
            frmPersonelMaas.Show();
        }

        private void yetkiliKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliKullanici frmYetkiliKullanici = new YetkiliKullanici();
            frmYetkiliKullanici.Show();
        }
    }
}