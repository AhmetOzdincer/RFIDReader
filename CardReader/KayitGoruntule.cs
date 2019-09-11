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

namespace CardReader
{
    public partial class KayitGoruntule : Form
    {
        public KayitGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection con; 
        SqlDataReader dr;
        SqlCommand cmd;
        private void KayitGoruntule_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con = new SqlConnection("Data Source=DESKTOP-JC7B9JP;Initial Catalog=db_KimlikTanimlama;User ID=sa; password=ahmtozdncr1748");
            con.Open();
            cmd = new SqlCommand("Select * From tbl_KartBilgileri ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["RFID"].ToString());
                item.SubItems.Add(dr["Adi"].ToString());  
                item.SubItems.Add(dr["Mail"].ToString());
                item.SubItems.Add(dr["Telno"].ToString());
                item.SubItems.Add(dr["Bolum"].ToString());
                item.SubItems.Add(dr["Sinif"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }
    }
}
