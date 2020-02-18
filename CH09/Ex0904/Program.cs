using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0904
{
   class Program
   {
      static void Main(string[] args)
      {
         //使用C#6.0語法，建立字典並初始化
         Dictionary<string, int> student = 
               new Dictionary<string, int>()
         {
            ["Peter"]    = 78,
            ["Leonardo"] = 65,
            ["Michelle"] = 47,
            ["Noami"]    = 92,
            ["Richard"]  = 87
         };
         WriteLine($"{"名字", -8} {"分數", 3}");

         //讀取字典方式一        
         foreach (var item in student)         
            WriteLine($"{item.Key, -10} {item.Value, 3}"); 
         
         if (student.TryGetValue("Noami",  out int value))
            student.Remove("Noami");
         WriteLine("尚有...");

         //讀取字典方式二，只讀Key，屬性Count取得項目數
         foreach (KeyValuePair<string, int> item in student)
            Write($"{item.Key}  ");
         
         Write($"{student.Count}人\n");

         //產生有序字典並複製原有字典，加入一個新的項目
         SortedDictionary<string, int> sortedStud =
               new SortedDictionary<string, int>(student)
         { { "Joson", 82 } };

         foreach (var item in sortedStud)
            WriteLine($"{item.Key, -10} {item.Value, 3}");

         ReadKey();
      }
   }
}
