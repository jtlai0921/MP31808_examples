using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Array類別IndexOf()方法搜尋陣列元素
namespace Ex0504
{
   class Program
   {
      static void Main(string[] args)
      {
         //陣列name：儲存名字, 陣列age存放年齡
         string[] name =
            {"Molly", "Eric", "John", "Janet", "Iron"};
         int[] age = { 25, 26, 27, 26, 28 };

         //回傳26歲的index值
         int index = Array.IndexOf(age, 26);

         //利用while廻圈找到符合26歲的人
         WriteLine("符合26歲的人：");
         while (index >= 0)
         {
            Write($"{name[index], 6} ");
            //繼續往下一筆去找
            index = Array.IndexOf(age, 26, index + 1);
         }

         ReadKey();
      }
   }
}
