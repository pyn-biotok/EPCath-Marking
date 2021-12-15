using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EPCath_Marking
{
    public partial class EPCath_DataBase : Form
    {
        public EPCath_DataBase()
        {
            InitializeComponent();
        }

        private void EPCath_DataBase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=C:/Users/Yakov/YandexDisk/My REPOSITORIES/EPCath_DataBases/EPCath.db");
            con.Open();
            string query = "SELECT* from Полный список";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
