using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0809
{
   class ZctWorker
   {
      static void Main(string[] args)
      {
         //以陣列方式宣告每個繼承類別的實作物件
         Staff[] staffs = {
            new Team("Annabelle", 35_000, 1_800),
            new Worker("Janet", 1_500, 25),
            new Provisional("Tomas", 242, 5, 18)
         };

         System.Console.WriteLine("**  列出員工薪資  **");

         //foreach讀取陣列元素，並輸叫showMessage()方法輸出訊息
         foreach (Staff sf in staffs)
            sf.ShowMessage();

         Console.ReadKey();
      }
   }
}
