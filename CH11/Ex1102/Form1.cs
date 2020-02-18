using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex1102
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         //第一個linkLabel1做屬性設定，連結網頁，設定超連結顏色
         lnkGetIP.LinkColor = Color.DarkOrchid;

         //設定連結，未放開滑鼠前所顯示的顏色
         lnkGetIP.ActiveLinkColor = Color.Yellow;
         lnkGetIP.LinkVisited = true; //如果已被瀏覽過

         //已被瀏覽過的超連結會改變顏色
         lnkGetIP.VisitedLinkColor = Color.Maroon;

         //滑鼠指標停留時才顯示底線
         lnkGetIP.LinkBehavior = LinkBehavior.HoverUnderline;
         
         //從第1個字元開始連結，字元長度為6
         lnkGetIP.Text = "Visual Studio Web";
         lnkGetIP.LinkArea = new LinkArea(0, 6);
      }

      //第一個LinkLabel，進入Visual Studio官方網站
      private void lnkGetIP_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
      {
         Process.Start("https://www.visualstudio.com/");
      }

      //第二個LinkLabel，開啟前一個範例的可執行檔
      private void lnkOpenApp_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
      {
         Process.Start("D:\\C#Lab\\CH11\\Ex1101\\" +
            "bin\\Debug\\Ex1101.exe");         
      }
   }
}
