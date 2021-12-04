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

namespace WA20211204
{
    public partial class FrmMain : Form
    {
        public string ConnectString { private get; set; }
        public FrmMain()
        {
            ConnectString =
               "Server = (localdb)\\MSSQLLocalDB; " +
               "Database = zoldseges; ";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) 
        {
            FillDGV();
        }

        private void FillDGV() 
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectString)) 
            {
                c.Open();

                var r = new SqlCommand(
                    "SELECT datum, nev, (mennyiseg * egysegAr) " +
                    "FROM zoldseg, eladas " +
                    "INNER JOIN eladas ON id = zoldseg " + 
                    $"WHERE nev LIKE '%{tbKereses.Text}%' " +
                    "ORDER BY datum; ", c).ExecuteReader();

                while (r.Read()) 
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }
        private void TbKereses_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbNem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
