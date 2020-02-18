using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

namespace Ex0203
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入你的名字：");
         //取得輸入名稱並以變數name儲存
         string name = ReadLine();
         WriteLine("Good Day! {0}", name);
         //WriteLine($"Good Day! {name}");
         ReadLine(); //晝面暫停
      }
   }
}
