namespace Ex1101
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
         this.lblMsg = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtMoney = new System.Windows.Forms.TextBox();
         this.btnShow = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblMsg
         // 
         this.lblMsg.Location = new System.Drawing.Point(38, 111);
         this.lblMsg.Name = "lblMsg";
         this.lblMsg.Size = new System.Drawing.Size(208, 56);
         this.lblMsg.TabIndex = 0;
         this.lblMsg.Text = "label1";
         this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(2, 14);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 1;
         this.label2.Text = "名稱：";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(2, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 28);
         this.label3.TabIndex = 2;
         this.label3.Text = "提款額：";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(92, 11);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(110, 37);
         this.txtName.TabIndex = 3;
         // 
         // txtMoney
         // 
         this.txtMoney.Location = new System.Drawing.Point(92, 58);
         this.txtMoney.Name = "txtMoney";
         this.txtMoney.Size = new System.Drawing.Size(110, 37);
         this.txtMoney.TabIndex = 4;
         // 
         // btnShow
         // 
         this.btnShow.Location = new System.Drawing.Point(210, 11);
         this.btnShow.Name = "btnShow";
         this.btnShow.Size = new System.Drawing.Size(75, 37);
         this.btnShow.TabIndex = 5;
         this.btnShow.Text = "顯示";
         this.btnShow.UseVisualStyleBackColor = true;
         this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(293, 180);
         this.Controls.Add(this.btnShow);
         this.Controls.Add(this.txtMoney);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lblMsg);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1101";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblMsg;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.TextBox txtMoney;
      private System.Windows.Forms.Button btnShow;
   }
}

