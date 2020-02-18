using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0807
{
   //繼承Person類別
   class Human : Person
   {
      //使用new修飾詞，寫入新的屬性值
      public new int Height
         { get { return 175; } }

      public new string Hair
         { get { return "黑色"; } }

      //運算式主體 - override覆寫父類別同名稱showMessage
      public override void ShowMessage() => WriteLine(
         $"第二代，{Hair}頭髮，身高 ={Height} cm");
   }
}
