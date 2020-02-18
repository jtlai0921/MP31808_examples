namespace Ex1306
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
         this.ctmQuickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.ctmQuickFile = new System.Windows.Forms.ToolStripMenuItem();
         this.ctmQuickFont = new System.Windows.Forms.ToolStripMenuItem();
         this.ctmQuickBold = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.menuBoldFont = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFontStyle = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFontTp = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
         this.menuSelectFont = new System.Windows.Forms.ToolStripMenuItem();
         this.menuEnd = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.menuSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.toolFamily = new System.Windows.Forms.ToolStrip();
         this.toolOpen = new System.Windows.Forms.ToolStripButton();
         this.toolSave = new System.Windows.Forms.ToolStripButton();
         this.rtxtShow = new System.Windows.Forms.RichTextBox();
         this.statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
         this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
         this.statusInform = new System.Windows.Forms.StatusStrip();
         this.ctmQuickMenu.SuspendLayout();
         this.mainMenu.SuspendLayout();
         this.toolFamily.SuspendLayout();
         this.statusInform.SuspendLayout();
         this.SuspendLayout();
         // 
         // ctmQuickMenu
         // 
         this.ctmQuickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.ctmQuickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmQuickFile,
            this.ctmQuickFont,
            this.ctmQuickBold});
         this.ctmQuickMenu.Name = "ctmQuickMenu";
         this.ctmQuickMenu.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
         this.ctmQuickMenu.Size = new System.Drawing.Size(239, 100);
         this.ctmQuickMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctmQuickMenu_ItemClicked);
         // 
         // ctmQuickFile
         // 
         this.ctmQuickFile.Name = "ctmQuickFile";
         this.ctmQuickFile.Size = new System.Drawing.Size(238, 32);
         this.ctmQuickFile.Text = "開啟舊檔";
         // 
         // ctmQuickFont
         // 
         this.ctmQuickFont.Name = "ctmQuickFont";
         this.ctmQuickFont.Size = new System.Drawing.Size(238, 32);
         this.ctmQuickFont.Text = "標楷體字型";
         // 
         // ctmQuickBold
         // 
         this.ctmQuickBold.Name = "ctmQuickBold";
         this.ctmQuickBold.Size = new System.Drawing.Size(238, 32);
         this.ctmQuickBold.Text = "字型樣式為粗體";
         // 
         // dlgOpenFile
         // 
         this.dlgOpenFile.FileName = "dlgOpenFile";
         // 
         // menuBoldFont
         // 
         this.menuBoldFont.Name = "menuBoldFont";
         this.menuBoldFont.Size = new System.Drawing.Size(140, 32);
         this.menuBoldFont.Text = "粗體";
         this.menuBoldFont.CheckedChanged += new System.EventHandler(this.menuBoldFont_CheckedChanged);
         // 
         // menuFontStyle
         // 
         this.menuFontStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBoldFont});
         this.menuFontStyle.Name = "menuFontStyle";
         this.menuFontStyle.Size = new System.Drawing.Size(184, 32);
         this.menuFontStyle.Text = "字型樣式";
         // 
         // menuFontTp
         // 
         this.menuFontTp.Name = "menuFontTp";
         this.menuFontTp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
         this.menuFontTp.Size = new System.Drawing.Size(262, 32);
         this.menuFontTp.Text = "標楷體";
         this.menuFontTp.CheckedChanged += new System.EventHandler(this.menuFontTp_CheckedChanged);
         // 
         // menuFont
         // 
         this.menuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectFont,
            this.menuFontStyle});
         this.menuFont.Name = "menuFont";
         this.menuFont.Size = new System.Drawing.Size(94, 32);
         this.menuFont.Text = "字型(&T)";
         // 
         // menuSelectFont
         // 
         this.menuSelectFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFontTp});
         this.menuSelectFont.Name = "menuSelectFont";
         this.menuSelectFont.Size = new System.Drawing.Size(184, 32);
         this.menuSelectFont.Text = "選擇字型";
         // 
         // menuEnd
         // 
         this.menuEnd.Name = "menuEnd";
         this.menuEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.menuEnd.Size = new System.Drawing.Size(267, 32);
         this.menuEnd.Text = "結束";
         this.menuEnd.Click += new System.EventHandler(this.menuEnd_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
         // 
         // menuSaveAsFile
         // 
         this.menuSaveAsFile.Name = "menuSaveAsFile";
         this.menuSaveAsFile.ShortcutKeys = System.Windows.Forms.Keys.F2;
         this.menuSaveAsFile.Size = new System.Drawing.Size(221, 32);
         this.menuSaveAsFile.Text = "另存新檔";
         this.menuSaveAsFile.Click += new System.EventHandler(this.menuSaveAsFile_Click);
         // 
         // menuSaveFile
         // 
         this.menuSaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveAsFile});
         this.menuSaveFile.Name = "menuSaveFile";
         this.menuSaveFile.ShortcutKeys = System.Windows.Forms.Keys.F4;
         this.menuSaveFile.Size = new System.Drawing.Size(267, 32);
         this.menuSaveFile.Text = "儲存檔案";
         // 
         // menuOpenFile
         // 
         this.menuOpenFile.Name = "menuOpenFile";
         this.menuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
         this.menuOpenFile.Size = new System.Drawing.Size(267, 32);
         this.menuOpenFile.Text = "開啟檔案";
         this.menuOpenFile.ToolTipText = "開啟文字檔案";
         this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
         // 
         // menuFile
         // 
         this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFile,
            this.menuSaveFile,
            this.toolStripMenuItem1,
            this.menuEnd});
         this.menuFile.Name = "menuFile";
         this.menuFile.Size = new System.Drawing.Size(94, 32);
         this.menuFile.Text = "檔案(&F)";
         // 
         // mainMenu
         // 
         this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuFont});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Size = new System.Drawing.Size(491, 36);
         this.mainMenu.TabIndex = 3;
         this.mainMenu.Text = "menuStrip1";
         // 
         // toolFamily
         // 
         this.toolFamily.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.toolFamily.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpen,
            this.toolSave});
         this.toolFamily.Location = new System.Drawing.Point(0, 36);
         this.toolFamily.Name = "toolFamily";
         this.toolFamily.Size = new System.Drawing.Size(491, 31);
         this.toolFamily.TabIndex = 5;
         this.toolFamily.Text = "toolStrip1";
         // 
         // toolOpen
         // 
         this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolOpen.Image = global::Ex1306.Properties.Resources.Open;
         this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolOpen.Name = "toolOpen";
         this.toolOpen.Size = new System.Drawing.Size(28, 28);
         this.toolOpen.Text = "開啟舊檔";
         this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
         // 
         // toolSave
         // 
         this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolSave.Image = global::Ex1306.Properties.Resources.Save;
         this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolSave.Name = "toolSave";
         this.toolSave.Size = new System.Drawing.Size(28, 28);
         this.toolSave.Text = "儲存檔案";
         this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
         // 
         // rtxtShow
         // 
         this.rtxtShow.ContextMenuStrip = this.ctmQuickMenu;
         this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Fill;
         this.rtxtShow.Location = new System.Drawing.Point(0, 36);
         this.rtxtShow.Name = "rtxtShow";
         this.rtxtShow.Size = new System.Drawing.Size(491, 206);
         this.rtxtShow.TabIndex = 4;
         this.rtxtShow.Text = "";
         // 
         // statusMsg
         // 
         this.statusMsg.Name = "statusMsg";
         this.statusMsg.Size = new System.Drawing.Size(100, 28);
         this.statusMsg.Text = "訊息提示";
         // 
         // statusTime
         // 
         this.statusTime.Name = "statusTime";
         this.statusTime.Size = new System.Drawing.Size(100, 28);
         this.statusTime.Text = "顯示時間";
         // 
         // statusInform
         // 
         this.statusInform.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.statusInform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMsg,
            this.statusTime});
         this.statusInform.Location = new System.Drawing.Point(0, 209);
         this.statusInform.Name = "statusInform";
         this.statusInform.Size = new System.Drawing.Size(491, 33);
         this.statusInform.TabIndex = 6;
         this.statusInform.Text = "statusStrip1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(491, 242);
         this.Controls.Add(this.statusInform);
         this.Controls.Add(this.toolFamily);
         this.Controls.Add(this.rtxtShow);
         this.Controls.Add(this.mainMenu);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1306";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ctmQuickMenu.ResumeLayout(false);
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.toolFamily.ResumeLayout(false);
         this.toolFamily.PerformLayout();
         this.statusInform.ResumeLayout(false);
         this.statusInform.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ContextMenuStrip ctmQuickMenu;
      private System.Windows.Forms.SaveFileDialog dlgSaveFile;
      private System.Windows.Forms.OpenFileDialog dlgOpenFile;
      private System.Windows.Forms.ToolStripMenuItem menuBoldFont;
      private System.Windows.Forms.ToolStripMenuItem menuFontStyle;
      private System.Windows.Forms.ToolStripMenuItem menuFontTp;
      private System.Windows.Forms.ToolStripMenuItem menuFont;
      private System.Windows.Forms.ToolStripMenuItem menuSelectFont;
      private System.Windows.Forms.ToolStripMenuItem menuEnd;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem menuSaveAsFile;
      private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
      private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
      private System.Windows.Forms.ToolStripMenuItem menuFile;
      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem ctmQuickFile;
      private System.Windows.Forms.ToolStripMenuItem ctmQuickFont;
      private System.Windows.Forms.ToolStripMenuItem ctmQuickBold;
      private System.Windows.Forms.ToolStrip toolFamily;
      private System.Windows.Forms.ToolStripButton toolOpen;
      private System.Windows.Forms.ToolStripButton toolSave;
      private System.Windows.Forms.RichTextBox rtxtShow;
      private System.Windows.Forms.ToolStripStatusLabel statusMsg;
      private System.Windows.Forms.ToolStripStatusLabel statusTime;
      private System.Windows.Forms.StatusStrip statusInform;
   }
}

