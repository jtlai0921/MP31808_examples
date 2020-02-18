using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//calcMoney()方法 -- 用new修飾詞來產生新方法
namespace Ex0808
{   
   //FullWork是衍生類別，繼承了Staff類別
   class FullWork : Staff
   {
      private int salary; //欄位--取得計算的月薪
      protected string Name { get { return "Janet"; } }

      //定義自己的方法 -- 計算月薪，隱藏父類別的虛擬方法
      public new void CalcMoney()
      {
         int dayMoney = 1_500;
         salary = dayMoney * 25;
         WriteLine($"{Name} 正式員工，薪水 {salary:C0}");
      }
   }
}