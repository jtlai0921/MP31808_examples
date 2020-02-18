namespace Ex1203
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
         this.dlgFont = new System.Windows.Forms.FontDialog();
         this.dlgColor = new System.Windows.Forms.ColorDialog();
         this.btnColor = new System.Windows.Forms.Button();
         this.btnFont = new System.Windows.Forms.Button();
         this.rtxtShow = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // btnColor
         // 
         this.btnColor.Location = new System.Drawing.Point(11, 7);
         this.btnColor.Name = "btnColor";
         this.btnColor.Size = new System.Drawing.Size(75, 31);
         this.btnColor.TabIndex = 0;
         this.btnColor.Text = "色彩";
         this.btnColor.UseVisualStyleBackColor = true;
         this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
         // 
         // btnFont
         // 
         this.btnFont.Location = new System.Drawing.Point(159, 7);
         this.btnFont.Name = "btnFont";
         this.btnFont.Size = new System.Drawing.Size(77, 31);
         this.btnFont.TabIndex = 1;
         this.btnFont.Text = "字型";
         this.btnFont.UseVisualStyleBackColor = true;
         this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
         // 
         // rtxtShow
         // 
         this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.rtxtShow.Location = new System.Drawing.Point(0, 46);
         this.rtxtShow.Name = "rtxtShow";
         this.rtxtShow.Size = new System.Drawing.Size(251, 96);
         this.rtxtShow.TabIndex = 2;
         this.rtxtShow.Text = "";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(251, 142);
         this.Controls.Add(this.rtxtShow);
         this.Controls.Add(this.btnFont);
         this.Controls.Add(this.btnColor);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1203";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.FontDialog dlgFont;
      private System.Windows.Forms.ColorDialog dlgColor;
      private System.Windows.Forms.Button btnColor;
      private System.Windows.Forms.Button btnFont;
      private System.Windows.Forms.RichTextBox rtxtShow;
   }
}

