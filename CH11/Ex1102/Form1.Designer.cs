namespace Ex1102
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
         this.lnkOpenApp = new System.Windows.Forms.LinkLabel();
         this.lnkGetIP = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // lnkOpenApp
         // 
         this.lnkOpenApp.AutoSize = true;
         this.lnkOpenApp.LinkArea = new System.Windows.Forms.LinkArea(14, 4);
         this.lnkOpenApp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
         this.lnkOpenApp.LinkVisited = true;
         this.lnkOpenApp.Location = new System.Drawing.Point(6, 77);
         this.lnkOpenApp.Name = "lnkOpenApp";
         this.lnkOpenApp.Size = new System.Drawing.Size(292, 36);
         this.lnkOpenApp.TabIndex = 0;
         this.lnkOpenApp.TabStop = true;
         this.lnkOpenApp.Text = "Windows Forms的程式設計";
         this.lnkOpenApp.UseCompatibleTextRendering = true;
         this.lnkOpenApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenApp_LinkClicked);
         // 
         // lnkGetIP
         // 
         this.lnkGetIP.AutoSize = true;
         this.lnkGetIP.Location = new System.Drawing.Point(85, 26);
         this.lnkGetIP.Name = "lnkGetIP";
         this.lnkGetIP.Size = new System.Drawing.Size(117, 28);
         this.lnkGetIP.TabIndex = 1;
         this.lnkGetIP.TabStop = true;
         this.lnkGetIP.Text = "linkLabel1";
         this.lnkGetIP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGetIP_LinkClicked);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(307, 122);
         this.Controls.Add(this.lnkGetIP);
         this.Controls.Add(this.lnkOpenApp);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1102";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.LinkLabel lnkOpenApp;
      private System.Windows.Forms.LinkLabel lnkGetIP;
   }
}

