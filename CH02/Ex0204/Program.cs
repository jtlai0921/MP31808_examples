using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//匯入靜態類別Console

namespace Ex0204
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入名稱：");
         string name = ReadLine();
         Write("請輸入提款金額：");
         int money = int.Parse(ReadLine());
         WriteLine($"Hi! {name}, 提款金額：{money:C0}");
         ReadKey();
      }
   }
}
