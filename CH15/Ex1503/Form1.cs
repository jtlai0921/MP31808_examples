using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex1503
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //設定檔案路徑
      string path = @"D:\C#Lab\File\Sample.txt";

      //建立檔案，寫入4筆記錄
      private void btnCreate_Click(object sender, EventArgs e)
      {
         //以File靜態類別的Exists()方法判斷檔案是否存在
         if (File.Exists(path) == false)
         {
            using (StreamWriter note = File.CreateText(path))
            {
               //寫入4筆資料 
               note.WriteLine("990025, 李小蘭");
               note.WriteLine("990028, 張四端");
               note.WriteLine("990032, 王春嬌");
               note.WriteLine("990041, 林志鳴");
               note.Flush(); //清除緩衝區
               note.Close(); //關閉檔案
            }//using結束時自動呼叫note的Dispose()方法釋放資源

            MessageBox.Show("檔案已建立", "CH15");
         }
      }

      //讀取先前所建立的Sample.txt檔案
      private void btnOpen_Click(object sender, EventArgs e)
      {
         //開啟並讀取檔案
         StreamReader read = File.OpenText(path);
         //回傳下一個字元，直到-1表示已讀完
         while (true)
         {
            string data = read.ReadLine();
            if (data == null)
               break;
            txtShow.Text += data + "\r\n";
         }
      }
   }
}
