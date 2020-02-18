using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

//泛型集合的List<T>類別
namespace Ex0906
{
   //Student類別
   class Student
   {
      public string Name { get; set; }
      public double Score { get; set; }
   }

   //主程式
   class Program
   {
      static void Main(string[] args)
      {
         List<Student> students = new List<Student>{
            new Student { Name = "Mary", Score = 78.25 },
            new Student { Name = "Emily", Score = 85.47},
            new Student { Name = "Tomas", Score = 88.7},
            new Student { Name = "Joson", Score = 69.0},
            new Student { Name = "Steven", Score = 93.8}};
         double totalScore = students.Sum(total => total.Score);
         double average = students.Average(avg => avg.Score);
         double maxScore = students.Max(max => max.Score);
         WriteLine($"總分：{totalScore:N0}");
         WriteLine($"平均值: {average}");
         WriteLine($"最高分：{maxScore}");        

         ReadKey();
      }
   }
}
