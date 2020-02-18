namespace Ex1503
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
         this.txtShow = new System.Windows.Forms.TextBox();
         this.btnCreate = new System.Windows.Forms.Button();
         this.btnOpen = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtShow
         // 
         this.txtShow.Location = new System.Drawing.Point(9, 8);
         this.txtShow.Multiline = true;
         this.txtShow.Name = "txtShow";
         this.txtShow.Size = new System.Drawing.Size(155, 87);
         this.txtShow.TabIndex = 5;
         // 
         // btnCreate
         // 
         this.btnCreate.Location = new System.Drawing.Point(167, 8);
         this.btnCreate.Name = "btnCreate";
         this.btnCreate.Size = new System.Drawing.Size(94, 33);
         this.btnCreate.TabIndex = 4;
         this.btnCreate.Text = "建立檔案";
         this.btnCreate.UseVisualStyleBackColor = true;
         this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
         // 
         // btnOpen
         // 
         this.btnOpen.Location = new System.Drawing.Point(166, 62);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(94, 33);
         this.btnOpen.TabIndex = 3;
         this.btnOpen.Text = "開啟檔案";
         this.btnOpen.UseVisualStyleBackColor = true;
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(274, 100);
         this.Controls.Add(this.txtShow);
         this.Controls.Add(this.btnCreate);
         this.Controls.Add(this.btnOpen);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1503";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtShow;
      private System.Windows.Forms.Button btnCreate;
      private System.Windows.Forms.Button btnOpen;
   }
}

