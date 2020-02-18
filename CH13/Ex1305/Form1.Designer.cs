namespace Ex1305
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
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.menuEnd = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
         this.menuSelectFont = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFontTp = new System.Windows.Forms.ToolStripMenuItem();
         this.menuFontStyle = new System.Windows.Forms.ToolStripMenuItem();
         this.menuBoldFont = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.dlgFont = new System.Windows.Forms.FontDialog();
         this.dlgColor = new System.Windows.Forms.ColorDialog();         
         this.rtxtShow = new System.Windows.Forms.RichTextBox();
         this.mainMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainMenu
         // 
         this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuFont});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Size = new System.Drawing.Size(317, 36);
         this.mainMenu.TabIndex = 0;
         this.mainMenu.Text = "menuStrip1";
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
         // menuOpenFile
         // 
         this.menuOpenFile.Name = "menuOpenFile";
         this.menuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
         this.menuOpenFile.Size = new System.Drawing.Size(267, 32);
         this.menuOpenFile.Text = "開啟檔案";
         this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
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
         // menuSaveAsFile
         // 
         this.menuSaveAsFile.Name = "menuSaveAsFile";
         this.menuSaveAsFile.ShortcutKeys = System.Windows.Forms.Keys.F2;
         this.menuSaveAsFile.Size = new System.Drawing.Size(252, 32);
         this.menuSaveAsFile.Text = "另存新檔";
         this.menuSaveAsFile.Click += new System.EventHandler(this.menuSaveAsFile_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
         // 
         // menuEnd
         // 
         this.menuEnd.Name = "menuEnd";
         this.menuEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.menuEnd.Size = new System.Drawing.Size(267, 32);
         this.menuEnd.Text = "結束";
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
         // menuFontTp
         // 
         this.menuFontTp.Name = "menuFontTp";
         this.menuFontTp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
         this.menuFontTp.Size = new System.Drawing.Size(262, 32);
         this.menuFontTp.Text = "標楷體";
         this.menuFontTp.CheckedChanged += new System.EventHandler(this.menuFontTp_CheckedChanged);
         // 
         // menuFontStyle
         // 
         this.menuFontStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBoldFont});
         this.menuFontStyle.Name = "menuFontStyle";
         this.menuFontStyle.Size = new System.Drawing.Size(184, 32);
         this.menuFontStyle.Text = "字型樣式";
         // 
         // menuBoldFont
         // 
         this.menuBoldFont.Name = "menuBoldFont";
         this.menuBoldFont.Size = new System.Drawing.Size(140, 32);
         this.menuBoldFont.Text = "粗體";
         this.menuBoldFont.CheckedChanged += new System.EventHandler(this.menuBoldFont_CheckedChanged);
         // 
         // dlgOpenFile
         // 
         this.dlgOpenFile.FileName = "dlgOpenFile";
         // 
         // rtxtShow
         // 
         this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Fill;
         this.rtxtShow.Location = new System.Drawing.Point(0, 36);
         this.rtxtShow.Name = "rtxtShow";
         this.rtxtShow.Size = new System.Drawing.Size(317, 127);
         this.rtxtShow.TabIndex = 2;
         this.rtxtShow.Text = "";
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(317, 163);
         this.Controls.Add(this.rtxtShow);
         this.Controls.Add(this.mainMenu);
         this.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.MainMenuStrip = this.mainMenu;
         this.Name = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem menuFile;
      private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
      private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
      private System.Windows.Forms.ToolStripMenuItem menuSaveAsFile;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem menuFont;
      private System.Windows.Forms.ToolStripMenuItem menuEnd;
      private System.Windows.Forms.ToolStripMenuItem menuSelectFont;
      private System.Windows.Forms.ToolStripMenuItem menuFontStyle;
      private System.Windows.Forms.ToolStripMenuItem menuFontTp;
      private System.Windows.Forms.ToolStripMenuItem menuBoldFont;
      private System.Windows.Forms.OpenFileDialog dlgOpenFile;
      private System.Windows.Forms.SaveFileDialog dlgSaveFile;
      private System.Windows.Forms.FontDialog dlgFont;
      private System.Windows.Forms.ColorDialog dlgColor;      
      private System.Windows.Forms.RichTextBox rtxtShow;
   }
}

