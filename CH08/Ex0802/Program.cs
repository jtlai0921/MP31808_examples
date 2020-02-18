using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0802
{
   class Program
   {
      static void Main(string[] args)
      {
         Person Peter = new Person();//宣告基底類別的物件
         Human Junior = new Human(); //宣告衍生類別的物件

         Peter.showMessage();
         Junior.Show();

         Console.ReadKey();
      }
   }
}
