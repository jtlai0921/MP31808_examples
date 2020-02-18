using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0708
{
   class ModifyScore
   {
      //欄位：Name、Mark自動實做屬性
      public string Name { get; set; }
      public int Mark { get; set; }

      //使用方法參數ref，採傳址呼叫
      static void ShowMsg(ref ModifyScore one)
      {
         //重新建立一個物件，指定名字和分數
         one = new ModifyScore();
         one.Name = "Peter"; 
         one.Mark = 73; 
      }

      //主程式
      static void Main(string[] args)
      {
         ModifyScore jan = new ModifyScore(); //建立物件
         jan.Name = "Janet";
         jan.Mark = 95;

         ShowMsg(ref jan); //以物件做傳遞對象

         Console.WriteLine($"{jan.Name}, 分數 {jan.Mark}");

         Console.ReadKey(); //螢幕暫停
      }
   }
}
