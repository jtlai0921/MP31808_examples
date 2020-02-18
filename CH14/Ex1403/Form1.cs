using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1403
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
      {
         string name = txtName.Text;
         string pwd = "";
         if ((byte)e.KeyChar < 48 || (byte)e.KeyChar > 57)
         {
            lblMsg.Text = "須使用數字";
            if (e.KeyChar == (char)Keys.Enter)
            {
               pwd = txtPwd.Text;
               lblMsg.Text = $"{name}, 密碼 {pwd}";
            }
         }         
      }
   }
}
