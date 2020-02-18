namespace Ex1004
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
         this.label3 = new System.Windows.Forms.Label();
         this.txtAccount = new System.Windows.Forms.TextBox();
         this.txtPwd = new System.Windows.Forms.TextBox();
         this.rabMale = new System.Windows.Forms.RadioButton();
         this.rabFemale = new System.Windows.Forms.RadioButton();
         this.btnCheck = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 28);
         this.label1.TabIndex = 0;
         this.label1.Text = "帳號：";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(9, 45);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 2;
         this.label2.Text = "密碼：";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 76);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(78, 28);
         this.label3.TabIndex = 4;
         this.label3.Text = "性別：";
         // 
         // txtAccount
         // 
         this.txtAccount.Location = new System.Drawing.Point(69, 6);
         this.txtAccount.MaxLength = 20;
         this.txtAccount.Name = "txtAccount";
         this.txtAccount.Size = new System.Drawing.Size(125, 37);
         this.txtAccount.TabIndex = 1;
         // 
         // txtPwd
         // 
         this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPwd.Location = new System.Drawing.Point(69, 44);
         this.txtPwd.MaxLength = 10;
         this.txtPwd.Name = "txtPwd";
         this.txtPwd.PasswordChar = '*';
         this.txtPwd.Size = new System.Drawing.Size(125, 30);
         this.txtPwd.TabIndex = 3;
         // 
         // rabMale
         // 
         this.rabMale.AutoSize = true;
         this.rabMale.Location = new System.Drawing.Point(69, 76);
         this.rabMale.Name = "rabMale";
         this.rabMale.Size = new System.Drawing.Size(81, 32);
         this.rabMale.TabIndex = 5;
         this.rabMale.TabStop = true;
         this.rabMale.Text = "帥哥";
         this.rabMale.UseVisualStyleBackColor = true;
         // 
         // rabFemale
         // 
         this.rabFemale.AutoSize = true;
         this.rabFemale.Location = new System.Drawing.Point(137, 76);
         this.rabFemale.Name = "rabFemale";
         this.rabFemale.Size = new System.Drawing.Size(81, 32);
         this.rabFemale.TabIndex = 6;
         this.rabFemale.TabStop = true;
         this.rabFemale.Text = "美女";
         this.rabFemale.UseVisualStyleBackColor = true;
         // 
         // btnCheck
         // 
         this.btnCheck.Location = new System.Drawing.Point(200, 8);
         this.btnCheck.Name = "btnCheck";
         this.btnCheck.Size = new System.Drawing.Size(66, 36);
         this.btnCheck.TabIndex = 7;
         this.btnCheck.Text = "確認";
         this.btnCheck.UseVisualStyleBackColor = true;
         this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(270, 113);
         this.Controls.Add(this.btnCheck);
         this.Controls.Add(this.rabFemale);
         this.Controls.Add(this.rabMale);
         this.Controls.Add(this.txtPwd);
         this.Controls.Add(this.txtAccount);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1004";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtAccount;
      private System.Windows.Forms.TextBox txtPwd;
      private System.Windows.Forms.RadioButton rabMale;
      private System.Windows.Forms.RadioButton rabFemale;
      private System.Windows.Forms.Button btnCheck;
   }
}

