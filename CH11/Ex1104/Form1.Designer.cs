namespace Ex1104
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
         this.rtxtRTF = new System.Windows.Forms.RichTextBox();
         this.btnOpen = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // rtxtRTF
         // 
         this.rtxtRTF.Location = new System.Drawing.Point(-1, 4);
         this.rtxtRTF.Name = "rtxtRTF";
         this.rtxtRTF.Size = new System.Drawing.Size(260, 97);
         this.rtxtRTF.TabIndex = 0;
         this.rtxtRTF.Text = "";
         // 
         // btnOpen
         // 
         this.btnOpen.Location = new System.Drawing.Point(60, 108);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(110, 35);
         this.btnOpen.TabIndex = 1;
         this.btnOpen.Text = "開啟檔案";
         this.btnOpen.UseVisualStyleBackColor = true;
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(262, 146);
         this.Controls.Add(this.btnOpen);
         this.Controls.Add(this.rtxtRTF);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1104";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.RichTextBox rtxtRTF;
      private System.Windows.Forms.Button btnOpen;
   }
}

