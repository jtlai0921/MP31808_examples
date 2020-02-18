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

namespace Ex1501
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      string path1 = @"D:\C#Lab\Testing";

      //檢視檔案目錄
      private void btnView_Click(object sender, EventArgs e)
      {
         //儲存要回傳的檔案路徑和檔案類型
         string path2 = @"D:\C#Lab\Icon";
         string fnShow = "檔案清單---<*.PNG>" +
            Environment.NewLine;

         //判斷資料夾是否存在，若是不存在會擲出例外情形
         try
         {
            //取得檔案路徑訊息
            DirectoryInfo currentDir = new DirectoryInfo(path2);
            //從指定路徑傳回指定的檔案類型
            FileInfo[] listFile = currentDir.GetFiles("*.png");
            //設定檔案的標題            
            string fnName = "檔名", fnLength = "檔案長度";
            string fnDate = "修改日期";
            string header = fnShow +
               $"{fnName,-20}{fnLength,-9}{fnDate,-11}"
               + Environment.NewLine;
            txtInfo.Text = header;

            /* 讀取資料夾中有關於 --檔名(Name)、長度(Length)
             * 和修改日期(LastWriteTime)*/
            foreach (FileInfo getInfo in listFile)
            {
               txtInfo.Text += $"{getInfo.Name,-20}" +
                  $"{getInfo.Length.ToString(),-9}" +
                  $"{getInfo.LastWriteTime.ToShortDateString()}\n";                  
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("無此資料夾" + ex.Message);
         }
      }

      private void btnAddDir_Click(object sender, EventArgs e)
      {
         try
         {
            //先判斷資料夾是否存在
            if (Directory.Exists(path1))            
               txtInfo.Text = "資料夾已經存在！";
            
            //建立新的資料夾
            DirectoryInfo newDir =
               Directory.CreateDirectory(path1);
            txtInfo.Text = "資料夾建立成功..." +
               Environment.NewLine +
               Directory.GetCreationTime(path1);

         }
         catch (Exception ex2)
         {
            MessageBox.Show("資料夾建置失敗！" + ex2.Message);
         }
      }

      private void btnDeleteDir_Click(object sender, EventArgs e)
      {
         DirectoryInfo newDir = new DirectoryInfo(path1);
         newDir.Delete();
         txtInfo.Text = "資料夾已經刪除";
      }
   }
}
