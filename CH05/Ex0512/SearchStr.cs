using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//字串搜尋方法
namespace Ex0512
{
   class SearchStr
   {
      static void Main(string[] args)
      {
         string str = "Visual C# programming";//原始字串
         bool start = str.StartsWith("visual");
         WriteLine(
             $"比對字串開頭\"visual\"的結果：{start}");

         bool finish = str.EndsWith("programming");
         WriteLine(
             $"比對字串結尾\"programming\"的結果：{finish}");

         int begin = str.IndexOf("g");//找出字元第一次出現的索引
         WriteLine($"\"g\"開始的索引編號：{begin} ");

         int last = str.LastIndexOf("g");
         WriteLine($"\"g\"最後的索引編號：{last} ");
         string secondStr = str.Substring(begin);//擷取子字串
         WriteLine($"子字串：{secondStr}");

         ReadKey();
      }
   }
}
