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

namespace Ex1408
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         //建立兩個畫筆
         Pen bluePen = new Pen(Color.Blue, 5);
         Pen redPen = new Pen(Brushes.Red, 6);
         //設定「虛線-點」
         bluePen.DashStyle = DashStyle.DashDot;
         //設定欲繪製線條的座標
         Point pt1 = new Point(10, 50);
         Point pt2 = new Point(100, 90);
         //繪製線條
         e.Graphics.DrawLine(bluePen, pt1, pt2);
         //設定起始和結束端點
         redPen.StartCap = LineCap.RoundAnchor;
         redPen.EndCap = LineCap.ArrowAnchor;
         //繪製有端點的線條
         e.Graphics.DrawLine(redPen,
             20.0F, 80.0F, 120.0F, 120.0F);
         //釋放畫筆佔用資料
         bluePen.Dispose();
         redPen.Dispose();
      }
   }
}
