using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//步驟1-匯入命名空間

namespace Ex1603
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnAccess_Click(object sender, EventArgs e)
      {
         //步驟2--建立連線Access資料庫的相關物件
         OleDbConnection conn; //資料庫的連線物件
         OleDbCommand cmd; //執行SQL指令的Command物件
         OleDbDataReader rdDisplay;
         string connString, sqlText;
         //建立連線字串
         connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source = D:\C#Lab\DataBase\" +
                "School.accdb";
         conn = new OleDbConnection(connString);
         conn.Open(); //開啟資料庫

         //步驟3--以Command物件cmd執行SQL指令,讀取所有欄位
         sqlText = "SELECT * FROM 系所";
         //sqlText = "SELECT TOP 3 * FROM 系所";
         //取得SQL指令
         cmd = new OleDbCommand(sqlText, conn);
         //步驟4--將查詢結果以DataReader顯示
         rdDisplay = cmd.ExecuteReader();
         string result = "";
         //for廻圈讀取欄位數
         for (int ct = 0; ct < rdDisplay.FieldCount; ct++)
         {
            result += rdDisplay.GetName(ct) + "\t";
         }
         string line = new string('-', 30);
         result += Environment.NewLine;
         result += line + '\n';
         result += Environment.NewLine;
         //讀取每一筆記錄
         while (rdDisplay.Read())
         {
            for (int ct = 0; ct < rdDisplay.FieldCount; ct++)
            {
               result += rdDisplay[ct].ToString() + "\t";
            }
            result += Environment.NewLine;
         }
         //關閉資料表的讀取, 關閉資料庫
         rdDisplay.Close();
         conn.Close();
         txtDbShow.Text = result;
      }
   }
}