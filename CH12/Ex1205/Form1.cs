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

/* 二個按鈕 -- 列印和預覽列印
 * 列印按鈕按下時會引發Click事件，讀取檔案
 * ShowDailog()方法的列印鈕會依據電腦上所設定的印表機列印
 * 預覽列印按同樣也會呼叫ShowDialog()方法來顯示預覽列印版面
 * PrintPage()事件列印文件(PrintDocument)呼叫Print()方法所引發
 * MeasureString()方法依據列印區域來描繪欲列印的文件並
 * 進一步統計每頁的字元數和頁數
 * EndPrint()事件於列印到最後一頁所引發，以訊息方塊顯示「列印完畢」
 * ReadPrintFile()讀取RTF格式檔案
 * 指定路徑和檔名後由FileStream來開啟檔案，
 * 配合using陳述式來指定範圍，再由StreamReader來讀取內容
 * readToPrint變數 - 存放檔案內容
 */
namespace Ex1205
{
   public partial class Form1 : Form
   {
      //儲存由檔案載入欲列印內容
      private string readToPrint, allContents;
      private Font printFont;//列印字型

      public Form1()
      {
         InitializeComponent();
      }

      //列印按鈕
      private void btnPrint_Click(object sender, EventArgs e)
      {
         ReadPrintFile();//呼叫載入檔案方法

         //啟用「頁數」選項按鈕，「選取範圍」選項按鈕
         DlgPrint.AllowSomePages = true;
         DlgPrint.AllowSelection = true;

         //列印文件指定給列印對話方塊
         DlgPrint.Document = DocumentPrt;
         DialogResult result = DlgPrint.ShowDialog();

         //開啟列印對話方塊按OK鈕就執行列印
         if (result == DialogResult.OK)
         {
            DocumentPrt.Print(); //執行列印
         }
      }

      //預覽列印
      private void btnPreview_Click(object sender, EventArgs e)
      {
         ReadPrintFile();
         CrlPrintPreview.Zoom = 0.25;//預覽列印的輸出比例
         CrlPrintPreview.UseAntiAlias = true;//啟用平滑字效果
         CrlPrintPreview.Document = DocumentPrt;
         CrlPrintPreview.Document.DocumentName =
            "Ex1205-Sample";
         DlgPrintPreview.Document = DocumentPrt;
         DlgPrintPreview.ShowDialog();//顯示預覽列印對話方塊

      }

      //列印到最後一頁所引發的事件
      private void DocumentPrt_EndPrint(object sender, 
            System.Drawing.Printing.PrintEventArgs e)
      {
         MessageBox.Show(DocumentPrt.DocumentName +
            " -- 完成列印", "列印文件");
      }

      //呼叫Print()方法所引發的事件
      private void DocumentPrt_PrintPage(object sender, 
            System.Drawing.Printing.PrintPageEventArgs ev)
      {
         int charsPerPage = 0;//統計每頁字元
         int morePages = 0; //統計頁數        
         Graphics gs = ev.Graphics;
         gs.MeasureString(readToPrint, printFont,
            ev.MarginBounds.Size,
            StringFormat.GenericTypographic,
            out charsPerPage, out morePages);

         //依據檔案內容繪製列印內容
         gs.DrawString(readToPrint, printFont,
            Brushes.Black, ev.MarginBounds,
            StringFormat.GenericTypographic);
         //移除已列印的字串
         readToPrint =
            readToPrint.Substring(charsPerPage);
         //當readToPrint大於零時，檢查是否要列印很多頁
         ev.HasMorePages = (readToPrint.Length > 0);
         if (!ev.HasMorePages)
            readToPrint = allContents;
      }

      //利用FileStream來讀取檔案並開啟
      private void ReadPrintFile()
      {
         //設定要讀取取的檔名和路徑
         string printFile = "Sample.txt";
         string filePath = @"D:\\C#Lab\\CH12\\";
         //讀取的檔名「Sample.txt」為列印文件的檔名
         DocumentPrt.DocumentName = printFile;
         //建立檔案並以Open開啟，以using指定範圍為唯讀
         using (FileStream stream = new FileStream(
            filePath + printFile, FileMode.Open))
         using (StreamReader reader = new
         StreamReader(stream)) //指定區段為唯讀
         {
            //allContents存放檔案內容
            allContents = reader.ReadToEnd();
         }
         readToPrint = allContents;
         printFont = new Font("標楷體", 20);
      }
   }
}
