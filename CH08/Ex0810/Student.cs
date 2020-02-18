using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0810
{
   class Student : ISchool //實作介面
   {
      private int subject;//欄位

      public int Subject //實作介面的屬性
      {
         get { return subject; }
         set { subject = value; }
      }

      public Student(int subj) //建構函式，傳入學分數
      { Subject = subj; }

      public void ShowMessage()//實做介面的方法
      {
         int account = 1470;
         int total = Subject * account;//計算學分費
         Console.WriteLine($"！學分費共{total:C0}");
      }
   }
}
