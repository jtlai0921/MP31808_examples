using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

//產生結構
namespace Ex0307
{
   //step1.宣告結構
   struct Computer
   {
      //價格price, 序號serial, 製造日期madeDate
      public int price;
      public string serial;
      public DateTime madeDate;
   }
   class Program
   {
      static void Main(string[] args)
      {
         Computer personPC; //step2.產生結構變數

         personPC.price = 23_750;
         personPC.madeDate = DateTime.Today;
         personPC.serial = "ZCT-20180309B";         

         WriteLine($"電腦價格 {personPC.price:c0}" +
             $"\n製造日期 {personPC.madeDate:D}" +
             $"\n序號 {personPC.serial}");

         ReadKey();
      }
   }
}
