namespace Ex1601
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.schoolDataSet = new Ex1601.SchoolDataSet();
         this.教師BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.教師TableAdapter = new Ex1601.SchoolDataSetTableAdapters.教師TableAdapter();
         this.tableAdapterManager = new Ex1601.SchoolDataSetTableAdapters.TableAdapterManager();
         this.教師BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.教師BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.教師DataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.stbtnSubjectDetail = new System.Windows.Forms.ToolStripButton();
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.教師BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.教師BindingNavigator)).BeginInit();
         this.教師BindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.教師DataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // schoolDataSet
         // 
         this.schoolDataSet.DataSetName = "SchoolDataSet";
         this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // 教師BindingSource
         // 
         this.教師BindingSource.DataMember = "教師";
         this.教師BindingSource.DataSource = this.schoolDataSet;
         // 
         // 教師TableAdapter
         // 
         this.教師TableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.UpdateOrder = Ex1601.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.學生TableAdapter = null;
         this.tableAdapterManager.教師TableAdapter = this.教師TableAdapter;
         this.tableAdapterManager.系所TableAdapter = null;
         this.tableAdapterManager.課程TableAdapter = null;
         this.tableAdapterManager.選課單TableAdapter = null;
         // 
         // 教師BindingNavigator
         // 
         this.教師BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.教師BindingNavigator.BindingSource = this.教師BindingSource;
         this.教師BindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.教師BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.教師BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.教師BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.教師BindingNavigatorSaveItem,
            this.stbtnSubjectDetail});
         this.教師BindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.教師BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.教師BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.教師BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.教師BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.教師BindingNavigator.Name = "教師BindingNavigator";
         this.教師BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.教師BindingNavigator.Size = new System.Drawing.Size(458, 35);
         this.教師BindingNavigator.TabIndex = 0;
         this.教師BindingNavigator.Text = "bindingNavigator1";
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
         // 教師BindingNavigatorSaveItem
         // 
         this.教師BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.教師BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("教師BindingNavigatorSaveItem.Image")));
         this.教師BindingNavigatorSaveItem.Name = "教師BindingNavigatorSaveItem";
         this.教師BindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 32);
         this.教師BindingNavigatorSaveItem.Text = "儲存資料";
         this.教師BindingNavigatorSaveItem.Click += new System.EventHandler(this.教師BindingNavigatorSaveItem_Click);
         // 
         // 教師DataGridView
         // 
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.教師DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.教師DataGridView.AutoGenerateColumns = false;
         this.教師DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.教師DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
         this.教師DataGridView.DataSource = this.教師BindingSource;
         this.教師DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.教師DataGridView.Location = new System.Drawing.Point(0, 35);
         this.教師DataGridView.Name = "教師DataGridView";
         this.教師DataGridView.RowTemplate.Height = 31;
         this.教師DataGridView.Size = new System.Drawing.Size(458, 142);
         this.教師DataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "教師编號";
         this.dataGridViewTextBoxColumn1.HeaderText = "教師编號";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
         this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "學歷";
         this.dataGridViewTextBoxColumn3.HeaderText = "學歷";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "職稱";
         this.dataGridViewTextBoxColumn4.HeaderText = "職稱";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "專長";
         this.dataGridViewTextBoxColumn5.HeaderText = "專長";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         // 
         // stbtnSubjectDetail
         // 
         this.stbtnSubjectDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.stbtnSubjectDetail.Image = global::Ex1601.Properties.Resources.Course01;
         this.stbtnSubjectDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.stbtnSubjectDetail.Name = "stbtnSubjectDetail";
         this.stbtnSubjectDetail.Size = new System.Drawing.Size(28, 32);
         this.stbtnSubjectDetail.Text = "單筆編輯課程";
         this.stbtnSubjectDetail.Click += new System.EventHandler(this.stbtnSubjectDetail_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(458, 177);
         this.Controls.Add(this.教師DataGridView);
         this.Controls.Add(this.教師BindingNavigator);
         this.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Ex1601";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.教師BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.教師BindingNavigator)).EndInit();
         this.教師BindingNavigator.ResumeLayout(false);
         this.教師BindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.教師DataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private SchoolDataSet schoolDataSet;
      private System.Windows.Forms.BindingSource 教師BindingSource;
      private SchoolDataSetTableAdapters.教師TableAdapter 教師TableAdapter;
      private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator 教師BindingNavigator;
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
      private System.Windows.Forms.ToolStripButton 教師BindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView 教師DataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.ToolStripButton stbtnSubjectDetail;
   }
}

