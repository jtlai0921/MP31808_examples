namespace Ex1001
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
         this.btnShow = new System.Windows.Forms.Button();
         this.lblDisplay = new System.Windows.Forms.Label();
         this.btnEnd = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnShow
         // 
         this.btnShow.Location = new System.Drawing.Point(28, 71);
         this.btnShow.Margin = new System.Windows.Forms.Padding(5);
         this.btnShow.Name = "btnShow";
         this.btnShow.Size = new System.Drawing.Size(109, 35);
         this.btnShow.TabIndex = 0;
         this.btnShow.Text = "顯示";
         this.btnShow.UseVisualStyleBackColor = true;
         this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
         // 
         // lblDisplay
         // 
         this.lblDisplay.AutoSize = true;
         this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblDisplay.ForeColor = System.Drawing.Color.Blue;
         this.lblDisplay.Location = new System.Drawing.Point(40, 22);
         this.lblDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
         this.lblDisplay.Name = "lblDisplay";
         this.lblDisplay.Size = new System.Drawing.Size(135, 30);
         this.lblDisplay.TabIndex = 1;
         this.lblDisplay.Text = "Label控制項";
         // 
         // btnEnd
         // 
         this.btnEnd.Location = new System.Drawing.Point(159, 71);
         this.btnEnd.Margin = new System.Windows.Forms.Padding(5);
         this.btnEnd.Name = "btnEnd";
         this.btnEnd.Size = new System.Drawing.Size(109, 35);
         this.btnEnd.TabIndex = 2;
         this.btnEnd.Text = "結束";
         this.btnEnd.UseVisualStyleBackColor = true;
         this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(290, 113);
         this.Controls.Add(this.btnEnd);
         this.Controls.Add(this.lblDisplay);
         this.Controls.Add(this.btnShow);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(5);
         this.Name = "Form1";
         this.Text = "顯示訊息";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnShow;
      private System.Windows.Forms.Label lblDisplay;
      private System.Windows.Forms.Button btnEnd;
   }
}

