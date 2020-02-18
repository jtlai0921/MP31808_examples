using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//不規則陣列或稱鋸齒陣列
namespace Ex0508
{
   class JaggedArray
   {
      static void Main(string[] args)
      {
         //step1. 宣告不規則陣列
         string[][] subject = new string[3][];

         //step2. 以new運算子將每列的陣列元素初始化
         subject[0] = new string[]
            {"Tomas","國文","英文會話","程式設計"};
         subject[1] = new string[]
             {"Molly", "國文", "計算機概論"};
         subject[2] = new string[]
             {"Eric", "英文", "數學", "多媒體論","應用文"};

         //step3. 利用雙層for -- 外層取得列數，內層for讀取列的每個元素
         for (int one = 0; one < subject.Length; one++)
         {
            for (int two = 0; two < subject[one].Length; two++)
            {
               Write($"{subject[one][two]}\t");
            }
            WriteLine();
         }
         ReadKey();
      }
   }
}
