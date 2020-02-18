using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

//Convert類別轉換型別
namespace Ex0310
{
   class Program
   {
      static void Main(string[] args)
      {
         string thisDay, birth;
         //DateTime物件
         DateTime special, Atonce;

         Write("請輸入你的生日：");
         birth = ReadLine(); //讀取日期
         //ToDateTime(字串)轉為日期格式
         special = Convert.ToDateTime(birth);

         //取得當前的日期和時間，再以ToString()方法轉為字串
         Atonce = DateTime.Now;
         thisDay = Convert.ToString(Atonce);

         WriteLine($"今天是{thisDay} \n你的生日 {special}");

         ReadKey();//讓畫面暫停
      }
   }
}
