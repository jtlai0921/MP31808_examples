using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0713
{
   class ChoiceArg
   {
      //定義類別方法
      void CalcScore(int eng = 0, int math = 0, int chin = 0)
      {
         int result = eng + math + chin;
         WriteLine($"總分：{result}");
      }

      //主程式
      static void Main(string[] args)
      {
         ChoiceArg Tommy = new ChoiceArg();//產生物件
         Write("Tommy，");
         Tommy.CalcScore(56, 78, 92);//傳遞3個引數
         ChoiceArg Judy = new ChoiceArg();
         Write("Judy，");//傳遞1個引數
         Judy.CalcScore(85);
         ChoiceArg Daniel = new ChoiceArg();
         Write("Daniel，");//傳遞2個引數
         Daniel.CalcScore(56, 83);

         ReadKey();
      }
   }
}
