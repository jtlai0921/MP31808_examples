using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1107
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         //取得文字方塊輸入的名稱
         string name = txtName.Text;
         int pay = 1_200; //每張票價
         //取得文字方塊輸入票數並以Parse()方法轉為整數型別
         int ticket = int.Parse(txtTicket.Text);
         pay *= ticket; //計算總票價
         //取得DateTimePicker控制項的值再以ToLongDateString()轉為日期
         string order = dtpPreDate.Value.ToLongDateString();
         
         //利用標籤控制項配合字串插補顯示訊息
         lblShow.Text = $"Hi! {name}\n " +
            $"選購日期：{order}\n" +
            $"您訂{ticket}張票, 共{pay:c0}";
      }
   }
}
