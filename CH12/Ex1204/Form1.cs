using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Ex1204
{
   public partial class Form1 : Form
   {
      Font fontPrint; //Font物件

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         rtxtShow.LoadFile("D:\\C#Lab\\CH12\\Demo.rtf");
      }

      //列印按鈕
      private void btnPrint_Click(object sender, EventArgs e)
      {
         try
         {
            document.Print(); //1.進行列印
            document.DocumentName = "列印文件";
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      //列印文件document正在列印所發生的事件
      private void document_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs pageArgs)
      {
         Graphics g = pageArgs.Graphics;//2-1.宣告繪圖物件g
         //設定新的字型
         fontPrint = new Font("標楷體", 12);
         int morePages = 0; //計算每份文件頁數
         int OnPageChars = 0;//計算每頁字元數
         //2-2.測量要繪製的字串
         g.MeasureString(rtxtShow.Text,
            fontPrint, pageArgs.MarginBounds.Size,
            StringFormat.GenericTypographic,
            out OnPageChars, out morePages);
         //2-3.繪製邊界內的字型
         g.DrawString(rtxtShow.Text, fontPrint,
            Brushes.Black, pageArgs.MarginBounds,
            new StringFormat());
      }
   }
}
