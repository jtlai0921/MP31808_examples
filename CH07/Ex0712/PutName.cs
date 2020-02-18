using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0712
{
   //實際引數被呼叫時，使用具名引數傳遞引數
   class PutName
   {
      //定義靜態類別方法
      static int FeeAmount(string name, int amount, int price)
      {
         int result = amount * price;
         return result;
      }

      //主程式
      static void Main(string[] args)
      {
         Write("請輸入數量：");
         int unit = int.Parse(ReadLine());

         Write("請輸入金額：");
         int bill = int.Parse(ReadLine());

         //呼叫時指定引數的名稱
         int outcome = FeeAmount(amount: unit,
            price: bill, name: "Mr. White");
         WriteLine($"Mr. White! 付款金額 {outcome:c}");

         ReadKey();
      }
   }
}
