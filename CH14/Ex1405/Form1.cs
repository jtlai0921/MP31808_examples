using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1405
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         
         this.rtxtShow.DragDrop += new DragEventHandler(
            this.rtxtShow_DragDrop);
         this.rtxtShow.DragEnter += new DragEventHandler(
            this.rtxtShow_DragEnter);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         //允許文字方塊能以滑鼠拖曳
         rtxtShow.AllowDrop = true;
      }      

      //滑鼠指標移向RichTextBox控制項引發的事件
      private void rtxtShow_DragEnter(Object sender,
            DragEventArgs e)
      {
         //如果是文字內容則以複製方式將文字複製到文字方塊上
         if (e.Data.GetDataPresent(DataFormats.Text))
         {
            e.Effect = DragDropEffects.Copy;
         }
         else
         {
            e.Effect = DragDropEffects.None;
         }         
      }

      //選取的文字置拖曳到RichTextBox控制項引發的事件
      private void rtxtShow_DragDrop(Object sender,
            DragEventArgs e)
      {
         int locate;
         string data = null;
         //取得選取文字的起始位置.
         locate = rtxtShow.SelectionStart;
         data = rtxtShow.Text.Substring(locate);
         rtxtShow.Text = rtxtShow.Text.Substring(0, locate);
         //拖曳到文字方塊
         string str = String.Concat(rtxtShow.Text,
            e.Data.GetData(DataFormats.Text).ToString());
         rtxtShow.Text = String.Concat(str, data);
      }
   }      
}
