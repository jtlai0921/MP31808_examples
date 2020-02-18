using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

//使用ArrayList
namespace Ex0905
{
   class Program
   {
      private static readonly string[] Subjects =
         {"程式語言", "資訊數學", "計算機概論", "多媒體", "網路概論"};
      private static readonly string[] choiceSubject =
         {"英文會話", "資訊數學", "網路概論"};

      static void Main(string[] args)
      {
         //建立第一個ArrayList, 指定項目個數(Capacity)為1
         ArrayList list = new ArrayList(1);
         //以Add()方法配合foreach廻圈加入項目
         foreach (var item in Subjects)
            list.Add(item);

         //建立第二個ArrayList，以為初始容量
         ArrayList selectCourse = new ArrayList(choiceSubject);

         WriteLine("科目：");
         Display(list);//呼叫Display()方法

         removeSubject(list, selectCourse);

         WriteLine("重新取得科目：");
         Display(list);

         ReadKey();
      }

      //顯示ArrayList項數個數和容量
      private static void Display(ArrayList Courses)
      {
         //讀取ArrayList的元素
         foreach (var item in Courses)
            Write($"{item} ");
         WriteLine($"\n科目 {Courses.Count}；" +
            $"含選修 {Courses.Capacity}");
         string word = "資訊數學";
         int index = Courses.IndexOf(word);
         if (index != -1)
            WriteLine(
               $"選修有「{word}」，索引：{index}.");
         else
            WriteLine($"{word} 已被刪除");
      }

      //移除ArrayList陣列中的元素
      private static void removeSubject(ArrayList one,
            ArrayList two)
      {
         //Remove()方法移除ArrayList指定項目
         for (int item = 0; item < two.Count; item++)
            one.Remove(two[item]);
      }
   }
}
