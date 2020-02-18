using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1601
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void 教師BindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.教師BindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.schoolDataSet);

      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // TODO: 這行程式碼會將資料載入 'schoolDataSet.教師' 資料表。您可以視需要進行移動或移除。
         this.教師TableAdapter.Fill(this.schoolDataSet.教師);

      }

      private void stbtnSubjectDetail_Click(object sender, 
            EventArgs e)
      {
         Subject course = new Subject();
         course.Show(); //顯示表單
      }
   }
}
