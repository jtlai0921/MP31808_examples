using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//類別屬性和存取子
namespace Ex0603
{
   class ShowApp
   {
      static void Main(string[] args)
      {
         //建立Person物件並實體化
         Person chris = new Person();

         Write("請輸入你的名字：");

         //讀取輸入名字
         chris.Title = ReadLine(); //Chris Evans

         //顯示名稱訊息
         chris.Dispaly();

         ReadKey();
      }
   }
}
