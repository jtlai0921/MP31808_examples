using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1409
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         Pen greenPen = new Pen(Brushes.DarkGreen, 4);
         Pen bisPen = new Pen(Brushes.Bisque, 6);

         //將e物件指派給Graphics的物件gs
         Graphics gs = e.Graphics;

         //建立曲線座標1
         Point[] pts1 = {new Point(0, 50),
                       new Point(60, 90),
                       new Point(120, 30),
                       new Point(150, 75),
                       new Point(180, 80)};
         //建立曲線座標2
         Point[] pts2 = {new Point(25, 36),
            new Point(120, 50),
            new Point(125, 120),
            new Point(185, 50),
            new Point(190, 150),
            new Point(150, 170)};
         //繪製曲線         
         gs.DrawCurve(greenPen, pts1);
         gs.DrawClosedCurve(bisPen, pts2);
      }
   }
}
