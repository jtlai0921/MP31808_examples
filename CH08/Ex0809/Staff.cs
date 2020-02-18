using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 定義抽象類別 - 定義員工的架構--名字，薪水，
   一個抽象屬性Salary和一個抽象方法ShowMessage()
   必須由繼承的衍生類別實作(覆寫)
*/
namespace Ex0809
{
   //基底類別
   abstract class Staff
   {
      private string name;//私有名字欄位

      //建構函式
      public Staff(string staffName)
      { Name = staffName; }

      //屬性名字取得建構函式的參數值
      protected string Name
      {
         get { return name; }
         set { name = value; }
      }

      //以abstract配合存取子get將Salary定義成唯讀屬性
      public abstract int Salary { get; }

      //定義抽象方法，不能加區段的大括號
      public abstract void ShowMessage();
   }
}
