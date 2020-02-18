using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0811
{
   class Student : ISchool, IGrade //實作介面ISchool, IGrade
   {
      private int subject;//欄位1-存放選修分數
      private int status; //欄位2-學生身分
      public int Subject //實作介面ISchool屬性
      {
         get { return subject; }
         set { subject = value; }
      }
      public int Status //實作介面IGrade屬性
      {
         get { return status; }
         set { status = value; }
      }

      //建構函式，傳入參數 - indetity學生身分，course學分數
      public Student(int indetity, int course)
      {
         Subject = course;
         Status = indetity;
      }

      public void ShowMessage()//實做介面ISchool的方法
      {
         int account = 1_470, total = 0;
         if (status == 1)//一般學生
         {
            account = 1_470;
            total = Subject * account;//計算學分費
         }
         else if (status == 2) //碩博生加指導費
            total = subject * account + 9_500;
         Console.WriteLine($"！學分費共 {total:C0} 元");
      }
   }
}
