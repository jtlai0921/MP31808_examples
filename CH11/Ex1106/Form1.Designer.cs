namespace Ex1106
{
   partial class Form1
   {
      /// <summary>
      /// 設計工具所需的變數。
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 清除任何使用中的資源。
      /// </summary>
      /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 設計工具產生的程式碼

      /// <summary>
      /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
      /// 這個方法的內容。
      /// </summary>
      private void InitializeComponent()
      {
         this.monCalendar = new System.Windows.Forms.MonthCalendar();
         this.lblShow = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // monCalendar
         // 
         this.monCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 5, 12, 0, 0, 0, 0),
        new System.DateTime(2018, 6, 18, 0, 0, 0, 0),
        new System.DateTime(((long)(0)))};
         this.monCalendar.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.monCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
         this.monCalendar.Location = new System.Drawing.Point(-4, 3);
         this.monCalendar.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
         this.monCalendar.Name = "monCalendar";
         this.monCalendar.ScrollChange = 1;
         this.monCalendar.ShowTodayCircle = false;
         this.monCalendar.TabIndex = 0;
         this.monCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalendar_DateSelected);
         // 
         // lblShow
         // 
         this.lblShow.AutoSize = true;
         this.lblShow.Location = new System.Drawing.Point(4, 243);
         this.lblShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblShow.Name = "lblShow";
         this.lblShow.Size = new System.Drawing.Size(75, 28);
         this.lblShow.TabIndex = 1;
         this.lblShow.Text = "label1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(252, 201);
         this.Controls.Add(this.lblShow);
         this.Controls.Add(this.monCalendar);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Form1";
         this.Text = "Ex1106";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MonthCalendar monCalendar;
      private System.Windows.Forms.Label lblShow;
   }
}

