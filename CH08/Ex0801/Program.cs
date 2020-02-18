using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0801
{
   class Program
   {
      static void Main(string[] args)
      {
         //基底類別的物件
         School ScienceEngineer = new School();
         ScienceEngineer.ShowMsg();

         //衍生類別的物件
         Education choiceStu = new Education();
         choiceStu.Display(20);

         Console.ReadKey();
      }
   }
}
