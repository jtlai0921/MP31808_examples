using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0801
{
   class School   //基礎類別
   {
      /* 屬性分別以public, protected 為存取修飾詞
       * subject : 存放科目名稱
       * room    : 取得教室編號
       * teacher : 授課老師
       */
      public string subject { get; set; }
      protected int room { get; set; }
      protected string teacher { get; set; }

      //建構函式設定屬性新值
      public School() 
      {
         subject = "計算機概論";
         room = 1205;
         teacher = "Leia Organa";
      }

      //方法主體定義-輸出屬性值
      public void ShowMsg() => Console.WriteLine(
         $"科目:{subject}, 教室-{room}, 老師:{teacher}");
   }
}