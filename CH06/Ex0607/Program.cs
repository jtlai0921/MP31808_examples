using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//按Ctrl + F5 編譯程式來能看到解構函式的訊息
namespace Ex0607
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入名字：");
         string word = ReadLine();
         Write("請輸入分數：");
         int grade = Convert.ToInt16(ReadLine());

         //建立一個含有參數的Student物件
         Student tomas = new Student(word, grade);            
      }
   }
}
