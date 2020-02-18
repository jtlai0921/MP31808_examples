using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//認識Chars和Length屬性
namespace Ex0510
{
   class Program
   {
      static void Main(string[] args)
      {
         string word = "This is my favorite programming!";
         int index;//字串索引編號

         //for廻圈擷取索引編號0~5的字元
         for (index = 0; index <= 5; index++)
            WriteLine($"[{index}] = 字元'{word[index]}'");
         WriteLine($"字串總長度= {word.Length}");

         ReadKey();
      }
   }
}
