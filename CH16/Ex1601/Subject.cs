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
   public partial class Subject : Form
   {
      public Subject()
      {
         InitializeComponent();
      }

      private void 課程BindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.課程BindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.schoolDataSet);

      }

      private void Student_Load(object sender, EventArgs e)
      {
         // TODO: 這行程式碼會將資料載入 'schoolDataSet.課程' 資料表。您可以視需要進行移動或移除。
         this.課程TableAdapter.Fill(this.schoolDataSet.課程);

      }
   }
}
