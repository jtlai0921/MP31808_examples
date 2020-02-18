using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0603
{
   class Person  //自訂類別Person
   {
      private string name; //定義欄位來取得輸入名稱

      public string Title //定義屬性
      {
         get { return name; }
         set { name = value; }
      }

      //定義公開的方法成員 - 顯示屬性title
      public void Dispaly()
      {
         Console.WriteLine($"Hollo! {Title}.");
      }
   }
}
