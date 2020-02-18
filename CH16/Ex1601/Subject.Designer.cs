namespace Ex1601
{
   partial class Subject
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
         System.Windows.Forms.Label 科目代碼Label;
         System.Windows.Forms.Label 科目名稱Label;
         System.Windows.Forms.Label 學分Label;
         System.Windows.Forms.Label 選必修Label;
         this.schoolDataSet = new Ex1601.SchoolDataSet();
         this.課程BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.課程TableAdapter = new Ex1601.SchoolDataSetTableAdapters.課程TableAdapter();
         this.tableAdapterManager = new Ex1601.SchoolDataSetTableAdapters.TableAdapterManager();
         this.課程BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.課程BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.科目代碼TextBox = new System.Windows.Forms.TextBox();
         this.科目名稱TextBox = new System.Windows.Forms.TextBox();
         this.學分TextBox = new System.Windows.Forms.TextBox();
         this.選必修CheckBox = new System.Windows.Forms.CheckBox();
         科目代碼Label = new System.Windows.Forms.Label();
         科目名稱Label = new System.Windows.Forms.Label();
         學分Label = new System.Windows.Forms.Label();
         選必修Label = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.課程BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.課程BindingNavigator)).BeginInit();
         this.課程BindingNavigator.SuspendLayout();
         this.SuspendLayout();
         // 
         // schoolDataSet
         // 
         this.schoolDataSet.DataSetName = "SchoolDataSet";
         this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // 課程BindingSource
         // 
         this.課程BindingSource.DataMember = "課程";
         this.課程BindingSource.DataSource = this.schoolDataSet;
         // 
         // 課程TableAdapter
         // 
         this.課程TableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.UpdateOrder = Ex1601.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.學生TableAdapter = null;
         this.tableAdapterManager.教師TableAdapter = null;
         this.tableAdapterManager.系所TableAdapter = null;
         this.tableAdapterManager.課程TableAdapter = this.課程TableAdapter;
         this.tableAdapterManager.選課單TableAdapter = null;
         // 
         // 課程BindingNavigator
         // 
         this.課程BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.課程BindingNavigator.BindingSource = this.課程BindingSource;
         this.課程BindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.課程BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.課程BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.課程BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.課程BindingNavigatorSaveItem});
         this.課程BindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.課程BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.課程BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.課程BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.課程BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.課程BindingNavigator.Name = "課程BindingNavigator";
         this.課程BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.課程BindingNavigator.Size = new System.Drawing.Size(345, 35);
         this.課程BindingNavigator.TabIndex = 0;
         this.課程BindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 22);
         this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 22);
         this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
         this.bindingNavigatorCountItem.Text = "/{0}";
         this.bindingNavigatorCountItem.ToolTipText = "項目總數";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
         this.bindingNavigatorMoveNextItem.Text = "移到下一個";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
         this.bindingNavigatorMoveLastItem.Text = "移到最後面";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
         this.bindingNavigatorDeleteItem.Text = "刪除";
         // 
         // 課程BindingNavigatorSaveItem
         // 
         this.課程BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.課程BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("課程BindingNavigatorSaveItem.Image")));
         this.課程BindingNavigatorSaveItem.Name = "課程BindingNavigatorSaveItem";
         this.課程BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
         this.課程BindingNavigatorSaveItem.Text = "儲存資料";
         this.課程BindingNavigatorSaveItem.Click += new System.EventHandler(this.課程BindingNavigatorSaveItem_Click);
         // 
         // 科目代碼Label
         // 
         科目代碼Label.AutoSize = true;
         科目代碼Label.Location = new System.Drawing.Point(12, 46);
         科目代碼Label.Name = "科目代碼Label";
         科目代碼Label.Size = new System.Drawing.Size(105, 28);
         科目代碼Label.TabIndex = 1;
         科目代碼Label.Text = "科目代碼:";
         // 
         // 科目代碼TextBox
         // 
         this.科目代碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.課程BindingSource, "科目代碼", true));
         this.科目代碼TextBox.Location = new System.Drawing.Point(123, 43);
         this.科目代碼TextBox.Name = "科目代碼TextBox";
         this.科目代碼TextBox.Size = new System.Drawing.Size(104, 37);
         this.科目代碼TextBox.TabIndex = 2;
         // 
         // 科目名稱Label
         // 
         科目名稱Label.AutoSize = true;
         科目名稱Label.Location = new System.Drawing.Point(12, 89);
         科目名稱Label.Name = "科目名稱Label";
         科目名稱Label.Size = new System.Drawing.Size(105, 28);
         科目名稱Label.TabIndex = 3;
         科目名稱Label.Text = "科目名稱:";
         // 
         // 科目名稱TextBox
         // 
         this.科目名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.課程BindingSource, "科目名稱", true));
         this.科目名稱TextBox.Location = new System.Drawing.Point(123, 86);
         this.科目名稱TextBox.Name = "科目名稱TextBox";
         this.科目名稱TextBox.Size = new System.Drawing.Size(104, 37);
         this.科目名稱TextBox.TabIndex = 4;
         // 
         // 學分Label
         // 
         學分Label.AutoSize = true;
         學分Label.Location = new System.Drawing.Point(12, 132);
         學分Label.Name = "學分Label";
         學分Label.Size = new System.Drawing.Size(61, 28);
         學分Label.TabIndex = 5;
         學分Label.Text = "學分:";
         // 
         // 學分TextBox
         // 
         this.學分TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.課程BindingSource, "學分", true));
         this.學分TextBox.Location = new System.Drawing.Point(123, 129);
         this.學分TextBox.Name = "學分TextBox";
         this.學分TextBox.Size = new System.Drawing.Size(104, 37);
         this.學分TextBox.TabIndex = 6;
         // 
         // 選必修Label
         // 
         選必修Label.AutoSize = true;
         選必修Label.Location = new System.Drawing.Point(12, 177);
         選必修Label.Name = "選必修Label";
         選必修Label.Size = new System.Drawing.Size(83, 28);
         選必修Label.TabIndex = 7;
         選必修Label.Text = "選必修:";
         // 
         // 選必修CheckBox
         // 
         this.選必修CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.課程BindingSource, "選必修", true));
         this.選必修CheckBox.Location = new System.Drawing.Point(123, 172);
         this.選必修CheckBox.Name = "選必修CheckBox";
         this.選必修CheckBox.Size = new System.Drawing.Size(104, 33);
         this.選必修CheckBox.TabIndex = 8;
         this.選必修CheckBox.Text = "checkBox1";
         this.選必修CheckBox.UseVisualStyleBackColor = true;
         // 
         // Student
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(345, 213);
         this.Controls.Add(科目代碼Label);
         this.Controls.Add(this.科目代碼TextBox);
         this.Controls.Add(科目名稱Label);
         this.Controls.Add(this.科目名稱TextBox);
         this.Controls.Add(學分Label);
         this.Controls.Add(this.學分TextBox);
         this.Controls.Add(選必修Label);
         this.Controls.Add(this.選必修CheckBox);
         this.Controls.Add(this.課程BindingNavigator);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Student";
         this.Text = "課程詳細資料";
         this.Load += new System.EventHandler(this.Student_Load);
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.課程BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.課程BindingNavigator)).EndInit();
         this.課程BindingNavigator.ResumeLayout(false);
         this.課程BindingNavigator.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private SchoolDataSet schoolDataSet;
      private System.Windows.Forms.BindingSource 課程BindingSource;
      private SchoolDataSetTableAdapters.課程TableAdapter 課程TableAdapter;
      private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator 課程BindingNavigator;
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
      private System.Windows.Forms.ToolStripButton 課程BindingNavigatorSaveItem;
      private System.Windows.Forms.TextBox 科目代碼TextBox;
      private System.Windows.Forms.TextBox 科目名稱TextBox;
      private System.Windows.Forms.TextBox 學分TextBox;
      private System.Windows.Forms.CheckBox 選必修CheckBox;
   }
}