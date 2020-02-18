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

namespace Ex1504
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnCreate_Click(object sender, EventArgs e)
      {
         //指定路徑儲存和檔案類型
         string path = @"D:\C#Lab\File\Demo.dat";

         //產生5個亂數，以numbers陣列儲存
         Random rand = new Random();
         byte[] numbers = new byte[5];
         rand.NextBytes(numbers);

         //以Create()方法來建立FileStream新串流物件
         FileStream outData = File.Create(path);

         //進行例外處理
         try
         {  /* using建立範圍，wr會自動呼叫Dispose()方法
               以BinaryWriter來寫入二進位資料
               將FileStream串流以UTF-8編碼方式寫入 */
            using (BinaryWriter wr = new BinaryWriter(outData))
            {
               //以位元方式將資料寫入檔案
               foreach (byte item in numbers)
               {
                  //Write()方法將值編碼成位元組
                  wr.Write(item);
                  txtShow.Text += $"{item, 5}";
               }
            }
            txtShow.Text += Environment.NewLine;

            //讀取位元資料
            byte[] dataInput = File.ReadAllBytes(path);
            foreach (byte item in dataInput)
            {
               txtShow.Text += $"{item, 5}";
            }
            txtShow.Text += Environment.NewLine;

         }
         catch (IOException)
         {
            MessageBox.Show(txtShow.Text + "不存在",
                "Ex1504", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
         }
      }
   }
}
