using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//泛型類別
namespace Ex0902
{
   class Program
   {
      static void Main(string[] args)
      {
         //建立泛型類別物件 -- 學生名稱
         Student<string> persons = new Student<string>();
         persons.StoreArray("Tomas");
         persons.StoreArray("John");
         persons.StoreArray("Eric");
         persons.StoreArray("Steven");
         persons.StoreArray("Mark");
         persons.ShowMessage();

         //建立泛型類別物件 -- 成績
         Student<int> Score = new Student<int>();
         Score.StoreArray(78);
         Score.StoreArray(83);
         Score.StoreArray(48);
         Score.StoreArray(92);
         Score.StoreArray(65);
         Score.ShowMessage();

         Console.ReadKey();
      }      
   }
}
