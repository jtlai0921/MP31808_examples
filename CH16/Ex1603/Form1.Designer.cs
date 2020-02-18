namespace Ex1603
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
         this.txtDbShow = new System.Windows.Forms.TextBox();
         this.btnAccess = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtDbShow
         // 
         this.txtDbShow.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.txtDbShow.Location = new System.Drawing.Point(0, 59);
         this.txtDbShow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
         this.txtDbShow.Multiline = true;
         this.txtDbShow.Name = "txtDbShow";
         this.txtDbShow.Size = new System.Drawing.Size(439, 239);
         this.txtDbShow.TabIndex = 3;
         // 
         // btnAccess
         // 
         this.btnAccess.Location = new System.Drawing.Point(9, 4);
         this.btnAccess.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
         this.btnAccess.Name = "btnAccess";
         this.btnAccess.Size = new System.Drawing.Size(298, 47);
         this.btnAccess.TabIndex = 2;
         this.btnAccess.Text = "開啟Access資料庫";
         this.btnAccess.UseVisualStyleBackColor = true;
         this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(439, 298);
         this.Controls.Add(this.txtDbShow);
         this.Controls.Add(this.btnAccess);
         this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
         this.Name = "Form1";
         this.Text = "Ex1603";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtDbShow;
      private System.Windows.Forms.Button btnAccess;
   }
}

