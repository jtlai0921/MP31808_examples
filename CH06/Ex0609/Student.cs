using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 建構函式使用Overloading
   定義自動實做屬性：math、eng、comp；
   以多載形式定義2個建構函式，接收參數後進行加總
   再呼叫成員方法sum()顯示加總後的訊息
*/
namespace Ex0609
{
   class Student
   {
      //3個屬性存放各科績
      private int math { get; set; }
      private int eng { get; set; }
      private int comp { get; set; }

      //第一個建構函式，有2個參數
      public Student(int sb1, int sb2)
      {
         math = sb1; eng = sb2;
         int total = math + eng;
         sum(total); //呼叫方法成員
      }

      //第二個建構函式，有3個參數
      public Student(int sb1, int sb2, int sb3)
      {
         math = sb1; eng = sb2; comp = sb3;
         int total = math + eng + comp;
         sum(total); //呼叫方法成員
      }

      ~Student() { }//解構函式

      //運算式主體 - 方法成員，回傳總分
      public void sum(int result) =>
         Console.WriteLine($"總分 {result}");
   }
}