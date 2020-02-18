using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//衍生類別 正式員工 -- 日薪* 工作天
namespace Ex0809
{
   /* 子類別Worker繼承了Staff類別
      由於父類別是抽象類別，必須實作抽象屬性Salary
      和抽象方法showMessage()
   */
   class Worker : Staff
   {
      //屬性daymoney日薪，dayworks工作天數    
      private int daymoney;
      private int dayworks;

      //建構函式，以base()方法取得父類別的參數name
      public Worker(string name, int daymoney,
            int dayworks) : base(name)
      {
         this.daymoney = daymoney;
         this.dayworks = dayworks;
      }

      //覆寫父類別定義唯讀屬性，取得建構函式的參數值，回傳每月薪資
      public override int Salary
      { get { return daymoney * dayworks; } }

      //覆寫override父類別定義的抽象方法，輸出每月薪資訊息
      public override void ShowMessage()
      {
         Console.WriteLine($"{Name} 是正式員工，" +
            $"薪水 {daymoney * dayworks:C0}");
      }
   }
}
