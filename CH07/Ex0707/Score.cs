using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 建立物件後，採傳值方式，
   靜態方法showMsg()接收的是first物件的副本
   即使它也實體化另一個物件one，並不會影響主程式的物件 */
namespace Ex0707
{
   class Score
   {
      //欄位：Name、Mark自動實做屬性
      public string Name { get; set; }
      public int Mark { get; set; }

      //宣告靜態方法
      static void ShowMsg(Score one)
      {
         one = new Score();  //重新建立一個物件
         one.Name = "Peter"; //指定名字
         one.Mark = 73;      //指定分數
      }

      //主程式
      static void Main(string[] args)
      {
         Score first = new Score(); //建立物件
         first.Name = "Janet";
         first.Mark = 95;

         ShowMsg(first); //以物件做傳遞對象

         WriteLine($"{first.Name}, 分數 {first.Mark}");

         ReadKey(); //螢幕暫停
      }
   }
}
