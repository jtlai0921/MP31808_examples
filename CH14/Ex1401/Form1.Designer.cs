namespace Ex1401
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
         this.menuMain = new System.Windows.Forms.MenuStrip();
         this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmWnd = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmNewFile = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmArrange = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmHorizon = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmVertical = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmCascade = new System.Windows.Forms.ToolStripMenuItem();
         this.menuMain.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuMain
         // 
         this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmWnd});
         this.menuMain.Location = new System.Drawing.Point(0, 0);
         this.menuMain.MdiWindowListItem = this.tsmWnd;
         this.menuMain.Name = "menuMain";
         this.menuMain.Size = new System.Drawing.Size(298, 36);
         this.menuMain.TabIndex = 1;
         this.menuMain.Text = "menuStrip1";
         // 
         // tsmFile
         // 
         this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewFile,
            this.tsmClose});
         this.tsmFile.Name = "tsmFile";
         this.tsmFile.Size = new System.Drawing.Size(94, 32);
         this.tsmFile.Text = "檔案(&F)";
         // 
         // tsmWnd
         // 
         this.tsmWnd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArrange});
         this.tsmWnd.Name = "tsmWnd";
         this.tsmWnd.Size = new System.Drawing.Size(104, 32);
         this.tsmWnd.Text = "視窗(&W)";
         // 
         // tsmNewFile
         // 
         this.tsmNewFile.Name = "tsmNewFile";
         this.tsmNewFile.Size = new System.Drawing.Size(252, 32);
         this.tsmNewFile.Text = "開新檔案";
         this.tsmNewFile.Click += new System.EventHandler(this.tsmNewFile_Click);
         // 
         // tsmClose
         // 
         this.tsmClose.Name = "tsmClose";
         this.tsmClose.Size = new System.Drawing.Size(252, 32);
         this.tsmClose.Text = "結束";
         this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
         // 
         // tsmArrange
         // 
         this.tsmArrange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHorizon,
            this.tsmVertical,
            this.tsmCascade});
         this.tsmArrange.Name = "tsmArrange";
         this.tsmArrange.Size = new System.Drawing.Size(252, 32);
         this.tsmArrange.Text = "視窗排列";
         // 
         // tsmHorizon
         // 
         this.tsmHorizon.CheckOnClick = true;
         this.tsmHorizon.Name = "tsmHorizon";
         this.tsmHorizon.Size = new System.Drawing.Size(252, 32);
         this.tsmHorizon.Text = "水平";
         this.tsmHorizon.Click += new System.EventHandler(this.tsmHorizon_Click);
         // 
         // tsmVertical
         // 
         this.tsmVertical.CheckOnClick = true;
         this.tsmVertical.Name = "tsmVertical";
         this.tsmVertical.Size = new System.Drawing.Size(252, 32);
         this.tsmVertical.Text = "垂直";
         this.tsmVertical.Click += new System.EventHandler(this.tsmVertical_Click);
         // 
         // tsmCascade
         // 
         this.tsmCascade.CheckOnClick = true;
         this.tsmCascade.Name = "tsmCascade";
         this.tsmCascade.Size = new System.Drawing.Size(252, 32);
         this.tsmCascade.Text = "重疊";
         this.tsmCascade.Click += new System.EventHandler(this.tsmCascade_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 198);
         this.Controls.Add(this.menuMain);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuMain;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1401";
         this.menuMain.ResumeLayout(false);
         this.menuMain.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuMain;
      private System.Windows.Forms.ToolStripMenuItem tsmFile;
      private System.Windows.Forms.ToolStripMenuItem tsmNewFile;
      private System.Windows.Forms.ToolStripMenuItem tsmClose;
      private System.Windows.Forms.ToolStripMenuItem tsmWnd;
      private System.Windows.Forms.ToolStripMenuItem tsmArrange;
      private System.Windows.Forms.ToolStripMenuItem tsmHorizon;
      private System.Windows.Forms.ToolStripMenuItem tsmVertical;
      private System.Windows.Forms.ToolStripMenuItem tsmCascade;
   }
}

