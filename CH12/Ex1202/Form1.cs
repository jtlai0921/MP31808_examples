using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1202
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         //指定要瀏覽的資料夾為D碟
         DlgFolderBrowser.SelectedPath = @"D:\";
         //瀏覽資料夾的提示文字
         DlgFolderBrowser.Description = "選取要瀏覽的資料夾";
         //開啟檔案對話方塊設定的標題
         DlgOpenFile.Title = "開啟舊檔";
      }

      private void btnOpen_Click(object sender, EventArgs e)
      {
         bool fileOpened = false;//判斷檔案是否開啟
         string openFileName;
         //要開啟的檔案路徑
         DlgOpenFile.InitialDirectory = "D:\\C#Lab\\CH12";

         //要開啟的檔案格式為RTF
         DlgOpenFile.Filter =
            "RTF格式(*.RTF)|*.RTF|所有檔案(*.*)|*.*";
         DlgOpenFile.FilterIndex = 1;
         DlgOpenFile.DefaultExt = "*.RTF";
         
         DlgFolderBrowser.ShowDialog(); //開啟瀏覽資料夾

         if (!fileOpened)//將開啟檔案的預設路徑為瀏覽路徑
         {
            DlgFolderBrowser.SelectedPath =
               DlgOpenFile.InitialDirectory;
            DlgOpenFile.FileName = null;
         }
         DialogResult result = DlgOpenFile.ShowDialog();

         /* if敘述來確定使用者按下「開啟檔案對話方塊」的確定鈕時，
            載入指定的RTF格式到文字方塊中 */
         if (result == DialogResult.OK)
         {
            openFileName = DlgOpenFile.FileName;
            rtxtShow.LoadFile(DlgOpenFile.FileName,
               RichTextBoxStreamType.RichText);
            btnOpen.Text = "已載入RTF檔";
            fileOpened = true;
         }
      }
   }
}
