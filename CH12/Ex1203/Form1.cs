using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1203
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //設定字型
      private void btnFont_Click(object sender, EventArgs e)
      {
         dlgFont.ShowColor = true; //顯示色彩選擇
         dlgFont.Font = rtxtShow.Font; //取得系統中的字型
         dlgFont.Color = rtxtShow.ForeColor;//取得前景色彩
         if (dlgFont.ShowDialog() != DialogResult.Cancel)
         {
            //改變文字方塊的字型
            rtxtShow.Font = dlgFont.Font;
            //改變文字方塊的前景顏色
            rtxtShow.ForeColor = dlgFont.Color;
         }
      }

      //設定顏色
      private void btnColor_Click(object sender, EventArgs e)
      {
         dlgColor.AllowFullOpen = false;         
         dlgColor.ShowHelp = true;//顯示說明按鈕
         dlgColor.AnyColor = true;//顯示所有可用基本色彩
         dlgColor.Color = rtxtShow.ForeColor;

         //使用者如果按下確定鈕變更背景色彩
         if (dlgColor.ShowDialog() == DialogResult.OK)
         {
            rtxtShow.BackColor = dlgColor.Color;
         }
      }
   }
}
