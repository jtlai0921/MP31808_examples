using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1401
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //檔案功能表的「開新檔案」項目
      private void tsmNewFile_Click(object sender, EventArgs e)
      {
         MDIChild newChild = new MDIChild(); //建立子表單
         //將目前的表單指定為newChild的MDI父表單
         newChild.MdiParent = this;
         //記錄子表單的數量
         int count = this.MdiChildren.Length;
         //設定子表單的標題
         newChild.Text = $"我是子表單-{count.ToString()}";
         newChild.Show();	//顯示MDI子表單
      }

      //關閉開啟的MDI子表單
      private void tsmClose_Click(object sender, EventArgs e)
      {
         foreach (Form MDIChild in this.MdiChildren)
            MDIChild.Close();
      }

      //視窗功能表「排列」項目的『水平』被勾選時
      private void tsmHorizon_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileHorizontal);
         tsmVertical.Checked = false;//取消垂直排列的勾選
         tsmCascade.Checked = false; //取消重疊排列的勾選
      }

      //視窗功能表「排列」項目的『重直』被勾選時
      private void tsmVertical_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileVertical);
         tsmHorizon.Checked = false;//取消水平排列的勾選
         tsmCascade.Checked = false;//取消重疊排列的勾選
      }

      //視窗功能表「排列」項目的『重疊』被勾選時
      private void tsmCascade_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.Cascade);
         tsmVertical.Checked = false; //取消垂直排列的勾選
         tsmHorizon.Checked = false;  //取消水平排列的勾選
      }
   }
}
