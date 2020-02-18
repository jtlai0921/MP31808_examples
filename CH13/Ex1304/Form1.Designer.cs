namespace Ex1304
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
         this.lstCourse = new System.Windows.Forms.ListBox();
         this.txtCourse = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnOK = new System.Windows.Forms.Button();
         this.btnDel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lstCourse
         // 
         this.lstCourse.FormattingEnabled = true;
         this.lstCourse.ItemHeight = 28;
         this.lstCourse.Location = new System.Drawing.Point(6, 37);
         this.lstCourse.Name = "lstCourse";
         this.lstCourse.Size = new System.Drawing.Size(142, 88);
         this.lstCourse.TabIndex = 4;
         // 
         // txtCourse
         // 
         this.txtCourse.Location = new System.Drawing.Point(136, 3);
         this.txtCourse.Name = "txtCourse";
         this.txtCourse.Size = new System.Drawing.Size(90, 37);
         this.txtCourse.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(1, 6);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(144, 28);
         this.label1.TabIndex = 0;
         this.label1.Text = "輸入科目名稱";
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(154, 38);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(72, 35);
         this.btnOK.TabIndex = 2;
         this.btnOK.Text = "新增";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnDel
         // 
         this.btnDel.Location = new System.Drawing.Point(154, 79);
         this.btnDel.Name = "btnDel";
         this.btnDel.Size = new System.Drawing.Size(72, 37);
         this.btnDel.TabIndex = 3;
         this.btnDel.Text = "刪除";
         this.btnDel.UseVisualStyleBackColor = true;
         this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(251, 133);
         this.Controls.Add(this.txtCourse);
         this.Controls.Add(this.btnDel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lstCourse);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1304";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lstCourse;
      private System.Windows.Forms.TextBox txtCourse;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnDel;
   }
}

