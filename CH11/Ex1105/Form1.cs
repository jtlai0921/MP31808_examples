using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1105
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //計時按鈕
      private void btnStart_Click(object sender, EventArgs e)
      {
         //按下按鈕啟動計時器
         tmrReckon.Start();
         //讓「開始計時」和「離開」按鈕暫時沒有作用
         btnStart.Enabled = false;
         btnExit.Enabled = false;
      }

      //Timer的Tick事件
      private void tmrReckon_Tick(object sender, EventArgs e)
      {
         prbTimeBar.Increment(5);  //顯示進度列的目前位置

         //串連進度列以文字顯示
         lblInfo.Text = String.Format
            ($"{prbTimeBar.Value}% 已經完成");
         
         //判斷最大值和實際進度相等時表示完成
         if (prbTimeBar.Value == prbTimeBar.Maximum)
         {
            btnStart.Enabled = true;//恢復按鈕的作用
            btnExit.Enabled = true;
            //停止計時器
            tmrReckon.Stop();
         }
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
