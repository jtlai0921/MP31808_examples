using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //匯入名稱空間

namespace Ex1604
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnOpen_Click(object sender, EventArgs e)
      {
         string sqlText = null, connString;
         OleDbDataAdapter daShow;
         DataSet ds = new DataSet();
         //Step1 -- 建立連線字串
         connString = "Provider = Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source = D:\C#Lab\DataBase\School.accdb";
         try
         {
            using (OleDbConnection conn =
               new OleDbConnection(connString))
            {
               conn.Open(); //開啟資料庫
               sqlText = "SELECT * FROM 課程";
               //step2 -- 建立DataAdapter物件來執行SQL敘述
               daShow = new OleDbDataAdapter(sqlText, conn);
               daShow.Fill(ds, "課程");//載入課程資料表
               readDataGridView.DataSource =
                  ds.Tables["課程"].DefaultView;
            }
         }
         catch (Exception)
         {
            MessageBox.Show("錯誤" + sqlText);
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         readDataGridView.AlternatingRowsDefaultCellStyle.BackColor =
            Color.YellowGreen;
      }
   }
}
