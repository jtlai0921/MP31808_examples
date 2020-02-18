namespace Ex1602
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         System.Windows.Forms.Label 學號Label;
         System.Windows.Forms.Label 姓名Label;
         System.Windows.Forms.Label 系所Label;
         System.Windows.Forms.Label 性別Label;
         System.Windows.Forms.Label 生日Label;
         System.Windows.Forms.Label 電話Label;
         System.Windows.Forms.Label emailLabel;
         System.Windows.Forms.Label 住址Label;
         this.學生BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.學生BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.學號TextBox = new System.Windows.Forms.TextBox();
         this.姓名TextBox = new System.Windows.Forms.TextBox();
         this.系所TextBox = new System.Windows.Forms.TextBox();
         this.性別TextBox = new System.Windows.Forms.TextBox();
         this.生日DateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.電話TextBox = new System.Windows.Forms.TextBox();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.住址TextBox = new System.Windows.Forms.TextBox();
         this.sortBirthToolStrip = new System.Windows.Forms.ToolStrip();
         this.sortBirthToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.學生BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.schoolDataSet = new Ex1602.SchoolDataSet();
         this.學生TableAdapter = new Ex1602.SchoolDataSetTableAdapters.學生TableAdapter();
         this.tableAdapterManager = new Ex1602.SchoolDataSetTableAdapters.TableAdapterManager();
         學號Label = new System.Windows.Forms.Label();
         姓名Label = new System.Windows.Forms.Label();
         系所Label = new System.Windows.Forms.Label();
         性別Label = new System.Windows.Forms.Label();
         生日Label = new System.Windows.Forms.Label();
         電話Label = new System.Windows.Forms.Label();
         emailLabel = new System.Windows.Forms.Label();
         住址Label = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.學生BindingNavigator)).BeginInit();
         this.學生BindingNavigator.SuspendLayout();
         this.sortBirthToolStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
         this.SuspendLayout();
         // 
         // 學生BindingNavigator
         // 
         this.學生BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.學生BindingNavigator.BindingSource = this.學生BindingSource;
         this.學生BindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.學生BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.學生BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.學生BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.學生BindingNavigatorSaveItem});
         this.學生BindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.學生BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.學生BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.學生BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.學生BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.學生BindingNavigator.Name = "學生BindingNavigator";
         this.學生BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.學生BindingNavigator.Size = new System.Drawing.Size(329, 35);
         this.學生BindingNavigator.TabIndex = 0;
         this.學生BindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "位置";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 32);
         this.bindingNavigatorCountItem.Text = "/{0}";
         this.bindingNavigatorCountItem.ToolTipText = "項目總數";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorMoveNextItem.Text = "移到下一個";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorMoveLastItem.Text = "移到最後面";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorAddNewItem.Text = "加入新的";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 32);
         this.bindingNavigatorDeleteItem.Text = "刪除";
         // 
         // 學生BindingNavigatorSaveItem
         // 
         this.學生BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.學生BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("學生BindingNavigatorSaveItem.Image")));
         this.學生BindingNavigatorSaveItem.Name = "學生BindingNavigatorSaveItem";
         this.學生BindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 32);
         this.學生BindingNavigatorSaveItem.Text = "儲存資料";
         this.學生BindingNavigatorSaveItem.Click += new System.EventHandler(this.學生BindingNavigatorSaveItem_Click);
         // 
         // 學號Label
         // 
         學號Label.AutoSize = true;
         學號Label.Location = new System.Drawing.Point(13, 41);
         學號Label.Name = "學號Label";
         學號Label.Size = new System.Drawing.Size(61, 28);
         學號Label.TabIndex = 1;
         學號Label.Text = "學號:";
         // 
         // 學號TextBox
         // 
         this.學號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "學號", true));
         this.學號TextBox.Location = new System.Drawing.Point(82, 38);
         this.學號TextBox.Name = "學號TextBox";
         this.學號TextBox.Size = new System.Drawing.Size(200, 37);
         this.學號TextBox.TabIndex = 2;
         // 
         // 姓名Label
         // 
         姓名Label.AutoSize = true;
         姓名Label.Location = new System.Drawing.Point(13, 80);
         姓名Label.Name = "姓名Label";
         姓名Label.Size = new System.Drawing.Size(61, 28);
         姓名Label.TabIndex = 3;
         姓名Label.Text = "姓名:";
         // 
         // 姓名TextBox
         // 
         this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "姓名", true));
         this.姓名TextBox.Location = new System.Drawing.Point(82, 77);
         this.姓名TextBox.Name = "姓名TextBox";
         this.姓名TextBox.Size = new System.Drawing.Size(200, 37);
         this.姓名TextBox.TabIndex = 4;
         // 
         // 系所Label
         // 
         系所Label.AutoSize = true;
         系所Label.Location = new System.Drawing.Point(13, 119);
         系所Label.Name = "系所Label";
         系所Label.Size = new System.Drawing.Size(61, 28);
         系所Label.TabIndex = 5;
         系所Label.Text = "系所:";
         // 
         // 系所TextBox
         // 
         this.系所TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "系所", true));
         this.系所TextBox.Location = new System.Drawing.Point(82, 116);
         this.系所TextBox.Name = "系所TextBox";
         this.系所TextBox.Size = new System.Drawing.Size(200, 37);
         this.系所TextBox.TabIndex = 6;
         // 
         // 性別Label
         // 
         性別Label.AutoSize = true;
         性別Label.Location = new System.Drawing.Point(13, 158);
         性別Label.Name = "性別Label";
         性別Label.Size = new System.Drawing.Size(61, 28);
         性別Label.TabIndex = 7;
         性別Label.Text = "性別:";
         // 
         // 性別TextBox
         // 
         this.性別TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "性別", true));
         this.性別TextBox.Location = new System.Drawing.Point(82, 155);
         this.性別TextBox.Name = "性別TextBox";
         this.性別TextBox.Size = new System.Drawing.Size(200, 37);
         this.性別TextBox.TabIndex = 8;
         // 
         // 生日Label
         // 
         生日Label.AutoSize = true;
         生日Label.Location = new System.Drawing.Point(13, 197);
         生日Label.Name = "生日Label";
         生日Label.Size = new System.Drawing.Size(61, 28);
         生日Label.TabIndex = 9;
         生日Label.Text = "生日:";
         // 
         // 生日DateTimePicker
         // 
         this.生日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.學生BindingSource, "生日", true));
         this.生日DateTimePicker.Location = new System.Drawing.Point(82, 194);
         this.生日DateTimePicker.Name = "生日DateTimePicker";
         this.生日DateTimePicker.Size = new System.Drawing.Size(200, 37);
         this.生日DateTimePicker.TabIndex = 10;
         // 
         // 電話Label
         // 
         電話Label.AutoSize = true;
         電話Label.Location = new System.Drawing.Point(13, 236);
         電話Label.Name = "電話Label";
         電話Label.Size = new System.Drawing.Size(61, 28);
         電話Label.TabIndex = 11;
         電話Label.Text = "電話:";
         // 
         // 電話TextBox
         // 
         this.電話TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "電話", true));
         this.電話TextBox.Location = new System.Drawing.Point(82, 233);
         this.電話TextBox.Name = "電話TextBox";
         this.電話TextBox.Size = new System.Drawing.Size(200, 37);
         this.電話TextBox.TabIndex = 12;
         // 
         // emailLabel
         // 
         emailLabel.AutoSize = true;
         emailLabel.Location = new System.Drawing.Point(13, 275);
         emailLabel.Name = "emailLabel";
         emailLabel.Size = new System.Drawing.Size(73, 28);
         emailLabel.TabIndex = 13;
         emailLabel.Text = "Email:";
         // 
         // emailTextBox
         // 
         this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "Email", true));
         this.emailTextBox.Location = new System.Drawing.Point(82, 272);
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size(200, 37);
         this.emailTextBox.TabIndex = 14;
         // 
         // 住址Label
         // 
         住址Label.AutoSize = true;
         住址Label.Location = new System.Drawing.Point(13, 314);
         住址Label.Name = "住址Label";
         住址Label.Size = new System.Drawing.Size(61, 28);
         住址Label.TabIndex = 15;
         住址Label.Text = "住址:";
         // 
         // 住址TextBox
         // 
         this.住址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.學生BindingSource, "住址", true));
         this.住址TextBox.Location = new System.Drawing.Point(82, 311);
         this.住址TextBox.Name = "住址TextBox";
         this.住址TextBox.Size = new System.Drawing.Size(200, 37);
         this.住址TextBox.TabIndex = 16;
         // 
         // sortBirthToolStrip
         // 
         this.sortBirthToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.sortBirthToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortBirthToolStripButton});
         this.sortBirthToolStrip.Location = new System.Drawing.Point(0, 35);
         this.sortBirthToolStrip.Name = "sortBirthToolStrip";
         this.sortBirthToolStrip.Size = new System.Drawing.Size(329, 35);
         this.sortBirthToolStrip.TabIndex = 17;
         this.sortBirthToolStrip.Text = "sortBirthToolStrip";
         // 
         // sortBirthToolStripButton
         // 
         this.sortBirthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.sortBirthToolStripButton.Name = "sortBirthToolStripButton";
         this.sortBirthToolStripButton.Size = new System.Drawing.Size(126, 32);
         this.sortBirthToolStripButton.Text = "依生日排序";
         this.sortBirthToolStripButton.Click += new System.EventHandler(this.sortBirthToolStripButton_Click);
         // 
         // 學生BindingSource
         // 
         this.學生BindingSource.DataMember = "學生";
         this.學生BindingSource.DataSource = this.schoolDataSet;
         // 
         // schoolDataSet
         // 
         this.schoolDataSet.DataSetName = "SchoolDataSet";
         this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // 學生TableAdapter
         // 
         this.學生TableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.UpdateOrder = Ex1602.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.學生TableAdapter = this.學生TableAdapter;
         this.tableAdapterManager.教師TableAdapter = null;
         this.tableAdapterManager.系所TableAdapter = null;
         this.tableAdapterManager.課程TableAdapter = null;
         this.tableAdapterManager.選課單TableAdapter = null;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(329, 352);
         this.Controls.Add(this.sortBirthToolStrip);
         this.Controls.Add(學號Label);
         this.Controls.Add(this.學號TextBox);
         this.Controls.Add(姓名Label);
         this.Controls.Add(this.姓名TextBox);
         this.Controls.Add(系所Label);
         this.Controls.Add(this.系所TextBox);
         this.Controls.Add(性別Label);
         this.Controls.Add(this.性別TextBox);
         this.Controls.Add(生日Label);
         this.Controls.Add(this.生日DateTimePicker);
         this.Controls.Add(電話Label);
         this.Controls.Add(this.電話TextBox);
         this.Controls.Add(emailLabel);
         this.Controls.Add(this.emailTextBox);
         this.Controls.Add(住址Label);
         this.Controls.Add(this.住址TextBox);
         this.Controls.Add(this.學生BindingNavigator);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "學生資料表";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.學生BindingNavigator)).EndInit();
         this.學生BindingNavigator.ResumeLayout(false);
         this.學生BindingNavigator.PerformLayout();
         this.sortBirthToolStrip.ResumeLayout(false);
         this.sortBirthToolStrip.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private SchoolDataSet schoolDataSet;
      private System.Windows.Forms.BindingSource 學生BindingSource;
      private SchoolDataSetTableAdapters.學生TableAdapter 學生TableAdapter;
      private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator 學生BindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton 學生BindingNavigatorSaveItem;
      private System.Windows.Forms.TextBox 學號TextBox;
      private System.Windows.Forms.TextBox 姓名TextBox;
      private System.Windows.Forms.TextBox 系所TextBox;
      private System.Windows.Forms.TextBox 性別TextBox;
      private System.Windows.Forms.DateTimePicker 生日DateTimePicker;
      private System.Windows.Forms.TextBox 電話TextBox;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.TextBox 住址TextBox;
      private System.Windows.Forms.ToolStrip sortBirthToolStrip;
      private System.Windows.Forms.ToolStripButton sortBirthToolStripButton;
   }
}

