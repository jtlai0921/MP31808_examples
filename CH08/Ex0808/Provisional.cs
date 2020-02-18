using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//calcMoney()方法 -- 用override修飾詞覆寫父類別的虛擬方法calcMoney()
namespace Ex0808
{
   //Provisional為衍生類別，繼承了Staff類別
   class Provisional : Staff
   {
      //prtSalary儲存薪資, 唯讀屬性Name以存取子get來取得名字Tomas
      private int prtSalary;
      protected string Name { get { return "Tomas"; } }

      //覆寫基底類別方法，計算時薪
      public override void CalcMoney()
      {
         int hourMoney = 220;
         prtSalary = hourMoney * 5 * 20;
         WriteLine($"{Name} 兼職員工，薪水 {prtSalary:C0}");
      }
   }
}