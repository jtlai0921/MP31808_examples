using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1106
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         //設定標籤屬性 -- 框線、背景色，字的大小和位置
         lblShow.BorderStyle = BorderStyle.FixedSingle;
         lblShow.BackColor = Color.GreenYellow;
         lblShow.Font = new Font(lblShow.Font.Name, 15.0F);
         lblShow.Location = new Point(3, 168);

         monCalendar.Dock = DockStyle.Top; //填滿上方

         // 改變行事曆的背景、前景顏色 
         monCalendar.ForeColor = Color.FromArgb(192, 0, 0);

         //週一為星期的第一天
         monCalendar.FirstDayOfWeek = Day.Monday;

         //行事曆顯示的期間2017/1/1 ~2018/12/31，最小日期為今天
         monCalendar.MaxDate = new
            DateTime(2018, 12, 31, 0, 0, 0, 0);
         monCalendar.MinDate = DateTime.Today;

         //同時間只能選取10天
         monCalendar.MaxSelectionCount = 10;

         //顯示週數
         monCalendar.ShowWeekNumbers = true;

         this.Text = "Ex1106 - 簡單行事曆";
      }

      private void monCalendar_DateSelected(object sender, DateRangeEventArgs e)
      {
         DateTime begin = e.Start;
         DateTime finish = e.End;
         TimeSpan days = finish - begin;
         int duration = days.Days + 1;
         float money = 1_500.0F;
         switch(duration)
         {
            case 1:
               money *= 1;
               break;
            case 2: case 3: case 4:
               money *= 0.95F;
               break;
            case 5: case 6:
               money *= 0.9F;
               break;
            default:
               money *= 0.8F;
               break;
         }         
      }
   }
}