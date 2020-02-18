using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0513
{
   class Program
   {
      static void Main(string[] args)
      {
         //建立StringBuilder物件
         StringBuilder strb = new StringBuilder();
         WriteLine($"預設容量：{strb.Capacity}");

         //Append()方法附加字串
         strb.Append("Research supports the significance of EQ.");
         WriteLine($"字串長度：{strb.Length}，" +
            $"總容量：{strb.Capacity}");

         strb.AppendLine("\n");
         WriteLine($"字串長度：{strb.Length}，" +
            $"總容量：{strb.Capacity}");

         strb.AppendLine(
             "A 40-year study that IQ wasn’t the only thing.");

         WriteLine($"字串長度：{strb.Length}，" +
            $"總容量：{strb.Capacity}");
         WriteLine($"原來字串 -- {strb}");

         //Remove()方法移除found
         string text = "found";//欲移除字串
         //取得欲刪除字串的索引編號
         int index = strb.ToString().IndexOf(text);
         if (index >= 0)
            strb.Remove(index, text.Length);
         WriteLine($"變更後字串 -- {strb}");

         //取代部份內容: Replace()方法將"people"取代"boys"
         strb.Replace("boys", "people");
         string nword = "of 450 boys found ";

         /*
           取得欲插人位置的索引編號
           在strb物件中的"that"字串前插入部份字串。
           同樣地，先以ToString()方法將strb物件轉為字串，
           再以IndexOf()方法取得that字串的索引編號，儲存於index2變數中，
           然後再以Insert()方法插入字串
          */
         int index2 = strb.ToString().IndexOf("that");
         strb.Insert(index2, nword);
         WriteLine($"插入後字串 -- {strb}");
         ReadKey();
      }
   }
}