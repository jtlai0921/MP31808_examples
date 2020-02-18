using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//自動實做屬性
namespace Ex0604
{
   class Program
   {
      static void Main(string[] args)
      {
         //建立student物件
         Student luke = new Student();

         //讀取輸入名字和年齡
         Write("請輸入你的名字：");
         luke.Title = ReadLine();
         Write("請輸入你的年齡：");
         luke.Ages = Int16.Parse(ReadLine());//轉為short型別

         //顯示訊息
         luke.ShowMessage();

         ReadKey();
      }
   }
}
