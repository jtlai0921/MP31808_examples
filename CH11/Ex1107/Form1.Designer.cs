﻿namespace Ex1107
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
         this.dtpPreDate = new System.Windows.Forms.DateTimePicker();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtTicket = new System.Windows.Forms.TextBox();
         this.btnOK = new System.Windows.Forms.Button();
         this.lblShow = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // dtpPreDate
         // 
         this.dtpPreDate.Location = new System.Drawing.Point(123, 5);
         this.dtpPreDate.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
         this.dtpPreDate.MinDate = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
         this.dtpPreDate.Name = "dtpPreDate";
         this.dtpPreDate.Size = new System.Drawing.Size(207, 37);
         this.dtpPreDate.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(7, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(122, 28);
         this.label1.TabIndex = 1;
         this.label1.Text = "預購日期：";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(7, 45);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 2;
         this.label2.Text = "名稱：";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(71, 44);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(123, 37);
         this.txtName.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(196, 47);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(122, 28);
         this.label3.TabIndex = 4;
         this.label3.Text = "訂購票數：";
         // 
         // txtTicket
         // 
         this.txtTicket.Location = new System.Drawing.Point(302, 42);
         this.txtTicket.Name = "txtTicket";
         this.txtTicket.Size = new System.Drawing.Size(76, 37);
         this.txtTicket.TabIndex = 5;
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(305, 89);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 35);
         this.btnOK.TabIndex = 6;
         this.btnOK.Text = "確認";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // lblShow
         // 
         this.lblShow.BackColor = System.Drawing.Color.LightCyan;
         this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblShow.Location = new System.Drawing.Point(7, 83);
         this.lblShow.Name = "lblShow";
         this.lblShow.Size = new System.Drawing.Size(292, 82);
         this.lblShow.TabIndex = 7;
         this.lblShow.Text = "label4";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(381, 167);
         this.Controls.Add(this.lblShow);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.txtTicket);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dtpPreDate);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1107";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DateTimePicker dtpPreDate;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtTicket;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Label lblShow;
   }
}

