using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //滙入靜態類別

//宣告整數型別

namespace Ex0301
{
   class Program
   {
      static void Main(string[] args)
      {
         //C# 7.0
         int num1 = 123456; //原來用法
         long num2 = 456_789_123L; //長整數加後置字元L
         //屬性MaxValue、MinValue取得long型別最大和最小值
         long max = Int64.MaxValue;
         long min = Int64.MinValue;
         int num3 = 0b1011_110;   //二進位

         //C# 7.2，要變更專案的屬性設定才能建置
         int num4 = 0b_111_110_10; //0b  2進位
         int num5 = 0x_FB12;       //0x 16進位
         WriteLine($"Number: {num1:N0}, {num2:n0}");

         //以十進位輸出變數num3, num4, num5
         WriteLine($"二進位變十進位：{num3:D5}, {num4:d5}, {num5}");

         //GetType()方法回傳資料型別
         WriteLine($".NET Framework型別: {num1.GetType()}");
         WriteLine($"最大值: {max}, \n最小值: {min}");

         ReadKey();  //畫面暫停
      }
   }
}
