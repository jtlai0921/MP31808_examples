using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0610
{
   class Student
   {
      //自動實做屬性
      public int Math { get; set; } //數學
      public int Eng { get; set; }  //英文
      public int Comp { get; set; } //計概 

      //運算式主體 - 類別方法，回傳總分
      public int sum() => Math + Eng + Comp;
   }
}
