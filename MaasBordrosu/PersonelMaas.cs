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
    public partial class PersonelMaas : Form
    {
        public PersonelMaas()
        {
            InitializeComponent();
        }

        private void PersonelMaas_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-385EUC0\\SQLEXPRESS;Initial Catalog=MaasBordro;Integrated Security=true";
            SqlDataAdapter daMaas = new SqlDataAdapter("SELECT * FROM PersonelMaas",cn);
            DataSet dsMaas = new DataSet();
            cn.Open();
            daMaas.Fill(dsMaas);
            cn.Close();
            dgvMaas.DataSource = dsMaas.Tables[0].DefaultView;


        }
    }
}
