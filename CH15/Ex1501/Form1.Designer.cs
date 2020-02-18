namespace Ex1501
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
         this.txtInfo = new System.Windows.Forms.TextBox();
         this.btnDeleteDir = new System.Windows.Forms.Button();
         this.btnAddDir = new System.Windows.Forms.Button();
         this.btnView = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtInfo
         // 
         this.txtInfo.Dock = System.Windows.Forms.DockStyle.Left;
         this.txtInfo.Location = new System.Drawing.Point(0, 0);
         this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.txtInfo.Multiline = true;
         this.txtInfo.Name = "txtInfo";
         this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtInfo.Size = new System.Drawing.Size(303, 135);
         this.txtInfo.TabIndex = 7;
         // 
         // btnDeleteDir
         // 
         this.btnDeleteDir.Location = new System.Drawing.Point(299, 92);
         this.btnDeleteDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.btnDeleteDir.Name = "btnDeleteDir";
         this.btnDeleteDir.Size = new System.Drawing.Size(85, 36);
         this.btnDeleteDir.TabIndex = 6;
         this.btnDeleteDir.Text = "刪除目錄";
         this.btnDeleteDir.UseVisualStyleBackColor = true;
         this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
         // 
         // btnAddDir
         // 
         this.btnAddDir.Location = new System.Drawing.Point(299, 46);
         this.btnAddDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.btnAddDir.Name = "btnAddDir";
         this.btnAddDir.Size = new System.Drawing.Size(85, 36);
         this.btnAddDir.TabIndex = 5;
         this.btnAddDir.Text = "新增目錄";
         this.btnAddDir.UseVisualStyleBackColor = true;
         this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
         // 
         // btnView
         // 
         this.btnView.Location = new System.Drawing.Point(299, 0);
         this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.btnView.Name = "btnView";
         this.btnView.Size = new System.Drawing.Size(85, 36);
         this.btnView.TabIndex = 4;
         this.btnView.Text = "檢視目錄";
         this.btnView.UseVisualStyleBackColor = true;
         this.btnView.Click += new System.EventHandler(this.btnView_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(389, 135);
         this.Controls.Add(this.txtInfo);
         this.Controls.Add(this.btnDeleteDir);
         this.Controls.Add(this.btnAddDir);
         this.Controls.Add(this.btnView);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1501";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtInfo;
      private System.Windows.Forms.Button btnDeleteDir;
      private System.Windows.Forms.Button btnAddDir;
      private System.Windows.Forms.Button btnView;
   }
}

