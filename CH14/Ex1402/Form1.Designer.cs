namespace Ex1402
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
         this.picShow = new System.Windows.Forms.PictureBox();
         this.lblState = new System.Windows.Forms.Label();
         this.lblData = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
         this.SuspendLayout();
         // 
         // picShow
         // 
         this.picShow.Image = global::Ex1402.Properties.Resources._006;
         this.picShow.Location = new System.Drawing.Point(12, 12);
         this.picShow.Name = "picShow";
         this.picShow.Size = new System.Drawing.Size(122, 93);
         this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.picShow.TabIndex = 0;
         this.picShow.TabStop = false;
         // 
         // lblState
         // 
         this.lblState.AutoSize = true;
         this.lblState.Location = new System.Drawing.Point(141, 9);
         this.lblState.Name = "lblState";
         this.lblState.Size = new System.Drawing.Size(75, 28);
         this.lblState.TabIndex = 1;
         this.lblState.Text = "label1";
         // 
         // lblData
         // 
         this.lblData.AutoSize = true;
         this.lblData.Location = new System.Drawing.Point(180, 55);
         this.lblData.Name = "lblData";
         this.lblData.Size = new System.Drawing.Size(75, 28);
         this.lblData.TabIndex = 2;
         this.lblData.Text = "label2";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(305, 219);
         this.Controls.Add(this.lblData);
         this.Controls.Add(this.lblState);
         this.Controls.Add(this.picShow);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1402";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
         ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox picShow;
      private System.Windows.Forms.Label lblState;
      private System.Windows.Forms.Label lblData;
   }
}

