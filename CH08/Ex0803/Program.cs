using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0803
{
   class Program
   {
      static void Main(string[] args)
      {
         //初始化onePrn物件，並傳入初始值
         Person anna = new Person("Annabelle", 32_500);
         anna.showTime();

         //實體化衍生類別，加入參數值
         Employee partOne = new Employee("Tomas", 23_500);
         partOne.hireTime();

         //TimeSpan atOnce = new TimeSpan(25);

         //WriteLine(atOnce.Days);
         //WriteLine(DateTime.Now.ToShortTimeString());

         ReadKey();
      }
   }
}
