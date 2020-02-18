namespace Ex1003
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
         this.btnClose = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(83, 99);
         this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(109, 35);
         this.btnClose.TabIndex = 0;
         this.btnClose.Text = "結束";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(279, 150);
         this.Controls.Add(this.btnClose);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
         this.Name = "Form1";
         this.Text = "Ex1003";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnClose;
   }
}

