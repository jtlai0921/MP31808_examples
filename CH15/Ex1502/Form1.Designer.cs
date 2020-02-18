namespace Ex1502
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
         this.btnView = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnCopy = new System.Windows.Forms.Button();
         this.btnCreate = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtShow
         // 
         this.txtShow.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.txtShow.Location = new System.Drawing.Point(0, 40);
         this.txtShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.txtShow.Multiline = true;
         this.txtShow.Name = "txtShow";
         this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtShow.Size = new System.Drawing.Size(361, 146);
         this.txtShow.TabIndex = 9;
         // 
         // btnView
         // 
         this.btnView.Location = new System.Drawing.Point(220, 1);
         this.btnView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.btnView.Name = "btnView";
         this.btnView.Size = new System.Drawing.Size(73, 35);
         this.btnView.TabIndex = 8;
         this.btnView.Text = "檢視";
         this.btnView.UseVisualStyleBackColor = true;
         this.btnView.Click += new System.EventHandler(this.btnView_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(146, 1);
         this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(73, 35);
         this.btnDelete.TabIndex = 7;
         this.btnDelete.Text = "刪除";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnCopy
         // 
         this.btnCopy.Location = new System.Drawing.Point(73, 1);
         this.btnCopy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.btnCopy.Name = "btnCopy";
         this.btnCopy.Size = new System.Drawing.Size(73, 35);
         this.btnCopy.TabIndex = 6;
         this.btnCopy.Text = "複製";
         this.btnCopy.UseVisualStyleBackColor = true;
         this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
         // 
         // btnCreate
         // 
         this.btnCreate.Location = new System.Drawing.Point(0, 1);
         this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
         this.btnCreate.Name = "btnCreate";
         this.btnCreate.Size = new System.Drawing.Size(73, 35);
         this.btnCreate.TabIndex = 5;
         this.btnCreate.Text = "新增";
         this.btnCreate.UseVisualStyleBackColor = true;
         this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(361, 186);
         this.Controls.Add(this.txtShow);
         this.Controls.Add(this.btnView);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCopy);
         this.Controls.Add(this.btnCreate);
         this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1502";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtShow;
      private System.Windows.Forms.Button btnView;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnCopy;
      private System.Windows.Forms.Button btnCreate;
   }
}

