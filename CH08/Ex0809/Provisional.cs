using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//衍生類別 兼職員工 -- 時薪 * 時數 * 工作天
namespace Ex0809
{
   class Provisional : Staff
   {
      //屬性hrmoney時薪，hrworks時數，workdays工作天數      
      private int hrmoney;
      private int hrworks;
      private int workdays;

      //建構函式，以base()方法取得父類別的參數name
      public Provisional(string name, int hrmoney,
         int hrworks, int workdays) : base(name)
      {
         this.hrmoney = hrmoney;
         this.hrworks = hrworks;
         this.workdays = workdays;
      }

      //覆寫父類別定義的唯讀屬性，取得建構函式的參數值，回傳每月薪資
      public override int Salary
      {
         get { return hrmoney * hrworks * workdays; }
      }

      //覆寫override父類別定義的抽象方法，輸出每月薪資訊息
      public override void ShowMessage()
      {
         Console.WriteLine($"{Name} 是兼職員工，" +
            $"薪水 {hrmoney * hrworks * workdays:C0}");
      }
   }
}
