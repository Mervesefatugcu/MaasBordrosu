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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";

            SqlCommand cmdGiris = new SqlCommand();
            cmdGiris.CommandText = "SELECT * FROM Kullanici where KullaniciAdi='" + txtKullaniciAdi.Text + "' And KullaniciSifre='" + txtSifre.Text + "'";
            cmdGiris.Connection = cn;
            cmdGiris.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmdGiris.ExecuteReader();
            if (dr.Read())
            {
                MaasBordrosu frm = new MaasBordrosu();
                frm.Show();

                // this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifre veya kullanıcı adınız yanlış!");
            }
            cn.Close();
        }
    }
}
