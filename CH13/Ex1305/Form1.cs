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

namespace Ex1305
{
   public partial class Form1 : Form
   {
      String ptrfile;//建立檔案指標，用來記錄建立檔案的路徑

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {        
         rtxtShow.Clear();//清除文字方塊
         this.Text = "文件1 -- 簡易記事本";

         //啟動字型子功能表項目「標楷體」、「粗體」核取記號有作用
         menuFontTp.CheckOnClick = true;
         menuBoldFont.CheckOnClick = true;
      }

      //「檔案」功能表的『開啟舊檔』項目
      private void menuOpenFile_Click(object sender, EventArgs e)
      {
         // 檔案的格式為純文字檔案
         dlgOpenFile.Filter =
            "文字檔(*.txt) | *.txt | 所有檔案(*.*) | *.*";

         dlgOpenFile.FilterIndex = 2;

         //取得原來的目錄，預設的檔案類型「純文字」
         dlgOpenFile.RestoreDirectory = true;
         dlgOpenFile.DefaultExt = "*.txt";
         dlgOpenFile.Title = "進入「開啟舊檔」交談窗";

         //按下「確定」鈕會進入『開啟舊檔』交談窗
         DialogResult result = dlgOpenFile.ShowDialog();
         if (result == DialogResult.OK)
         {
            ptrfile = dlgOpenFile.FileName;
            //LoadFile()方法載入純文字文件
            rtxtShow.LoadFile(ptrfile,
            RichTextBoxStreamType.PlainText);
            this.Text = String.Concat("檔案路徑-- ", ptrfile);
         }
      }
      

      //「檔案」功能表的『另存新檔』項目
      private void menuSaveAsFile_Click(object sender, EventArgs e)
      {
         dlgSaveFile.Filter =
            "文字檔(*.txt) | *.txt | 所有檔案(*.*) | *.*";
         dlgSaveFile.FilterIndex = 1;
         dlgSaveFile.RestoreDirectory = true;
         dlgSaveFile.DefaultExt = "*.txt";
         dlgSaveFile.Title = "進入「另存新檔」交談窗";

         //當使用者按下確認鍵時進行存檔動作
         DialogResult result = dlgSaveFile.ShowDialog();
         if (result == DialogResult.OK)
         {
            ptrfile = dlgSaveFile.FileName;

            /*如果檔案不存在，以UTF-8(UTF8Encoding)
            編碼方式來建立檔案 */
            StreamWriter swfile = new StreamWriter(
               ptrfile, false, Encoding.Default);

            swfile.Write(rtxtShow.Text);//寫入檔案
            swfile.Close();//關閉資料流
            this.Text = String.Concat("簡易記事本：", ptrfile);
         }
      }

      //依據有無勾選來決定文字方塊顯示的字型
      private void menuFontTp_CheckedChanged(object sender, EventArgs e)
      {
         if (menuFontTp.Checked)
            rtxtShow.Font = new Font("標楷體", 12);
         else
            rtxtShow.Font = new Font("微軟正黑體", 11);
      }

      //勾選後文字方塊會依據字型來變更為粗體
      private void menuBoldFont_CheckedChanged(object sender, 
            EventArgs e)
      {
         if (menuBoldFont.Checked)
         {
            rtxtShow.Font = new Font(rtxtShow.Font.Name,
               rtxtShow.Font.Size, FontStyle.Bold);
         }
         else
         {
            rtxtShow.Font = new Font(rtxtShow.Font.Name,
               rtxtShow.Font.Size, FontStyle.Regular);
         }
      }
   }
}
