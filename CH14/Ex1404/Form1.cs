using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1404
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_MouseDown(object sender, MouseEventArgs e)
      {
         txtEvent.Clear();
         txtPosition.Clear();

         string info = $"X = {e.X.ToString()}\t" +
            $"Y = {e.Y.ToString()}";

         switch (e.Button)   //判斷使用者接下那個按鍵
         {
            case MouseButtons.Left:
               txtEvent.Text = "按下滑鼠左鍵";
               //取得X, Y座標位置
               txtPosition.Text = info;
               break;

            case MouseButtons.Right:
               txtEvent.Text = "按下滑鼠右鍵";
               txtPosition.Text = info;
               break;

            case MouseButtons.None:
               txtEvent.Text = "沒有按下滑鼠";
               txtPosition.Text = info;
               break;
         }
      }

      //在表單上移動滑鼠
      private void Form1_MouseMove(object sender, MouseEventArgs e)
      {         
         txtEvent.Text = "滑鼠移動中...";
         txtPosition.Text = $"X = {e.X.ToString()}\t" +
            $"Y = {e.Y.ToString()}";
      }
   }
}
