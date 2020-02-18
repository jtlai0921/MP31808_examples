using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//靜態建構函式
namespace Ex0613
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("未實體化，{0}個學生",
            Student.Count);
         Student one = new Student("Vicky", 23);
         Student two = new Student("Charles", 18);
         Student three = new Student("Michelle", 20);
         Console.Read();
      }
   }
}
