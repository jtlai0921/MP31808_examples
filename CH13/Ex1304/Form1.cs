using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ex1304
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //Add()方法將文字方塊輸入的項目加到ListBox控制項
      private void btnOK_Click(object sender, EventArgs e)
      {
         //取得文字方塊輸入項目以Add()方法加到清單方塊中
         lstCourse.Items.Add(txtCourse.Text);
         //清空文字方塊並重取輸入焦點
         txtCourse.Clear();
         txtCourse.Focus();
      } 

      //依據選取項目回傳的索引值，刪除清單方塊的項目
      private void btnDel_Click(object sender, EventArgs e)
      {
         lstCourse.Items.RemoveAt(lstCourse.SelectedIndex);
      }
   }
}
