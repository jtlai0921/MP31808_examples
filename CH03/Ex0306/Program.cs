using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //滙入靜態類別

namespace Ex0306
{
   //step1.宣告列舉型別常數值
   enum City : short
   {
      Taipei = 100,
      Sinjhu = 300,
      Taijhong = 400,
      Tainan = 700,
      Kaohsiung = 800
   }

   class Program
   {
      static void Main(string[] args)
      {
         //step2.宣告列舉變數
         City zone1, zone2;
         short pt1, pt2;

         //step3.存取列舉成員
         zone1 = City.Kaohsiung;
         zone2 = City.Tainan;

         //輸出常數值須指定型別轉換
         pt1 = (short)City.Sinjhu;
         pt2 = (short)City.Taijhong;
         WriteLine($"城市：{zone1}, {zone2}");
         WriteLine($"新竹、台中的郵遞區號：{pt1}, {pt2}");

         //直接以 列舉名稱.成員 做存取
         Write(City.Kaohsiung);
         WriteLine($" 郵遞區號：{(short)City.Kaohsiung}");

         ReadLine();
      }
   }
}