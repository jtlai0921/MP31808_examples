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

namespace Ex1502
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         btnCopy.Enabled = false;
         btnDelete.Enabled = false;
      }

      //建立檔案
      private void btnCreate_Click(object sender, EventArgs e)
      {
         //指定路徑建立檔案
         string path =  @"D:\C#Lab\File\Test.txt";
         FileInfo createFile = new FileInfo(path);

         //以FileStream檔案串流物件配合Create()方法取得其資料
         FileStream fs = createFile.Create();
         fs.Close();//關閉檔案
      }

      //複製檔案
      private void btnCopy_Click(object sender, EventArgs e)
      {
         string path = @"D:\C#Lab\File\Test.txt";
         btnDelete.Enabled = true;//回復刪除鈕的作用
         //目的檔案「Text.txttmp」
         String tagPath = path + "tmp";
         FileInfo copyFile = new FileInfo(path);
         try
         {
            //以CopyTo方法複製檔案
            copyFile.CopyTo(tagPath); 
            txtShow.Text = path + "已複製";
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      //刪除檔案
      private void btnDelete_Click(object sender, EventArgs e)
      {
         string path = @"D:\C#Lab\File\Test.txttmp";
         FileInfo delFile = new FileInfo(path);
         if (delFile.Exists == false)//查看檔案是否存在
         {
            MessageBox.Show("無此檔案");
         }
         else
            delFile.Delete();//刪除檔案
      }

      //檢視檔案內容
      private void btnView_Click(object sender, EventArgs e)
      {
         btnCopy.Enabled = true;
         string path2 = @"D:\C#Lab\File";
         string fnShow = "檔案清單---<*.TXT>";
         try
         {
            //取得檔案路徑訊息
            DirectoryInfo currentDir = new DirectoryInfo(path2);
            //從指定路徑傳回指定的檔案類型
            FileInfo[] listFile = currentDir.GetFiles("*.txt*");
            //輸出檔案的相關標題
            string header = string.Format("{0, -13}{1, -8}{2, -10}"
               , "檔名","檔案長度", "修改日期");
            string title = fnShow + Environment.NewLine +
               header + Environment.NewLine;
            txtShow.Text = title;

            /* 讀取資料夾中有關於 --檔名(Name)、長度(Length)
               和修改日期(LastWriteTime) */
            foreach (FileInfo getInfo in listFile)
            {
               txtShow.Text += $"{getInfo.Name, -16}" +
                  $"{getInfo.Length.ToString(), -11}" +
                  $"{getInfo.LastWriteTime.ToShortDateString(),-10}"
                  + Environment.NewLine;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
