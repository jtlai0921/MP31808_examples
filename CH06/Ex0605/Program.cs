using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0605
{
   class Program
   {
      static void Main(string[] args)
      {
         //建立student物件
         Student poe = new Student();
         //顯示訊息
         poe.ShowMessage();

         Console.ReadKey();
      }
   }
}
