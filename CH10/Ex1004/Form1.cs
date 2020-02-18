using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1004
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnCheck_Click(object sender, EventArgs e)
      {
         //訊息方塊的訊息
         String message = "輸入的字元少於5個字，請重新輸入";
         //訊息方塊的標題(帳號)
         String account = "輸入帳號";
         //訊息方塊的標題(密碼)
         String password = "輸入密碼";
         //訊息方塊的回應按鈕
         MessageBoxButtons btnName = MessageBoxButtons.YesNo;
         MessageBoxButtons btnPwd = MessageBoxButtons.OKCancel;

         //訊息方塊的圖示
         MessageBoxIcon iconInfo = MessageBoxIcon.Information;
         MessageBoxIcon iconWarn = MessageBoxIcon.Warning;

         //訊息方塊的回傳值
         DialogResult result, confirm;

         //第一層if/else敘述；名稱的字元數必須大於或等於5個字元
         if (txtAccount.Text.Length >= 5)
         {

            /* 第二層if/else敘述判斷輸入的密碼是否有大於5個字元？
               如果沒有的話，呼叫getMessage()方法清除輸入密碼的文字方塊*/
            if (txtPwd.Text.Length >= 5)
            {

               /* 性別被勾選之後，才會顯示個人基本資料
                  RadioButton選項按鈕以屬性Checked來判斷是否被圈選。
                  如果有就以MessageBox類別的Show()方法
                  顯示帳號、密碼和性別的相關訊息。
               */
               string verify = $"{txtAccount.Text}," +
                  $"{(rabMale.Checked ? "師哥" : "美女")}, 你好！" +
                  $"\n密碼：{txtPwd.Text}, 資料正確";
               confirm = MessageBox.Show(verify);
               ResultMsg(confirm);//傳入參數值做後續處理               
            }
            else   //密碼字元數小於5個字元時，顯示訊息
            {
               result = MessageBox.Show("密碼" + message,
                  password, btnPwd, iconWarn,
                  MessageBoxDefaultButton.Button2);
               ResultMsg(result);
            }
         }
         else
         {
            //姓名字元數小於5個字元時顯示訊息
            result = MessageBox.Show("名字" +
               message, account, btnName, iconInfo);
            ResultMsg(result);
         }
      }

      /* 自行定義的getMessage()方法，以DialogResult結構的物件為引數
         傳入後利用if/else if來判斷所傳入是那一個要處理的按鈕值
         執行要處理的程序   */
      private void ResultMsg(DialogResult outcome)
      {
         if (outcome == DialogResult.OK)
         {
            Application.Exit();//資料正確，離開程式
         }
         else if (outcome == DialogResult.Cancel)
         {
            txtPwd.Clear();//清除文字方塊內容
            txtPwd.Focus();//取得文字方塊輸入焦點
         }
         else if (outcome == DialogResult.Yes)
         {
            txtAccount.Clear();//清除文字方塊內容
            txtAccount.Focus();//取得文字方塊輸入焦點
         }
      }      
   }
}
