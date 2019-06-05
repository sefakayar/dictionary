using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //veri işlemleri için
using System.Data.OleDb; // access için
using System.Windows.Forms; //form nesneleri için

namespace Sözlük
{
    class sefa
    {
        //global değişkenler
        string bcum = "provider=microsoft.jet.oledb.4.0;" +
            "data source=sozluk.mdb";

        public sefa() //constructer tanımlanmazsa static tanımlanması gerekir 
        { }

        public string tr_cevir(string kelime)
        {

            string sql = "select en from kelimeler where tr='" + kelime + "'";
            OleDbDataAdapter a = new OleDbDataAdapter(sql,bcum);
            DataTable t = new DataTable();
            a.Fill(t); //ayı t ye çevirir/aktarır.
            if (t.Rows.Count > 0)
         
                return t.Rows[0][0].ToString();
           
            else
            
                return "Kelime Bulunamadı ! ";
            
        }

        public string ing_cevir(string kelime)
        {
            string sql = "select tr from kelimeler where en='" + kelime + "'";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t); //ayı t ye çevirir/aktarır.
            if (t.Rows.Count > 0)
            {
                return t.Rows[0][0].ToString();
            }
            else
            {
                return "Kelime Bulunamadı ! ";
            }            
        }
        
        public void kelime_ekle(string tr,string en)
        {
            string sql = "insert into kelimeler (tr,en) " + "values ('" + tr + "','" + en + "')";
            OleDbConnection b = new OleDbConnection(bcum);
            OleDbCommand k = new OleDbCommand(sql,b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Tamamdır!");
            b.Close();

        }
    }
}
