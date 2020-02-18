using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0804
{
   class Employee : Person
   {
      public Employee()//建構函式
      {
         Name = "Taylor";
         BaseMoney = 28000;
      }
      
      //以base關鍵字呼叫基底類別的方法
      public void Display()
      {
         base.Show();
      }

      ~Employee() { }//解構函式
   }
}
