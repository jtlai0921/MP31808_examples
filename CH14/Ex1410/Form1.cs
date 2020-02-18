using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1410
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         Pen pen1 = new Pen(Brushes.Blue, 4);
         Pen pen2 = new Pen(Brushes.Red, 3);
         Pen pen3 = new Pen(Brushes.Green, 4);

         //將e物件指派給Graphics的物件gs
         Graphics gs = e.Graphics;

         //繪製矩形
         gs.DrawRectangle(pen1, 20, 40, 100, 50);

         //繪製楕圓形
         gs.DrawEllipse(pen2, 80.0f, 100.0f, 100, 50);

         //產生多邊形的座標
         Point[] pts = {new Point(350, 200),
                       new Point(200, 200),
                       new Point(200, 150),
                       new Point(250, 50),
                       new Point(300, 80)};
         //繪製多邊形
         gs.DrawPolygon(pen3, pts);

         //繪製有陰影效果的字型
         Color brushColor = Color.FromArgb(150, Color.DarkRed);
         SolidBrush brushFt = new SolidBrush(brushColor);
         gs.DrawString("Hello!", new Font("Arial", 36),
            brushFt, 154.0f, 210.0f);
         gs.DrawString("Hello!", new Font("Arial", 36),
            Brushes.Cyan, 160.0f, 212.0f);

         gs.Dispose();
      }
   }
}
