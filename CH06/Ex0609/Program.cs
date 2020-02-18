using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0609
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Mary ");
         Student Mary = new Student(78, 69);
         Console.Write("Tomas");
         Student Tomas = new Student(55, 85, 74);
         Console.ReadKey();
      }
   }
}
