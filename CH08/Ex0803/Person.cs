using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//DataTiem取得日期和時間，DateSpan取得日期間隔
namespace Ex0803
{
   class Person   //基底類別
   {
      //Name, baseSalary 自動實做屬性
      protected int baseSalary { get; set; }
      protected string Name { get; set; }

      //定義基底建構函式：傳入名字和薪資
      public Person(string title, int wage)
      {
         Name = title;
         baseSalary = wage;
         WriteLine($"員工：{Name}，薪水 {baseSalary:C0}");
      }

      //定義成員方法，計算工作年資
      public void showTime()
      {
         //hireDate -- 就職日期; justNow -- 取得系統當下日期 
         DateTime hireDate = new DateTime(2009, 3, 17);
         DateTime justNow = DateTime.Today; 

         //以Subtract()方法取得 justNow - hireDate 所得之間隔時間
         //TimeSpan jobYear = justNow.Subtract(hireDate);

         //以TimeSpan取得工作天數 當下日期 - 就職日期
         TimeSpan jobDays = justNow - hireDate;

         //先以Days屬性取得天數，再換算成年份
         double work = (double)(jobDays.Days) / 365;

         //ToShortDateString()方法將hireDate轉為簡短日期字串
         WriteLine($"雇用日期：" +
            $"{hireDate.ToShortDateString(),10}, " +
            $"工作：{work:F2} 年");
      }
   }
}
