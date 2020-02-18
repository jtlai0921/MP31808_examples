using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1402
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Up)
         {
            lblState.Text = "向上";
            if (picShow.Top + picShow.Height <= 0)
               picShow.Top = picShow.Height;
            else
               picShow.Top -= 15;
         }
         else if (e.KeyCode == Keys.Down)
         {
            lblState.Text = "向下";
            if (picShow.Top >= this.Height)
               picShow.Top = 0 - picShow.Height;
            else
               picShow.Top += 15;
         }
         else if(e.KeyCode == Keys.F10)
         {            
            lblState.Text = "座標：" + (new Point(picShow.Right,
               picShow.Bottom)).ToString();
         }
         lblData.Text = $"按鍵值：{e.KeyValue.ToString()}";
      }
   }
}
