using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1104
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnOpen_Click(object sender, EventArgs e)
      {
         btnOpen.Visible = false;   //隱藏按鈕控制項
         //文字方塊大小依據表單來填滿
         rtxtRTF.Dock = DockStyle.Fill;

         //設定搜尋字串和其起始位置
         string target = "去"; 
         int begin = 1;
         int count = 1;

         //載入檔案
         rtxtRTF.LoadFile("D:\\C#Lab\\CH11\\Demo.rtf");

         //屬性TextLength取得載入檔案的總字串長度
         int result = rtxtRTF.TextLength;

         //字串總長是否大於字元位置
         while (result > begin)
         {
            //呼叫SearchText()方法來回傳第一個字串的索引位置
            int outcome = SearchText(target, begin);
            string strHave = //字串插補
               $"第 {count} 字元，索引編號：{outcome}";
            MessageBox.Show(strHave);
            begin += outcome;//變更欲尋找字串的索引位置
            count++;
         }
         //儲存檔案
         rtxtRTF.SaveFile("D:\\C#Lab\\CH11\\Change.rtf",
            RichTextBoxStreamType.RichText);
      }

      //搜尋字串的方法 -- 傳入字串和起始位置
      public int SearchText(string word, int start)
      {
         //沒有找到符合的字串時回傳-1
         int result = -1;
         //有字串和起始位置才進一步搜尋
         if (word.Length > 0 && start >= 0)
         {
            //Find()方法做字串搜尋，None要找到相似即可
            int MatchText = rtxtRTF.Find(word, start,
               RichTextBoxFinds.None);
            //找到符合的字串，將字型大小設為14，字體為粗體
            rtxtRTF.SelectionFont = new Font(
               "標楷體", 14, FontStyle.Bold);
            //符合的字串重設字型顏色
            rtxtRTF.SelectionColor = Color.OrangeRed;
            if (MatchText >= 0)
               result = MatchText;
         }
         return result;
      }
   }
}
