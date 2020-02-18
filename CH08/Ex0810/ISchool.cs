using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0810
{
   interface ISchool
   {
      //統計學生人數, 顯示訊息
      int Subject { get; set; }
      void ShowMessage();
   }
}
