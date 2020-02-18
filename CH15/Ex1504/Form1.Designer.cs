namespace Ex1504
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
         this.btnCreate = new System.Windows.Forms.Button();
         this.txtShow = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnCreate
         // 
         this.btnCreate.Location = new System.Drawing.Point(255, 9);
         this.btnCreate.Name = "btnCreate";
         this.btnCreate.Size = new System.Drawing.Size(90, 34);
         this.btnCreate.TabIndex = 3;
         this.btnCreate.Text = "讀取位元";
         this.btnCreate.UseVisualStyleBackColor = true;
         this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
         // 
         // txtShow
         // 
         this.txtShow.Location = new System.Drawing.Point(-2, 2);
         this.txtShow.Multiline = true;
         this.txtShow.Name = "txtShow";
         this.txtShow.Size = new System.Drawing.Size(251, 134);
         this.txtShow.TabIndex = 2;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(352, 139);
         this.Controls.Add(this.btnCreate);
         this.Controls.Add(this.txtShow);
         this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1504";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCreate;
      private System.Windows.Forms.TextBox txtShow;
   }
}

