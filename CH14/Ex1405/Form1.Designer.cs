namespace Ex1405
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
         this.rtxtShow = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // rtxtShow
         // 
         this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Fill;
         this.rtxtShow.Location = new System.Drawing.Point(0, 0);
         this.rtxtShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.rtxtShow.Name = "rtxtShow";
         this.rtxtShow.Size = new System.Drawing.Size(358, 226);
         this.rtxtShow.TabIndex = 1;
         this.rtxtShow.Text = "";         
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(358, 226);
         this.Controls.Add(this.rtxtShow);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1405";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.RichTextBox rtxtShow;
   }
}

