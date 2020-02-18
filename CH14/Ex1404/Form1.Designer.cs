namespace Ex1404
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
         this.txtPosition = new System.Windows.Forms.TextBox();
         this.txtEvent = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // txtPosition
         // 
         this.txtPosition.BackColor = System.Drawing.Color.Bisque;
         this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtPosition.Location = new System.Drawing.Point(12, 55);
         this.txtPosition.Name = "txtPosition";
         this.txtPosition.Size = new System.Drawing.Size(150, 37);
         this.txtPosition.TabIndex = 3;
         // 
         // txtEvent
         // 
         this.txtEvent.BackColor = System.Drawing.Color.PowderBlue;
         this.txtEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtEvent.Location = new System.Drawing.Point(12, 12);
         this.txtEvent.Name = "txtEvent";
         this.txtEvent.Size = new System.Drawing.Size(150, 37);
         this.txtEvent.TabIndex = 2;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(251, 119);
         this.Controls.Add(this.txtPosition);
         this.Controls.Add(this.txtEvent);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1404";
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtPosition;
      private System.Windows.Forms.TextBox txtEvent;
   }
}

