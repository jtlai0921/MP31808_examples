namespace Ex1201
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
         this.DlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.DlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.btnOpen = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.rtxtShow = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // DlgOpenFile
         // 
         this.DlgOpenFile.FileName = "openFileDialog1";
         this.DlgOpenFile.FilterIndex = 0;
         // 
         // btnOpen
         // 
         this.btnOpen.Location = new System.Drawing.Point(7, 4);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(100, 36);
         this.btnOpen.TabIndex = 0;
         this.btnOpen.Text = "開啟檔案";
         this.btnOpen.UseVisualStyleBackColor = true;
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(190, 4);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(100, 36);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "儲存檔案";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // rtxtShow
         // 
         this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.rtxtShow.Location = new System.Drawing.Point(0, 46);
         this.rtxtShow.Name = "rtxtShow";
         this.rtxtShow.Size = new System.Drawing.Size(303, 161);
         this.rtxtShow.TabIndex = 2;
         this.rtxtShow.Text = "";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(303, 207);
         this.Controls.Add(this.rtxtShow);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnOpen);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1201";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.OpenFileDialog DlgOpenFile;
      private System.Windows.Forms.SaveFileDialog DlgSaveFile;
      private System.Windows.Forms.Button btnOpen;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.RichTextBox rtxtShow;
   }
}

