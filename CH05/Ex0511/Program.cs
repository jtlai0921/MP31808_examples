using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//認識字串常用方法
namespace Ex0511
{
   class Program
   {
      static void Main(string[] args)
      {
         string str = "Learning programming";//原始字串
         string wds = "Visual C# ";//欲插入字串

         //以Insert()方法，在索引編號9插入字串
         string sentence = str.Insert(9, wds);
         WriteLine($"原來字串{str}, \n插入字串後：{sentence}");

         string word = "Writing";//欲取代字串
         sentence = sentence.Replace("Learning", word);
         WriteLine($"取代後字串：{sentence}");

         //分割字串
         char[] separ = { ' ' };//以空白字來分割
         string[] str2 = sentence.Split(separ);
         WriteLine("分割字串：");
         foreach (string item in str2)
            Console.WriteLine($"{item}");

         ReadKey();
      }
   }
}
