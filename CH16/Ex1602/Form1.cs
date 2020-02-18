using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1602
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void 學生BindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.學生BindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.schoolDataSet);

      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // TODO: 這行程式碼會將資料載入 'schoolDataSet.學生' 資料表。您可以視需要進行移動或移除。
         this.學生TableAdapter.Fill(this.schoolDataSet.學生);

      }

      private void sortBirthToolStripButton_Click(object sender, EventArgs e)
      {
         try
         {
            this.學生TableAdapter.SortBirth(this.schoolDataSet.學生);
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }

      }
   }
}
