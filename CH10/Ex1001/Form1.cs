using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //Windows Forms App須滙入

namespace Ex1001
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //按鈕按一下事件
      private void btnShow_Click(object sender, EventArgs e)
      {
         //取得目前的日期和時間，再以ToString()方法轉為字串
         lblDisplay.Text = DateTime.Now.ToString();
      }

      //結束應用程式
      private void btnEnd_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
