using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//實作多形 -- 繼承的子類別實做虛擬方法時，使用修飾詞new和override之不同處
namespace Ex0808
{
   class ZctWorker
   {
      static void Main(string[] args)
      {
         string line = new string('-', 40);
         WriteLine("第一種方法：");
         ZctWorker.NonDisplay();
         WriteLine(line);
         WriteLine("第二種方法：");
         SecDisplay();
         WriteLine(line);
         WriteLine("第三種方法：");
         ThreeDispaly();

         ReadKey();
      }

      //方法一：實作各物件並呼叫showMessage()，只有兼職員工算出時薪
      public static void NonDisplay()
      {
         Staff Peter = new Staff();
         Peter.ShowMessage();
         FullWork fullWorker = new FullWork();
         fullWorker.ShowMessage();
         Provisional partWork = new Provisional();

         partWork.ShowMessage(); //使用覆寫，算出時薪        
      }

      /* 方法二：輸出正式員工月薪、兼職員工時薪
         實體化子類別物件並直接存取本身所定義的方法
         修飾詞用了new和override)calcMoney，
         分別算出正式員工的月薪和兼職員工的時薪
      */
      public static void SecDisplay()
      {
         FullWork fullWorker = new FullWork();
         fullWorker.CalcMoney();
         Provisional partWork = new Provisional();
         partWork.CalcMoney();
      }

      //方法三：以父類別為類別，以子類別為其值的型別
      public static void ThreeDispaly()
      {
         Staff Peter = new FullWork();
         Staff fullWorkder = new Provisional();
         Peter.CalcMoney();       //呼叫父類別的方法
         fullWorkder.CalcMoney(); //呼叫子類別的方法
      }
   }
}