using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//定義預設建構函式
namespace Ex0608
{
   class Program
   {
      static void Main(string[] args)
      {
         TimeInfo mkT = new TimeInfo(); //建立物件

         //建立DateTime結構並以Now取得系統時間
         DateTime moment = DateTime.Now;

         //屬性Hour表示只取系統時間的「時」
         int justNow = moment.Hour;
         mkT.ShowTime(justNow);
      }
   }
}
