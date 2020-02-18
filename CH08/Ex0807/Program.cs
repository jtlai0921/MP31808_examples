using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0807
{
   //Override基底類別
   class Program
   {
      static void Main(string[] args)
      {
         Person Peter = new Person();//宣告基底類別的物件
         Peter.ShowMessage();
         Human Junior = new Human();
         Junior.ShowMessage();//衍生類別的物件呼叫自己的方法

         Console.ReadKey();
      }
   }
}
