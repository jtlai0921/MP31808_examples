﻿namespace Ex1604
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
         this.readDataGridView = new System.Windows.Forms.DataGridView();
         this.btnOpen = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.readDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // readDataGridView
         // 
         this.readDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.readDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.readDataGridView.Location = new System.Drawing.Point(0, 65);
         this.readDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.readDataGridView.Name = "readDataGridView";
         this.readDataGridView.RowTemplate.Height = 31;
         this.readDataGridView.Size = new System.Drawing.Size(533, 319);
         this.readDataGridView.TabIndex = 3;
         // 
         // btnOpen
         // 
         this.btnOpen.Location = new System.Drawing.Point(18, 7);
         this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(164, 54);
         this.btnOpen.TabIndex = 2;
         this.btnOpen.Text = "開啟資料庫";
         this.btnOpen.UseVisualStyleBackColor = true;
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(533, 384);
         this.Controls.Add(this.readDataGridView);
         this.Controls.Add(this.btnOpen);
         this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
         this.Name = "Form1";
         this.Text = "Ex1604";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.readDataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView readDataGridView;
      private System.Windows.Forms.Button btnOpen;
   }
}

