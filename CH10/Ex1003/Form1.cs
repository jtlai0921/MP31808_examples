using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1003
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //按下按鈕來關閉表單
      private void btnClose_Click(object sender, EventArgs e)
      {
         Close();   //關閉表單
      }

      //表單載入事件
      private void Form1_Load(object sender, EventArgs e)
      {
         Form frmDialog = new Form();
         frmDialog.Text = "新建表單 -- 對話方塊樣式";

         //產生新按鈕並設定其屬性
         Button btnCancle = new Button();         
         btnCancle.Font = new Font("微軟正黑體", 12);
         btnCancle.AutoSize = true;  //自行調整大小
         btnCancle.Text = "取消";
         btnCancle.Location = new Point(70, 60);  //設定位置

         //將表單設為對話方塊，單線框
         frmDialog.FormBorderStyle =
            FormBorderStyle.FixedDialog;
         frmDialog.Opacity = 0.85;     //將表單變透明一些
         frmDialog.AutoSize = true;
         frmDialog.AutoSizeMode = AutoSizeMode.GrowOnly;
         //不設定最大化、最小化
         frmDialog.MaximizeBox = false;   
         frmDialog.MinimizeBox = false;

         //使用者按表單左上角「X」鈕如同按「取消」按鈕
         frmDialog.CancelButton = btnCancle;
         //設定執行表單的起始位置在螢幕中央
         frmDialog.StartPosition =
            FormStartPosition.CenterScreen;
         //以Controls類別在子表單上加入「取消」按鈕
         frmDialog.Controls.Add(btnCancle);
         frmDialog.ShowDialog();//顯示表單
      }
   }
}
