using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace CardReader
{
     class DB
    { 
        //Baglanti adında bir bağlantı oluşturdum

        public bool baglanti_kontrol()
        {
            try
            {
                 SqlConnection con;
                
                con = new SqlConnection("Provider=System.Data.SqlClient;Data Source=db_KimlikTanimlama;userıd=db_KimlikTanimlama;password=ahmtozdncr1748");
                con.Open();

                return true;
               
            }

            catch (Exception)
            {
                return false;
               
            }
        }
    }
}
