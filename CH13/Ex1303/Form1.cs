using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1303
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      /* 以表單載入事件，將兩個ComboBox控制項的項目清單以字串陣列產生
         再利用AddRange()方法來取得項目清單的內容 */
      private void Form1_Load(object sender, EventArgs e)
      {
         string[] fontSize = new string[]{//設字大小的陣列
            "10", "12", "14", "16", "20", "24", "28"};
         string[] fontDemo = new string[] {//字型陣列
            "新細明體", "標楷體","微軟正黑體", "Arial"};
         cobFontSize.Items.AddRange(fontSize);
         cobFontChoice.Items.AddRange(fontDemo);
      }      

      //依據選取項目所回傳的索引值來設定字的大小
      private void cobFontSize_SelectedIndexChanged(
            object sender, EventArgs e)
      {
         //取得清單項目索引值
         int index = cobFontSize.SelectedIndex;
         //依據取得的index來判斷要顯示的字體大小
         switch (index)
         {
            case 0:
               //依據Label控制項所取得的字型名稱設定字的大小
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 10.0F);
               break;
            case 1:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 12.0F);
               break;
            case 2:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 14.0F);
               break;
            case 3:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 16.0F);
               break;
            case 4:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 20.0F);
               break;
            case 5:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 24.0F);
               break;
            case 6:
               lblDisplay.Font = new Font(
                  lblDisplay.Font.Name, 28.0F);
               break;
         }
      }

      //依據選取項目所回傳的索引值來設定字型
      private void cobFontChoice_SelectedIndexChanged(
            object sender, EventArgs e)
      {
         //取得選取字型項目的索引值
         int index = cobFontChoice.SelectedIndex;
         lblDisplay.Font = new Font(
         cobFontChoice.Text, lblDisplay.Font.Size);
      }
   }
}
