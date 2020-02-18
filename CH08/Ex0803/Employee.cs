using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0803
{
   class Employee : Person
   {
      //利用base()方法呼叫基底類別的建構函式來使用
      public Employee(string Name, int pay)
            : base(Name, pay) { }

      public void hireTime()
      {
         DateTime startDate = DateTime.Today;
         WriteLine($"雇用日期：" +
            $"{startDate.ToShortDateString()}");
      }
   }
}
