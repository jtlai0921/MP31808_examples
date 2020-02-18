namespace Ex1103
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
         this.btnExit = new System.Windows.Forms.Button();
         this.btnClear = new System.Windows.Forms.Button();
         this.txtBuffer = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.btnPaste = new System.Windows.Forms.Button();
         this.btnCut = new System.Windows.Forms.Button();
         this.btnCopy = new System.Windows.Forms.Button();
         this.btnUndo = new System.Windows.Forms.Button();
         this.txtNote = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(235, 193);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(90, 35);
         this.btnExit.TabIndex = 19;
         this.btnExit.Text = "離開";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(12, 193);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(90, 35);
         this.btnClear.TabIndex = 18;
         this.btnClear.Text = "清除";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // txtBuffer
         // 
         this.txtBuffer.BackColor = System.Drawing.Color.PaleGreen;
         this.txtBuffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBuffer.Location = new System.Drawing.Point(110, 151);
         this.txtBuffer.Name = "txtBuffer";
         this.txtBuffer.ReadOnly = true;
         this.txtBuffer.Size = new System.Drawing.Size(215, 37);
         this.txtBuffer.TabIndex = 17;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 153);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 28);
         this.label2.TabIndex = 16;
         this.label2.Text = "緩衝區：";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 54);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(144, 28);
         this.label1.TabIndex = 15;
         this.label1.Text = "文字編輯區：";
         // 
         // btnPaste
         // 
         this.btnPaste.Location = new System.Drawing.Point(255, 9);
         this.btnPaste.Name = "btnPaste";
         this.btnPaste.Size = new System.Drawing.Size(75, 35);
         this.btnPaste.TabIndex = 14;
         this.btnPaste.Text = "貼上";
         this.btnPaste.UseVisualStyleBackColor = true;
         this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
         // 
         // btnCut
         // 
         this.btnCut.Location = new System.Drawing.Point(174, 9);
         this.btnCut.Name = "btnCut";
         this.btnCut.Size = new System.Drawing.Size(75, 35);
         this.btnCut.TabIndex = 13;
         this.btnCut.Text = "剪下";
         this.btnCut.UseVisualStyleBackColor = true;
         this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
         // 
         // btnCopy
         // 
         this.btnCopy.Location = new System.Drawing.Point(93, 9);
         this.btnCopy.Name = "btnCopy";
         this.btnCopy.Size = new System.Drawing.Size(75, 35);
         this.btnCopy.TabIndex = 12;
         this.btnCopy.Text = "複製";
         this.btnCopy.UseVisualStyleBackColor = true;
         this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
         // 
         // btnUndo
         // 
         this.btnUndo.Location = new System.Drawing.Point(6, 9);
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.Size = new System.Drawing.Size(75, 35);
         this.btnUndo.TabIndex = 11;
         this.btnUndo.Text = "復原";
         this.btnUndo.UseVisualStyleBackColor = true;
         this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
         // 
         // txtNote
         // 
         this.txtNote.Location = new System.Drawing.Point(102, 52);
         this.txtNote.Multiline = true;
         this.txtNote.Name = "txtNote";
         this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtNote.Size = new System.Drawing.Size(225, 91);
         this.txtNote.TabIndex = 10;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(337, 231);
         this.Controls.Add(this.txtNote);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.txtBuffer);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnPaste);
         this.Controls.Add(this.btnCut);
         this.Controls.Add(this.btnCopy);
         this.Controls.Add(this.btnUndo);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1103";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.TextBox txtBuffer;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnPaste;
      private System.Windows.Forms.Button btnCut;
      private System.Windows.Forms.Button btnCopy;
      private System.Windows.Forms.Button btnUndo;
      private System.Windows.Forms.TextBox txtNote;
   }
}

