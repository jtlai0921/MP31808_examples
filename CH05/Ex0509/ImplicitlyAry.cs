using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//利用var來宣告隱含陣列
namespace Ex0509
{
   class ImplicitlyAry
   {
      static void Main(string[] args)
      {
         //宣告一個隱含型別的不規則陣列
         var number = new[]
            { new[]{68, 135, 83}, new[]{75,64,211,37}};

         WriteLine("讀取隱含的不規則陣列：");

         //由於有二列陣列，利用雙層for讀取陣列元素
         for (int one = 0; one < number.Length; one++)
         {
            for (int two = 0; two < number[one].Length; two++)
               Write($"{number[one][two],4}");
         }
         WriteLine();

         ReadKey();
      }
   }
}
