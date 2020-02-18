using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0902
{
   //建立泛型類別Student，含有T型別參數，能以不同型別來建立資料
   class Student<T>
   {
      private int index;//陣列索引值
      private T[] multi_group = new T[5]; //儲存6個元素

      //將資料放入陣列，stirng, int型別
      public void StoreArray(T arrData)
      {
         if (index < multi_group.Length)
         {
            multi_group[index] = arrData;
            index++;
         }
      }

      //讀取陣列元素
      public void ShowMessage()
      {
         foreach (T item in multi_group)
         {
            Write($"{item, -6} ");
         }
         WriteLine();
      }
   }
}
