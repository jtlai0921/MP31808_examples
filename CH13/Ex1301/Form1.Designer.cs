namespace Ex1301
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.rabMale = new System.Windows.Forms.RadioButton();
         this.rabFemale = new System.Windows.Forms.RadioButton();
         this.btnConfirm = new System.Windows.Forms.Button();
         this.rtxtData = new System.Windows.Forms.RichTextBox();
         this.txtName = new System.Windows.Forms.TextBox();
         this.dtpBirth = new System.Windows.Forms.DateTimePicker();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.rabFemale);
         this.groupBox1.Controls.Add(this.rabMale);
         this.groupBox1.Location = new System.Drawing.Point(6, 43);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(178, 60);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "性別";
         // 
         // rabMale
         // 
         this.rabMale.AutoSize = true;
         this.rabMale.Location = new System.Drawing.Point(10, 24);
         this.rabMale.Name = "rabMale";
         this.rabMale.Size = new System.Drawing.Size(81, 32);
         this.rabMale.TabIndex = 0;
         this.rabMale.Text = "帥哥";
         this.rabMale.UseVisualStyleBackColor = true;
         this.rabMale.CheckedChanged += new System.EventHandler(this.rabMale_CheckedChanged);
         // 
         // rabFemale
         // 
         this.rabFemale.AutoSize = true;
         this.rabFemale.Location = new System.Drawing.Point(92, 24);
         this.rabFemale.Name = "rabFemale";
         this.rabFemale.Size = new System.Drawing.Size(81, 32);
         this.rabFemale.TabIndex = 1;
         this.rabFemale.Text = "美女";
         this.rabFemale.UseVisualStyleBackColor = true;
         // 
         // btnConfirm
         // 
         this.btnConfirm.Location = new System.Drawing.Point(6, 109);
         this.btnConfirm.Name = "btnConfirm";
         this.btnConfirm.Size = new System.Drawing.Size(81, 36);
         this.btnConfirm.TabIndex = 5;
         this.btnConfirm.Text = "確認";
         this.btnConfirm.UseVisualStyleBackColor = true;
         this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
         // 
         // rtxtData
         // 
         this.rtxtData.Location = new System.Drawing.Point(191, 47);
         this.rtxtData.Name = "rtxtData";
         this.rtxtData.Size = new System.Drawing.Size(225, 102);
         this.rtxtData.TabIndex = 6;
         this.rtxtData.Text = "";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(63, 4);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(100, 37);
         this.txtName.TabIndex = 1;
         // 
         // dtpBirth
         // 
         this.dtpBirth.Location = new System.Drawing.Point(245, 4);
         this.dtpBirth.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
         this.dtpBirth.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
         this.dtpBirth.Name = "dtpBirth";
         this.dtpBirth.ShowUpDown = true;
         this.dtpBirth.Size = new System.Drawing.Size(171, 37);
         this.dtpBirth.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(191, 8);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 28);
         this.label2.TabIndex = 2;
         this.label2.Text = "生日：";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(7, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 28);
         this.label1.TabIndex = 0;
         this.label1.Text = "名稱：";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(421, 151);
         this.Controls.Add(this.btnConfirm);
         this.Controls.Add(this.rtxtData);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.dtpBirth);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.groupBox1);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1301";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton rabFemale;
      private System.Windows.Forms.RadioButton rabMale;
      private System.Windows.Forms.Button btnConfirm;
      private System.Windows.Forms.RichTextBox rtxtData;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.DateTimePicker dtpBirth;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}

