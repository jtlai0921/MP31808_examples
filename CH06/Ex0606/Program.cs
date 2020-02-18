using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//產生建構函式
namespace Ex0606
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
         tomas.judgeFrom();//呼叫方法成員
         ReadKey();
      }
   }
}
