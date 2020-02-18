namespace Ex1303
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
         this.lblDisplay = new System.Windows.Forms.Label();
         this.chkItalic = new System.Windows.Forms.CheckBox();
         this.chkBold = new System.Windows.Forms.CheckBox();
         this.chkStd = new System.Windows.Forms.CheckBox();
         this.label2 = new System.Windows.Forms.Label();
         this.cobFontChoice = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.cobFontSize = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // lblDisplay
         // 
         this.lblDisplay.Location = new System.Drawing.Point(-1, 74);
         this.lblDisplay.Name = "lblDisplay";
         this.lblDisplay.Size = new System.Drawing.Size(246, 69);
         this.lblDisplay.TabIndex = 10;
         this.lblDisplay.Text = "Visual C# 2015";
         this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // chkItalic
         // 
         this.chkItalic.Location = new System.Drawing.Point(0, 0);
         this.chkItalic.Name = "chkItalic";
         this.chkItalic.Size = new System.Drawing.Size(104, 24);
         this.chkItalic.TabIndex = 0;
         // 
         // chkBold
         // 
         this.chkBold.Location = new System.Drawing.Point(0, 0);
         this.chkBold.Name = "chkBold";
         this.chkBold.Size = new System.Drawing.Size(104, 24);
         this.chkBold.TabIndex = 0;
         // 
         // chkStd
         // 
         this.chkStd.Location = new System.Drawing.Point(0, 0);
         this.chkStd.Name = "chkStd";
         this.chkStd.Size = new System.Drawing.Size(104, 24);
         this.chkStd.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(0, 4);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(122, 28);
         this.label2.TabIndex = 7;
         this.label2.Text = "選擇字型：";
         // 
         // cobFontChoice
         // 
         this.cobFontChoice.FormattingEnabled = true;
         this.cobFontChoice.Location = new System.Drawing.Point(0, 32);
         this.cobFontChoice.Name = "cobFontChoice";
         this.cobFontChoice.Size = new System.Drawing.Size(122, 36);
         this.cobFontChoice.TabIndex = 5;
         this.cobFontChoice.Text = "字型樣式";
         this.cobFontChoice.SelectedIndexChanged += new System.EventHandler(this.cobFontChoice_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(123, 4);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(122, 28);
         this.label1.TabIndex = 8;
         this.label1.Text = "字型大小：";
         // 
         // cobFontSize
         // 
         this.cobFontSize.FormattingEnabled = true;
         this.cobFontSize.Location = new System.Drawing.Point(123, 32);
         this.cobFontSize.Name = "cobFontSize";
         this.cobFontSize.Size = new System.Drawing.Size(121, 36);
         this.cobFontSize.TabIndex = 6;
         this.cobFontSize.Text = "字型效果";
         this.cobFontSize.SelectedIndexChanged += new System.EventHandler(this.cobFontSize_SelectedIndexChanged);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(251, 144);
         this.Controls.Add(this.lblDisplay);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.cobFontChoice);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cobFontSize);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1303";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblDisplay;
      private System.Windows.Forms.CheckBox chkItalic;
      private System.Windows.Forms.CheckBox chkBold;
      private System.Windows.Forms.CheckBox chkStd;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cobFontChoice;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cobFontSize;
   }
}

