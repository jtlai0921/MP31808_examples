using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0611
{
   class Program
   {
      static void Main(string[] args)
      {
         //直接以類別名稱Student存取靜態欄位Count
         WriteLine($"沒有實體化，{Student.Count}個學生");

         Student one = new Student("Vicky", 23);
         Student two = new Student("Charles", 18);
         Student three = new Student("Michelle", 20);

         ReadKey();
      }
   }
}
