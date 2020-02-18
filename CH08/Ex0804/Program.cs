using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0804
{
   class Program
   {
      static void Main(string[] args)
      {
         Person pernOne = new Person();//父類別物件
         pernOne.Show();

         Employee empWorker = new Employee();//子類別物件
         empWorker.Display();

         Console.ReadKey();
      }
   }
}
