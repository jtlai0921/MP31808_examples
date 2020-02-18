namespace Ex1403
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
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtPwd = new System.Windows.Forms.TextBox();
         this.lblMsg = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 2);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 28);
         this.label1.TabIndex = 0;
         this.label1.Text = "名稱：";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 44);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 1;
         this.label2.Text = "密碼：";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(85, 2);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(100, 37);
         this.txtName.TabIndex = 2;
         // 
         // txtPwd
         // 
         this.txtPwd.Location = new System.Drawing.Point(85, 44);
         this.txtPwd.MaxLength = 6;
         this.txtPwd.Name = "txtPwd";
         this.txtPwd.PasswordChar = '*';
         this.txtPwd.Size = new System.Drawing.Size(100, 37);
         this.txtPwd.TabIndex = 3;
         this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
         // 
         // lblMsg
         // 
         this.lblMsg.AutoSize = true;
         this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblMsg.Location = new System.Drawing.Point(17, 89);
         this.lblMsg.Name = "lblMsg";
         this.lblMsg.Size = new System.Drawing.Size(77, 30);
         this.lblMsg.TabIndex = 4;
         this.lblMsg.Text = "label3";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(251, 125);
         this.Controls.Add(this.lblMsg);
         this.Controls.Add(this.txtPwd);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1403";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.TextBox txtPwd;
      private System.Windows.Forms.Label lblMsg;
   }
}

