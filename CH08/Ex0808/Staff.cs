using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0808
{
   //基底類別以virtual定義虛擬方法，必須由繼承的衍生類別實作(覆寫)
   class Staff
   {
      protected string Name { get; set; }  //屬性

      public void ShowMessage()   //方法成員
      {
         Write("ZCT公司，");
         CalcMoney();
      }

      //運算式主體定義虛擬方法，計算薪資時可以讓子類別覆寫
      public virtual void CalcMoney() => 
         WriteLine("薪水未知");
   }
}