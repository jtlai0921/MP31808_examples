namespace Ex104
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
         this.toolFamily = new System.Windows.Forms.ToolStrip();
         this.toolOpen = new System.Windows.Forms.ToolStripButton();
         this.toolSave = new System.Windows.Forms.ToolStripButton();
         this.toolFamily.SuspendLayout();
         this.SuspendLayout();
         // 
         // toolFamily
         // 
         this.toolFamily.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.toolFamily.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpen,
            this.toolSave});
         this.toolFamily.Location = new System.Drawing.Point(0, 0);
         this.toolFamily.Name = "toolFamily";
         this.toolFamily.Size = new System.Drawing.Size(289, 38);
         this.toolFamily.TabIndex = 0;
         this.toolFamily.Text = "toolStrip1";
         // 
         // toolOpen
         // 
         this.toolOpen.AutoSize = false;
         this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolOpen.Image = global::Ex104.Properties.Resources.Open;
         this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolOpen.Name = "toolOpen";
         this.toolOpen.Size = new System.Drawing.Size(35, 35);
         this.toolOpen.Text = "開啟舊檔";
         // 
         // toolSave
         // 
         this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolSave.Image = global::Ex104.Properties.Resources.Save;
         this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolSave.Name = "toolSave";
         this.toolSave.Size = new System.Drawing.Size(28, 28);
         this.toolSave.Text = "儲存檔案";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(289, 275);
         this.Controls.Add(this.toolFamily);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Form1";
         this.toolFamily.ResumeLayout(false);
         this.toolFamily.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip toolFamily;
      private System.Windows.Forms.ToolStripButton toolOpen;
      private System.Windows.Forms.ToolStripButton toolSave;
   }
}

