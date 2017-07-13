namespace WindowsFormsApplication便當訂購系統
{
    partial class Form店家資料
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form店家資料));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb連絡電話 = new System.Windows.Forms.TextBox();
            this.tb店家地址 = new System.Windows.Forms.TextBox();
            this.tb店家評價 = new System.Windows.Forms.TextBox();
            this.btn刪除店家 = new System.Windows.Forms.Button();
            this.cobox店家代號 = new System.Windows.Forms.GroupBox();
            this.lb店家清單 = new System.Windows.Forms.ListBox();
            this.cobox店家編號 = new System.Windows.Forms.ComboBox();
            this.cobox店家名字 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb商品清單 = new System.Windows.Forms.ListBox();
            this.tb店家編號 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb商品代號 = new System.Windows.Forms.TextBox();
            this.tb商品單價 = new System.Windows.Forms.TextBox();
            this.tb商品名稱 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn新增產品 = new System.Windows.Forms.Button();
            this.btn刪除商品 = new System.Windows.Forms.Button();
            this.btn新增店家 = new System.Windows.Forms.Button();
            this.midedemoDataSet = new WindowsFormsApplication便當訂購系統.midedemoDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new WindowsFormsApplication便當訂購系統.midedemoDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication便當訂購系統.midedemoDataSetTableAdapters.TableAdapterManager();
            this.suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn回訂購頁 = new System.Windows.Forms.Button();
            this.btn店家資料筆數 = new System.Windows.Forms.Button();
            this.btn商品資料筆數 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn修改店家資訊 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn修改商品資訊 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cobox店家代號.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midedemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).BeginInit();
            this.suppliersBindingNavigator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "店家名稱";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "店家評價";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "店家地址";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "連絡電話";
            // 
            // tb連絡電話
            // 
            this.tb連絡電話.Location = new System.Drawing.Point(112, 107);
            this.tb連絡電話.Multiline = true;
            this.tb連絡電話.Name = "tb連絡電話";
            this.tb連絡電話.Size = new System.Drawing.Size(215, 36);
            this.tb連絡電話.TabIndex = 6;
            // 
            // tb店家地址
            // 
            this.tb店家地址.Location = new System.Drawing.Point(112, 164);
            this.tb店家地址.Multiline = true;
            this.tb店家地址.Name = "tb店家地址";
            this.tb店家地址.Size = new System.Drawing.Size(306, 36);
            this.tb店家地址.TabIndex = 7;
            // 
            // tb店家評價
            // 
            this.tb店家評價.Location = new System.Drawing.Point(112, 229);
            this.tb店家評價.Multiline = true;
            this.tb店家評價.Name = "tb店家評價";
            this.tb店家評價.Size = new System.Drawing.Size(104, 36);
            this.tb店家評價.TabIndex = 8;
            // 
            // btn刪除店家
            // 
            this.btn刪除店家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn刪除店家.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除店家.Location = new System.Drawing.Point(165, 36);
            this.btn刪除店家.Name = "btn刪除店家";
            this.btn刪除店家.Size = new System.Drawing.Size(109, 69);
            this.btn刪除店家.TabIndex = 11;
            this.btn刪除店家.Text = "刪除店家";
            this.btn刪除店家.UseVisualStyleBackColor = false;
            this.btn刪除店家.Click += new System.EventHandler(this.btn刪除店家_Click);
            // 
            // cobox店家代號
            // 
            this.cobox店家代號.BackColor = System.Drawing.Color.Transparent;
            this.cobox店家代號.Controls.Add(this.label10);
            this.cobox店家代號.Controls.Add(this.lb店家清單);
            this.cobox店家代號.Controls.Add(this.cobox店家編號);
            this.cobox店家代號.Controls.Add(this.cobox店家名字);
            this.cobox店家代號.Controls.Add(this.label2);
            this.cobox店家代號.Controls.Add(this.label1);
            this.cobox店家代號.Controls.Add(this.label5);
            this.cobox店家代號.Controls.Add(this.tb連絡電話);
            this.cobox店家代號.Controls.Add(this.tb店家評價);
            this.cobox店家代號.Controls.Add(this.label4);
            this.cobox店家代號.Controls.Add(this.label3);
            this.cobox店家代號.Controls.Add(this.tb店家地址);
            this.cobox店家代號.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cobox店家代號.Location = new System.Drawing.Point(0, 35);
            this.cobox店家代號.Name = "cobox店家代號";
            this.cobox店家代號.Size = new System.Drawing.Size(636, 343);
            this.cobox店家代號.TabIndex = 13;
            this.cobox店家代號.TabStop = false;
            this.cobox店家代號.Text = "店家基本資料";
            // 
            // lb店家清單
            // 
            this.lb店家清單.FormattingEnabled = true;
            this.lb店家清單.ItemHeight = 26;
            this.lb店家清單.Location = new System.Drawing.Point(424, 13);
            this.lb店家清單.Name = "lb店家清單";
            this.lb店家清單.Size = new System.Drawing.Size(214, 342);
            this.lb店家清單.TabIndex = 17;
            this.lb店家清單.SelectedIndexChanged += new System.EventHandler(this.lb店家清單_SelectedIndexChanged);
            // 
            // cobox店家編號
            // 
            this.cobox店家編號.FormattingEnabled = true;
            this.cobox店家編號.Location = new System.Drawing.Point(109, 285);
            this.cobox店家編號.Name = "cobox店家編號";
            this.cobox店家編號.Size = new System.Drawing.Size(107, 34);
            this.cobox店家編號.TabIndex = 15;
            // 
            // cobox店家名字
            // 
            this.cobox店家名字.FormattingEnabled = true;
            this.cobox店家名字.Location = new System.Drawing.Point(112, 51);
            this.cobox店家名字.Name = "cobox店家名字";
            this.cobox店家名字.Size = new System.Drawing.Size(215, 34);
            this.cobox店家名字.TabIndex = 14;
            this.cobox店家名字.SelectedIndexChanged += new System.EventHandler(this.cobox店家名字_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "店家代號";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lb商品清單);
            this.groupBox2.Controls.Add(this.tb店家編號);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb商品代號);
            this.groupBox2.Controls.Add(this.tb商品單價);
            this.groupBox2.Controls.Add(this.tb商品名稱);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 338);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品資料";
            // 
            // lb商品清單
            // 
            this.lb商品清單.FormattingEnabled = true;
            this.lb商品清單.ItemHeight = 26;
            this.lb商品清單.Location = new System.Drawing.Point(422, 13);
            this.lb商品清單.Name = "lb商品清單";
            this.lb商品清單.Size = new System.Drawing.Size(214, 342);
            this.lb商品清單.TabIndex = 16;
            this.lb商品清單.SelectedIndexChanged += new System.EventHandler(this.lb商品清單_SelectedIndexChanged);
            // 
            // tb店家編號
            // 
            this.tb店家編號.Location = new System.Drawing.Point(112, 291);
            this.tb店家編號.Multiline = true;
            this.tb店家編號.Name = "tb店家編號";
            this.tb店家編號.Size = new System.Drawing.Size(104, 36);
            this.tb店家編號.TabIndex = 15;
            this.tb店家編號.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "店家代號";
            // 
            // tb商品代號
            // 
            this.tb商品代號.Location = new System.Drawing.Point(111, 223);
            this.tb商品代號.Multiline = true;
            this.tb商品代號.Name = "tb商品代號";
            this.tb商品代號.Size = new System.Drawing.Size(102, 36);
            this.tb商品代號.TabIndex = 13;
            this.tb商品代號.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb商品單價
            // 
            this.tb商品單價.Location = new System.Drawing.Point(111, 138);
            this.tb商品單價.Multiline = true;
            this.tb商品單價.Name = "tb商品單價";
            this.tb商品單價.Size = new System.Drawing.Size(102, 36);
            this.tb商品單價.TabIndex = 12;
            this.tb商品單價.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb商品名稱
            // 
            this.tb商品名稱.Location = new System.Drawing.Point(111, 57);
            this.tb商品名稱.Multiline = true;
            this.tb商品名稱.Name = "tb商品名稱";
            this.tb商品名稱.Size = new System.Drawing.Size(158, 36);
            this.tb商品名稱.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "商品單價";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "商品代號";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "商品名稱";
            // 
            // btn新增產品
            // 
            this.btn新增產品.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn新增產品.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增產品.Location = new System.Drawing.Point(16, 44);
            this.btn新增產品.Name = "btn新增產品";
            this.btn新增產品.Size = new System.Drawing.Size(109, 69);
            this.btn新增產品.TabIndex = 15;
            this.btn新增產品.Text = "新增商品";
            this.btn新增產品.UseVisualStyleBackColor = false;
            this.btn新增產品.Click += new System.EventHandler(this.btn新增產品_Click);
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn刪除商品.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除商品.Location = new System.Drawing.Point(165, 44);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(109, 69);
            this.btn刪除商品.TabIndex = 16;
            this.btn刪除商品.Text = "刪除商品";
            this.btn刪除商品.UseVisualStyleBackColor = false;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // btn新增店家
            // 
            this.btn新增店家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn新增店家.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增店家.Location = new System.Drawing.Point(18, 36);
            this.btn新增店家.Name = "btn新增店家";
            this.btn新增店家.Size = new System.Drawing.Size(109, 69);
            this.btn新增店家.TabIndex = 17;
            this.btn新增店家.Text = "新增店家";
            this.btn新增店家.UseVisualStyleBackColor = false;
            this.btn新增店家.Click += new System.EventHandler(this.btn新增店家_Click);
            // 
            // midedemoDataSet
            // 
            this.midedemoDataSet.DataSetName = "midedemoDataSet";
            this.midedemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.midedemoDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Order_detailTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication便當訂購系統.midedemoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suppliersBindingNavigator
            // 
            this.suppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliersBindingNavigator.BindingSource = this.suppliersBindingSource;
            this.suppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.suppliersBindingNavigatorSaveItem});
            this.suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliersBindingNavigator.Name = "suppliersBindingNavigator";
            this.suppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliersBindingNavigator.Size = new System.Drawing.Size(1056, 25);
            this.suppliersBindingNavigator.TabIndex = 18;
            this.suppliersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // suppliersBindingNavigatorSaveItem
            // 
            this.suppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBindingNavigatorSaveItem.Image")));
            this.suppliersBindingNavigatorSaveItem.Name = "suppliersBindingNavigatorSaveItem";
            this.suppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.suppliersBindingNavigatorSaveItem.Text = "儲存資料";
            this.suppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliersBindingNavigatorSaveItem_Click);
            // 
            // btn回訂購頁
            // 
            this.btn回訂購頁.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn回訂購頁.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回訂購頁.Location = new System.Drawing.Point(715, 349);
            this.btn回訂購頁.Name = "btn回訂購頁";
            this.btn回訂購頁.Size = new System.Drawing.Size(256, 41);
            this.btn回訂購頁.TabIndex = 19;
            this.btn回訂購頁.Text = "回訂購頁";
            this.btn回訂購頁.UseVisualStyleBackColor = false;
            this.btn回訂購頁.Click += new System.EventHandler(this.btn回訂購頁_Click);
            // 
            // btn店家資料筆數
            // 
            this.btn店家資料筆數.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn店家資料筆數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn店家資料筆數.Location = new System.Drawing.Point(18, 187);
            this.btn店家資料筆數.Name = "btn店家資料筆數";
            this.btn店家資料筆數.Size = new System.Drawing.Size(256, 48);
            this.btn店家資料筆數.TabIndex = 20;
            this.btn店家資料筆數.Text = "店家資料筆數";
            this.btn店家資料筆數.UseVisualStyleBackColor = false;
            this.btn店家資料筆數.Click += new System.EventHandler(this.btn店家資料筆數_Click);
            // 
            // btn商品資料筆數
            // 
            this.btn商品資料筆數.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn商品資料筆數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品資料筆數.Location = new System.Drawing.Point(18, 183);
            this.btn商品資料筆數.Name = "btn商品資料筆數";
            this.btn商品資料筆數.Size = new System.Drawing.Size(256, 51);
            this.btn商品資料筆數.TabIndex = 21;
            this.btn商品資料筆數.Text = "商品資料筆數";
            this.btn商品資料筆數.UseVisualStyleBackColor = false;
            this.btn商品資料筆數.Click += new System.EventHandler(this.btn商品資料筆數_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.btn修改店家資訊);
            this.groupBox3.Controls.Add(this.btn新增店家);
            this.groupBox3.Controls.Add(this.btn刪除店家);
            this.groupBox3.Controls.Add(this.btn店家資料筆數);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(697, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 252);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能選單";
            // 
            // btn修改店家資訊
            // 
            this.btn修改店家資訊.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn修改店家資訊.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改店家資訊.Location = new System.Drawing.Point(18, 124);
            this.btn修改店家資訊.Name = "btn修改店家資訊";
            this.btn修改店家資訊.Size = new System.Drawing.Size(256, 50);
            this.btn修改店家資訊.TabIndex = 21;
            this.btn修改店家資訊.Text = "修改店家資訊";
            this.btn修改店家資訊.UseVisualStyleBackColor = false;
            this.btn修改店家資訊.Click += new System.EventHandler(this.btn修改店家資訊_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btn修改商品資訊);
            this.groupBox4.Controls.Add(this.btn新增產品);
            this.groupBox4.Controls.Add(this.btn刪除商品);
            this.groupBox4.Controls.Add(this.btn商品資料筆數);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(697, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 252);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "功能選單";
            // 
            // btn修改商品資訊
            // 
            this.btn修改商品資訊.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn修改商品資訊.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改商品資訊.Location = new System.Drawing.Point(18, 126);
            this.btn修改商品資訊.Name = "btn修改商品資訊";
            this.btn修改商品資訊.Size = new System.Drawing.Size(256, 51);
            this.btn修改商品資訊.TabIndex = 22;
            this.btn修改商品資訊.Text = "修改商品資訊";
            this.btn修改商品資訊.UseVisualStyleBackColor = false;
            this.btn修改商品資訊.Click += new System.EventHandler(this.btn修改商品資訊_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "最高5星";
            // 
            // Form店家資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 772);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn回訂購頁);
            this.Controls.Add(this.suppliersBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cobox店家代號);
            this.Name = "Form店家資料";
            this.Text = "Form店家資料";
            this.Load += new System.EventHandler(this.Form店家資料_Load_1);
            this.cobox店家代號.ResumeLayout(false);
            this.cobox店家代號.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midedemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).EndInit();
            this.suppliersBindingNavigator.ResumeLayout(false);
            this.suppliersBindingNavigator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb連絡電話;
        private System.Windows.Forms.TextBox tb店家地址;
        private System.Windows.Forms.TextBox tb店家評價;
        private System.Windows.Forms.Button btn刪除店家;
        private System.Windows.Forms.GroupBox cobox店家代號;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb商品代號;
        private System.Windows.Forms.TextBox tb商品單價;
        private System.Windows.Forms.TextBox tb商品名稱;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn新增產品;
        private System.Windows.Forms.Button btn刪除商品;
        private System.Windows.Forms.Button btn新增店家;
        private midedemoDataSet midedemoDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private midedemoDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private midedemoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton suppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btn回訂購頁;
        private System.Windows.Forms.Button btn店家資料筆數;
        private System.Windows.Forms.Button btn商品資料筆數;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cobox店家名字;
        private System.Windows.Forms.TextBox tb店家編號;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cobox店家編號;
        private System.Windows.Forms.ListBox lb店家清單;
        private System.Windows.Forms.ListBox lb商品清單;
        private System.Windows.Forms.Button btn修改店家資訊;
        private System.Windows.Forms.Button btn修改商品資訊;
        private System.Windows.Forms.Label label10;
    }
}