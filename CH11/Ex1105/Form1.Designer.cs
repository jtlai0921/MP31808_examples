namespace Ex1105
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
         this.components = new System.ComponentModel.Container();
         this.prbTimeBar = new System.Windows.Forms.ProgressBar();
         this.btnExit = new System.Windows.Forms.Button();
         this.btnStart = new System.Windows.Forms.Button();
         this.tmrReckon = new System.Windows.Forms.Timer(this.components);
         this.lblInfo = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // prbTimeBar
         // 
         this.prbTimeBar.Location = new System.Drawing.Point(8, 9);
         this.prbTimeBar.Name = "prbTimeBar";
         this.prbTimeBar.Size = new System.Drawing.Size(284, 39);
         this.prbTimeBar.TabIndex = 5;
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(182, 101);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(110, 37);
         this.btnExit.TabIndex = 4;
         this.btnExit.Text = "結束";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // btnStart
         // 
         this.btnStart.Location = new System.Drawing.Point(8, 101);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(110, 37);
         this.btnStart.TabIndex = 3;
         this.btnStart.Text = "開始計時";
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // tmrReckon
         // 
         this.tmrReckon.Interval = 250;
         this.tmrReckon.Tick += new System.EventHandler(this.tmrReckon_Tick);
         // 
         // lblInfo
         // 
         this.lblInfo.AutoSize = true;
         this.lblInfo.Location = new System.Drawing.Point(104, 61);
         this.lblInfo.Name = "lblInfo";
         this.lblInfo.Size = new System.Drawing.Size(75, 28);
         this.lblInfo.TabIndex = 6;
         this.lblInfo.Text = "label1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 139);
         this.Controls.Add(this.lblInfo);
         this.Controls.Add(this.prbTimeBar);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnStart);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1105";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ProgressBar prbTimeBar;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.Timer tmrReckon;
      private System.Windows.Forms.Label lblInfo;
   }
}

