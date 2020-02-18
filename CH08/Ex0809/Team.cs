using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//衍生類別 幹部 -- 底薪 + 加給
namespace Ex0809
{
   class Team : Staff
   {
      //屬性basemoney基本薪，allowance加給
      private int basemoney;
      private int allowance;

      //建構函式，以base()方法取得父類別的參數name
      public Team(string name, int basemoney,
         int allowance) : base(name)
      {
         this.basemoney = basemoney;
         this.allowance = allowance;
      }

      //覆寫父類別定義的唯讀屬性，取得建構函式的參數值，回傳每月薪資
      public override int Salary
      {
         get { return basemoney * allowance; }
      }

      //覆寫override父類別定義的抽象方法，輸出每月薪資訊息
      public override void ShowMessage() => Console.WriteLine(
         $"科長 {Name,11}，薪水 {basemoney + allowance:C0}");
   }
}
