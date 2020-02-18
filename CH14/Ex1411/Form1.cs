using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Ex1411
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void picShow_Paint(object sender, PaintEventArgs e)
      {
         //繪圖物件
         Graphics gs = e.Graphics;
         //定義色彩
         Color colr1 = Color.FromArgb(200, 250, 0, 255);
         Color colr2 = Color.FromArgb(150, 15, 255, 0);

         //定義矩形
         Rectangle rect = new Rectangle(20, 20, 130, 90);

         //設定筆刷
         LinearGradientBrush brush = new
            LinearGradientBrush(rect, colr1, colr2, 60.0f);

         //矩形填滿線性漸層色彩
         gs.FillRectangle(brush, rect);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         picShow.BackColor = Color.Transparent;
      }

      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         //將e物件指派給Graphics的物件gs
         Graphics gs = e.Graphics;
         //繪製有陰影效果的字型
         Color brushColor = Color.FromArgb(150, Color.DarkRed);
         SolidBrush brushFt = new SolidBrush(brushColor);
         gs.DrawString("Hello!", new Font("Arial", 36),
            brushFt, 174.0f, 80.0f);
         gs.DrawString("Hello!", new Font("Arial", 36),
            Brushes.Cyan, 180.0f, 83.0f);

         gs.Dispose();
      }
   }
}
