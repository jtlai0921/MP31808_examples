using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1407
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         Image bkground = Image.FromFile(
           "D:\\C#Lab\\Icon\\004.jpg");
         Label Show = new Label(); //產生標籤控制項         
         Show.Size = bkground.Size;//取得圖片大小
         Show.Image = bkground;    //依圖片大小顯示
         //產生繪圖物件 
         Graphics gs = Show.CreateGraphics();
         Controls.Add(Show);//加入控制項
         gs.Dispose();//釋放Graphics佔用的資源
      }
   }
}
