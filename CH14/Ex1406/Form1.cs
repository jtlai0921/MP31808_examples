using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1406
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Paint(object sender, PaintEventArgs pe)
      {
         //取得Image圖片，再以Graphics繪製
         Image img = Image.FromFile(
           "D:\\C#Lab\\Icon\\004.jpg");
         Graphics gs = pe.Graphics;//宣告Graphics物件
         gs.DrawImage(img, 0, 0);
         //將前述兩行合併成一行
         //pe.Graphics.DrawImage(img, 0, 0);
      }
   }
}