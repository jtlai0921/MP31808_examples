namespace Ex1205
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.DocumentPrt = new System.Drawing.Printing.PrintDocument();
         this.DlgPrint = new System.Windows.Forms.PrintDialog();
         this.DlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
         this.btnPrint = new System.Windows.Forms.Button();
         this.btnPriview = new System.Windows.Forms.Button();
         this.CrlPrintPreview = new System.Windows.Forms.PrintPreviewControl();
         this.SuspendLayout();
         // 
         // DocumentPrt
         // 
         this.DocumentPrt.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.DocumentPrt_EndPrint);
         this.DocumentPrt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocumentPrt_PrintPage);
         // 
         // DlgPrint
         // 
         this.DlgPrint.UseEXDialog = true;
         // 
         // DlgPrintPreview
         // 
         this.DlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.DlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.DlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
         this.DlgPrintPreview.Enabled = true;
         this.DlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("DlgPrintPreview.Icon")));
         this.DlgPrintPreview.Name = "DlgPrintPreview";
         this.DlgPrintPreview.Visible = false;
         // 
         // btnPrint
         // 
         this.btnPrint.Location = new System.Drawing.Point(12, 156);
         this.btnPrint.Name = "btnPrint";
         this.btnPrint.Size = new System.Drawing.Size(88, 37);
         this.btnPrint.TabIndex = 0;
         this.btnPrint.Text = "列印";
         this.btnPrint.UseVisualStyleBackColor = true;
         this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
         // 
         // btnPriview
         // 
         this.btnPriview.Location = new System.Drawing.Point(141, 156);
         this.btnPriview.Name = "btnPriview";
         this.btnPriview.Size = new System.Drawing.Size(111, 37);
         this.btnPriview.TabIndex = 1;
         this.btnPriview.Text = "預覽列印";
         this.btnPriview.UseVisualStyleBackColor = true;
         this.btnPriview.Click += new System.EventHandler(this.btnPreview_Click);
         // 
         // CrlPrintPreview
         // 
         this.CrlPrintPreview.Location = new System.Drawing.Point(0, 0);
         this.CrlPrintPreview.Name = "CrlPrintPreview";
         this.CrlPrintPreview.Size = new System.Drawing.Size(265, 150);
         this.CrlPrintPreview.TabIndex = 2;
         this.CrlPrintPreview.Visible = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(268, 199);
         this.Controls.Add(this.CrlPrintPreview);
         this.Controls.Add(this.btnPriview);
         this.Controls.Add(this.btnPrint);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1205";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Drawing.Printing.PrintDocument DocumentPrt;
      private System.Windows.Forms.PrintDialog DlgPrint;
      private System.Windows.Forms.PrintPreviewDialog DlgPrintPreview;
      private System.Windows.Forms.Button btnPrint;
      private System.Windows.Forms.Button btnPriview;
      private System.Windows.Forms.PrintPreviewControl CrlPrintPreview;
   }
}

