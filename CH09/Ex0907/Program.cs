using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Queue<T>類別, 以Enqueue()方法將項目由尾端加入，Dequeue()移除最前端項目
namespace Ex0907
{
   class Program
   {
      static void Main(string[] args)
      {
         Int32 one, index = 6;
         //建立佇列物件
         Queue<string> fruit = new Queue<string>();
         string[] name = {"Strawberry", "Watermelon", "Apple",
            "Orange", "Banana", "Mango"};

         foreach (var item in name)         
            fruit.Enqueue(item); //由末端加入元素
         

         //Peek()方法顯示第一樣水果 
         if (fruit.Count > 0)
         {
            one = index - fruit.Count + 1;
            WriteLine($"第{one}個水果 - {fruit.Peek()}");
         }
         itemPrint(fruit);

         //Dequeue()移除最前端項目
         if (fruit.Count > 0)
         {
            one = index - fruit.Count + 1;
            WriteLine($"移除第{one}個水果 - {fruit.Dequeue()}");
         }
         itemPrint(fruit);

         ReadKey();
      }

      //for廻圈讀取項目
      public static void itemPrint(Queue<string> plant)
      {
         Int32 index = 0;//儲存索引         
         foreach (var item in plant)
         {
            WriteLine($"[{index}] - {item,-10}");
            index++;
         }

         //了解GetEnumerator()方法的使用
         /*IEnumerator<string> list = plant.GetEnumerator();
         while (list.MoveNext())
         {
            string item = list.Current.ToString();
            WriteLine($"[{index}] - {item,-10}");
            index++;
         }*/

         WriteLine($"有{plant.Count}樣水果");
      }
   }
}
