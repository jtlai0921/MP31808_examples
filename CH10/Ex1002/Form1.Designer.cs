namespace Ex1002
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtAccount = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.btnShow = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(15, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 28);
         this.label1.TabIndex = 0;
         this.label1.Text = "帳號：";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(15, 70);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 1;
         this.label2.Text = "密碼：";
         // 
         // txtAccount
         // 
         this.txtAccount.Location = new System.Drawing.Point(87, 26);
         this.txtAccount.Name = "txtAccount";
         this.txtAccount.Size = new System.Drawing.Size(112, 37);
         this.txtAccount.TabIndex = 2;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(87, 67);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '*';
         this.txtPassword.Size = new System.Drawing.Size(112, 37);
         this.txtPassword.TabIndex = 3;
         // 
         // btnShow
         // 
         this.btnShow.Location = new System.Drawing.Point(218, 24);
         this.btnShow.Name = "btnShow";
         this.btnShow.Size = new System.Drawing.Size(108, 39);
         this.btnShow.TabIndex = 4;
         this.btnShow.Text = "顯示";
         this.btnShow.UseVisualStyleBackColor = true;
         this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(336, 113);
         this.Controls.Add(this.btnShow);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtAccount);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1002";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtAccount;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Button btnShow;
   }
}

