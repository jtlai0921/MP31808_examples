using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0604
{
   class Student
   {
      //自動實做屬性：屬性title(名字)，Ages(年齡)
      public string Title { get; set; }
      public short Ages { get; set; }

      //定義公開的類別方法
      public void ShowMessage() =>
         Console.WriteLine($"Hollo! {Title}, 年齡：{Ages}.");
   }
}
