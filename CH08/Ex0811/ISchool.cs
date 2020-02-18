using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//定義兩個介面
namespace Ex0811
{
   interface ISchool   //介面一
   {
      //學分數, 顯示訊息
      int Subject { get; set; }
      void ShowMessage();      
   }

   interface IGrade   //介面二
   {
      int Status { get; set; }//學生身分
   }
}
