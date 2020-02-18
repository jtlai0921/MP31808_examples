using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1002
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnShow_Click(object sender, EventArgs e)
      {
         string userAccount = txtAccount.Text;
         DateTime showTime = DateTime.Now;//取得目前時間

         //將取得的時間呼叫ToShortTimeString()方法轉時間為字串
         string saveTime = showTime.ToShortTimeString();

         //判斷文字方塊是否有字
         if (txtAccount.Text == "")
            MessageBox.Show("請輸入名字");

         else if (txtPassword.Text == "")
            MessageBox.Show("請輸入密碼");

         else
         {
            MessageBox.Show($"Hi! {userAccount}" + 
               $"\n現在時間：{saveTime}");
         }
      }
   }
}
