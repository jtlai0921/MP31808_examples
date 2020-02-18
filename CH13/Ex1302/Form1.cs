using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1302
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnConfirm_Click(object sender, EventArgs e)
      {
         //建立一個處理文字方塊字串的陣列
         String[] temps = new String[4];

         String distin, city1="", city2="", city3="";
         //變更字型和其顏色
         rtxtData.Font = new Font("標楷體", 14);
         rtxtData.ForeColor = Color.Indigo;

         //將輸入的姓名、生日存入陣列中
         temps[0] = $"姓名：{txtName.Text}";
         temps[1] = $"生日：{dtpBirth.Text}";

         //判斷使用者選擇的性別         
         distin = (rabMale.Checked) ?
            rabMale.Text : rabFemale.Text;
         temps[2] = $"性別：{distin}";

         //判斷使用者勾選了那些城市
         if (ckbKao.Checked == true)   //高雄
            city1 = ckbKao.Text;
         if (ckbTaichung.Checked == true)   //台中
            city2 = ckbTaichung.Text;
         if(ckbTaipei.Checked == true)   //台北
            city3 = ckbTaipei.Text;
         temps[3] += $"可以就職城市：{city1} {city2} {city3}";

         //取得陣列內容放入文字方塊
         rtxtData.Lines = temps;
      }
   }
}
