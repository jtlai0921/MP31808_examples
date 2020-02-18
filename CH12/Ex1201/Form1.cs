using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;   //處理檔案所匯入

namespace Ex1201
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //開啟舊檔 - OpenFileDialog
      private void btnOpen_Click(object sender, EventArgs e)
      {
         //檔案開啟的預設路徑，以純文字文件為開啟對象
         DlgOpenFile.InitialDirectory = "D:\\C#Lab\\CH12";
         DlgOpenFile.Filter =
            "文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
         //取得Filter篩選條件為2做設定, 預設為文字檔
         DlgOpenFile.FilterIndex = 1;
         DlgOpenFile.DefaultExt = "*.txt";
         DlgOpenFile.FileName = ""; //清除檔案名稱的字串

         //指定上一次開啟的路徑
         DlgOpenFile.RestoreDirectory = true;

         //當使用者按下OK鈕時，載入檔案
         if (DlgOpenFile.ShowDialog() == DialogResult.OK)
         {
            rtxtShow.LoadFile(DlgOpenFile.FileName,
               RichTextBoxStreamType.PlainText);
         }
      }

      //儲存檔案 - SaveFileDialog
      private void btnSave_Click(object sender, EventArgs e)
      {
         DlgSaveFile.Filter =
            "文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
         DlgSaveFile.FilterIndex = 1;
         //屬性RestoreDirectory取得原有目錄
         DlgSaveFile.RestoreDirectory = true;
         //設定副檔名為".txt"
         DlgSaveFile.DefaultExt = "*.txt";

         //當使用者按下OK鈕時，儲存檔案
         if (DlgSaveFile.ShowDialog() == DialogResult.OK)
         {
            //建立儲存檔案StreamWriter物件
            StreamWriter sw = new StreamWriter(
               DlgSaveFile.FileName, false, Encoding.Default);
            //寫入檔案，以close()方法關閉
            sw.Write(rtxtShow.Text); 
            sw.Close();
         }
      }
   }
}
