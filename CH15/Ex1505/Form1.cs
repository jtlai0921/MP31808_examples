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

namespace Ex1505
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnWrite_Click(object sender, EventArgs e)
      {
         txtShow.Clear();
         //AppendText：資料附加至檔案結尾，檔案不存在會新建一個檔案
         using (StreamWriter sw = File.AppendText
               (@"D:\C#Lab\File\log.txt"))
         {
            logFile("Sample01", sw);
            logFile("Sample02", sw);
            sw.Flush(); //清除緩衝區的資料
            sw.Close(); //關閉檔案
         }
         //以OpenText()方法開啟檔案並讀取
         using (StreamReader sr = File.OpenText
               (@"D:\C#Lab\File\log.txt"))
         {
            RecordLog(sr);//呼叫RecordLog()方法讀取記錄
         }
      }

      //取得檔案記錄值寫入檔案
      private void logFile(string rdFile, TextWriter tw)
      {
         string record = $"記錄：{tw.NewLine} {rdFile}-- " +
            $"{DateTime.Now.ToLongDateString()} " +
            DateTime.Now.ToLongTimeString() + tw.NewLine;
         tw.WriteLine(record);
         txtShow.Text += record;
         tw.Flush(); //清除緩衝區的資料
      }

      //讀取記錄檔檔
      private void RecordLog(StreamReader sr)
      {
         string line = null;
         while ((line = sr.ReadLine()) != null)
         {
            Console.WriteLine($"{line}\n");
         }
         sr.Close();
      }
   }
}