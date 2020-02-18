using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//自動實做屬性並設初值
namespace Ex0605
{
   class Student
   {
      //自動實做屬性並設初值
      public string Title { get; set; } = "Poe Dameron";
      public short Ages { get; set; } = 22;
      public DateTime enrolled { get; } = DateTime.Now;

      //運算式主體 - 定義公開的類別方法
      public void ShowMessage() =>
         Console.WriteLine($"Hollo! {Title}, 年齡：{Ages}" +
            $"\n註冊日期：{enrolled:D}");
   }
}
