using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//私有建構函式
namespace Ex0614
{
   //AnyNumber為一般類別，但成員皆有靜態
   public class AnyNumber
   {
      //私有建構函式和靜態欄位currentNum
      private AnyNumber() { }
      public static int currentNum;  
      static Random rand = new Random();

      //類別靜態方法    
      public static int randnum()
      {
         currentNum = rand.Next();//產生亂數
         return currentNum;
      }
   }

   //主程式
   class Program
   {
      static void Main(string[] args)
      {
         AnyNumber.randnum(); //類別呼叫靜態方法

         //{N0}--不含小數位數，加上千位分號輸出
         WriteLine("Current number:" +
            $"\n{AnyNumber.currentNum:N0}");

         ReadKey();
      }
   }
}
