using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//匯入靜態類別Console

//Parse()方法轉換型別 - 公斤換算為磅數
namespace Ex0309
{
   class Program
   {
      static void Main(string[] args)
      {
         const double Pound = 2.20462D;//常數
         Write("請輸入公斤：");

         //讀取公斤數，再以Parse轉為int
         int weight = int.Parse(ReadLine());         
         WriteLine($"{weight}公斤 = {weight * Pound}磅");

         ReadKey();
      }
   }
}
