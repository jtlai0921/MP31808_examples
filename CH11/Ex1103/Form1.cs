using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1103
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //按下「復原」按鈕，執行復原動作
      private void btnUndo_Click(object sender, EventArgs e)
      {
         //能執行文字方塊的復原動作時
         if (txtNote.CanUndo == true)
         {
            txtNote.Undo();      //將文字方塊的編輯動作復原
            txtNote.ClearUndo(); //清除復原緩衝區
            txtNote.Focus();     //取得文字方塊的輸入焦點
         }
      }

      //將選取的文字範圍複製到剪貼簿
      private void btnCopy_Click(object sender, EventArgs e)
      {
         //從文字方塊選取的字元數大於零時
         if (txtNote.SelectionLength > 0)
         {
            txtNote.Copy();   //將資料複製至緩衝區
            //IDataObject擷取資料並保留，不受介面格式的影響
            IDataObject buff = Clipboard.GetDataObject();

            //檢查從系統剪貼簿擷取的資料，是否為原有格式
            if (buff.GetDataPresent(DataFormats.Text))
            {
               //擷取後顯示在另一個文字方塊(緩衝區)
               txtBuffer.Text = (String)
                  (buff.GetData(DataFormats.UnicodeText));
            }
         }
         else
         {
            MessageBox.Show("沒有選取文字範圍!", "進行複製",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      //將選取的文字範圍搬移到剪貼簿
      private void btnCut_Click(object sender, EventArgs e)
      {
         //必須先判斷有選取文字範圍才執行搬移
         if (!txtNote.SelectedText.Equals(""))
         {
            txtNote.Cut(); //將資料搬移至緩衝區
            IDataObject buff2 = Clipboard.GetDataObject();

            //從系統剪貼簿擷取資料，以原有格式儲存
            if (buff2.GetDataPresent(DataFormats.Text))
            {
               //擷取後顯示在另一個文字方塊(緩衝區)
               txtBuffer.Text = (String)
                  (buff2.GetData(DataFormats.UnicodeText));
            }
         }
         else
         {
            MessageBox.Show("沒有選取文字範圍！", "進行搬移",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
         txtNote.Focus();
      }

      //將系統剪貼簿的內容取代原有的文字選取
      private void btnPaste_Click(object sender, EventArgs e)
      {
         txtBuffer.Clear();
         btnClear.Enabled = true;

         //第一層if敘述-判斷是否真的從剪貼簿中擷取了資料
         if (Clipboard.GetDataObject().GetDataPresent(
               DataFormats.Text) == true)
         {

            //第二層if敘述-如果文字方塊內有字元
            if (txtNote.SelectionLength > 0)
            {

               //第三層if/else敘述-利用訊息對話方塊來顯示相關訊息
               if (MessageBox.Show("你確定要從目前的位置貼上文字嗎？",
                     "貼上訊息", MessageBoxButtons.YesNo)
                     == DialogResult.Yes)
               {
                  //設定字元的起點來貼上文字
                  txtNote.SelectionStart =
                     txtNote.SelectionStart +
                     txtNote.SelectionLength;
               }
               else
                  //如果按下訊息對話方塊的「否」按鈕時，清除剪貼簿內容
                  Clipboard.Clear();
            } //第二層if敘述
            txtNote.Paste();//執行貼上方法
         }//第一層if敘述
      }

      //關閉表單
      private void btnExit_Click(object sender, EventArgs e)
      {
         Clipboard.Clear();//清除剪貼簿內容
         Close();
      }

      //清除文字方塊的內容
      private void btnClear_Click(object sender, EventArgs e)
      {
         txtNote.Clear();
         txtNote.Focus();
      }
   }
}
