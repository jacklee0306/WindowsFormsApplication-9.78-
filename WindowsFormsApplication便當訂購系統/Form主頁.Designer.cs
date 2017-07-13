namespace WindowsFormsApplication便當訂購系統
{
    partial class Form主頁
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form主頁));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.便當訂購 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tb總額 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn點餐確定 = new System.Windows.Forms.Button();
            this.btn刪除點餐 = new System.Windows.Forms.Button();
            this.clb訂購者 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb商品單價 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn減1 = new System.Windows.Forms.Button();
            this.btn加1 = new System.Windows.Forms.Button();
            this.tb訂購份數 = new System.Windows.Forms.TextBox();
            this.cobox訂購內容 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb現在時間 = new System.Windows.Forms.Label();
            this.tb值日生教室 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cobox值日生 = new System.Windows.Forms.ComboBox();
            this.cobox店家稱呼 = new System.Windows.Forms.ComboBox();
            this.tb連絡電話 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.後台管理 = new System.Windows.Forms.TabPage();
            this.btn店家資料管理 = new System.Windows.Forms.Button();
            this.btn學生資料管理 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.lv商品訂購清單 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.便當訂購.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.後台管理.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.便當訂購);
            this.tabControl1.Controls.Add(this.後台管理);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // 便當訂購
            // 
            this.便當訂購.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("便當訂購.BackgroundImage")));
            this.便當訂購.Controls.Add(this.label11);
            this.便當訂購.Controls.Add(this.tb總額);
            this.便當訂購.Controls.Add(this.label8);
            this.便當訂購.Controls.Add(this.groupBox2);
            this.便當訂購.Controls.Add(this.clb訂購者);
            this.便當訂購.Controls.Add(this.label7);
            this.便當訂購.Controls.Add(this.tb商品單價);
            this.便當訂購.Controls.Add(this.label10);
            this.便當訂購.Controls.Add(this.label9);
            this.便當訂購.Controls.Add(this.btn減1);
            this.便當訂購.Controls.Add(this.btn加1);
            this.便當訂購.Controls.Add(this.tb訂購份數);
            this.便當訂購.Controls.Add(this.cobox訂購內容);
            this.便當訂購.Controls.Add(this.label5);
            this.便當訂購.Controls.Add(this.groupBox1);
            this.便當訂購.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.便當訂購.Location = new System.Drawing.Point(4, 22);
            this.便當訂購.Name = "便當訂購";
            this.便當訂購.Padding = new System.Windows.Forms.Padding(3);
            this.便當訂購.Size = new System.Drawing.Size(557, 666);
            this.便當訂購.TabIndex = 0;
            this.便當訂購.Text = "便當訂購";
            this.便當訂購.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(497, 618);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "元";
            // 
            // tb總額
            // 
            this.tb總額.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb總額.Location = new System.Drawing.Point(393, 618);
            this.tb總額.Multiline = true;
            this.tb總額.Name = "tb總額";
            this.tb總額.Size = new System.Drawing.Size(98, 32);
            this.tb總額.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(301, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "總金額";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn點餐確定);
            this.groupBox2.Controls.Add(this.btn刪除點餐);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(23, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能選單";
            // 
            // btn點餐確定
            // 
            this.btn點餐確定.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn點餐確定.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn點餐確定.Location = new System.Drawing.Point(0, 45);
            this.btn點餐確定.Name = "btn點餐確定";
            this.btn點餐確定.Size = new System.Drawing.Size(106, 58);
            this.btn點餐確定.TabIndex = 20;
            this.btn點餐確定.Text = "點餐確定";
            this.btn點餐確定.UseVisualStyleBackColor = false;
            this.btn點餐確定.Click += new System.EventHandler(this.btn點餐確定_Click);
            // 
            // btn刪除點餐
            // 
            this.btn刪除點餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn刪除點餐.Location = new System.Drawing.Point(156, 45);
            this.btn刪除點餐.Name = "btn刪除點餐";
            this.btn刪除點餐.Size = new System.Drawing.Size(106, 58);
            this.btn刪除點餐.TabIndex = 21;
            this.btn刪除點餐.Text = "刪除點餐";
            this.btn刪除點餐.UseVisualStyleBackColor = false;
            this.btn刪除點餐.Click += new System.EventHandler(this.btn刪除點餐_Click);
            // 
            // clb訂購者
            // 
            this.clb訂購者.FormattingEnabled = true;
            this.clb訂購者.Location = new System.Drawing.Point(24, 469);
            this.clb訂購者.Name = "clb訂購者";
            this.clb訂購者.Size = new System.Drawing.Size(190, 88);
            this.clb訂購者.TabIndex = 19;
            this.clb訂購者.SelectedIndexChanged += new System.EventHandler(this.clb訂購者_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 42);
            this.label7.TabIndex = 18;
            this.label7.Text = "訂購者";
            // 
            // tb商品單價
            // 
            this.tb商品單價.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb商品單價.Location = new System.Drawing.Point(238, 385);
            this.tb商品單價.Name = "tb商品單價";
            this.tb商品單價.ReadOnly = true;
            this.tb商品單價.Size = new System.Drawing.Size(100, 33);
            this.tb商品單價.TabIndex = 15;
            this.tb商品單價.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(242, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 42);
            this.label10.TabIndex = 14;
            this.label10.Text = "商品單價";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(409, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 42);
            this.label9.TabIndex = 13;
            this.label9.Text = "訂購份數";
            // 
            // btn減1
            // 
            this.btn減1.Location = new System.Drawing.Point(515, 387);
            this.btn減1.Name = "btn減1";
            this.btn減1.Size = new System.Drawing.Size(36, 32);
            this.btn減1.TabIndex = 9;
            this.btn減1.Text = "-";
            this.btn減1.UseVisualStyleBackColor = true;
            this.btn減1.Click += new System.EventHandler(this.btn減1_Click);
            // 
            // btn加1
            // 
            this.btn加1.Location = new System.Drawing.Point(348, 387);
            this.btn加1.Name = "btn加1";
            this.btn加1.Size = new System.Drawing.Size(39, 32);
            this.btn加1.TabIndex = 8;
            this.btn加1.Text = "+";
            this.btn加1.UseVisualStyleBackColor = true;
            this.btn加1.Click += new System.EventHandler(this.btn加1_Click);
            // 
            // tb訂購份數
            // 
            this.tb訂購份數.Location = new System.Drawing.Point(402, 386);
            this.tb訂購份數.Name = "tb訂購份數";
            this.tb訂購份數.Size = new System.Drawing.Size(100, 33);
            this.tb訂購份數.TabIndex = 7;
            this.tb訂購份數.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb訂購份數.TextChanged += new System.EventHandler(this.tb訂購份數_TextChanged);
            // 
            // cobox訂購內容
            // 
            this.cobox訂購內容.FormattingEnabled = true;
            this.cobox訂購內容.Location = new System.Drawing.Point(23, 386);
            this.cobox訂購內容.Name = "cobox訂購內容";
            this.cobox訂購內容.Size = new System.Drawing.Size(190, 32);
            this.cobox訂購內容.TabIndex = 6;
            this.cobox訂購內容.SelectedIndexChanged += new System.EventHandler(this.cobox訂購內容_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "訂購餐點內容";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb現在時間);
            this.groupBox1.Controls.Add(this.tb值日生教室);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cobox值日生);
            this.groupBox1.Controls.Add(this.cobox店家稱呼);
            this.groupBox1.Controls.Add(this.tb連絡電話);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購基本資料";
            // 
            // lb現在時間
            // 
            this.lb現在時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb現在時間.Location = new System.Drawing.Point(140, 276);
            this.lb現在時間.Name = "lb現在時間";
            this.lb現在時間.Size = new System.Drawing.Size(241, 39);
            this.lb現在時間.TabIndex = 12;
            this.lb現在時間.Text = "現在時間";
            // 
            // tb值日生教室
            // 
            this.tb值日生教室.Location = new System.Drawing.Point(136, 221);
            this.tb值日生教室.Name = "tb值日生教室";
            this.tb值日生教室.Size = new System.Drawing.Size(196, 35);
            this.tb值日生教室.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "教室";
            // 
            // cobox值日生
            // 
            this.cobox值日生.FormattingEnabled = true;
            this.cobox值日生.Location = new System.Drawing.Point(136, 161);
            this.cobox值日生.Name = "cobox值日生";
            this.cobox值日生.Size = new System.Drawing.Size(196, 34);
            this.cobox值日生.TabIndex = 8;
            this.cobox值日生.SelectedIndexChanged += new System.EventHandler(this.cobox值日生_SelectedIndexChanged);
            // 
            // cobox店家稱呼
            // 
            this.cobox店家稱呼.FormattingEnabled = true;
            this.cobox店家稱呼.Location = new System.Drawing.Point(136, 50);
            this.cobox店家稱呼.Name = "cobox店家稱呼";
            this.cobox店家稱呼.Size = new System.Drawing.Size(196, 34);
            this.cobox店家稱呼.TabIndex = 7;
            this.cobox店家稱呼.SelectedIndexChanged += new System.EventHandler(this.cobox店家稱呼_SelectedIndexChanged);
            // 
            // tb連絡電話
            // 
            this.tb連絡電話.Location = new System.Drawing.Point(136, 104);
            this.tb連絡電話.Name = "tb連絡電話";
            this.tb連絡電話.Size = new System.Drawing.Size(196, 35);
            this.tb連絡電話.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "訂購時間";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "連絡電話";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "值日生";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "店家名稱";
            // 
            // 後台管理
            // 
            this.後台管理.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("後台管理.BackgroundImage")));
            this.後台管理.Controls.Add(this.btn店家資料管理);
            this.後台管理.Controls.Add(this.btn學生資料管理);
            this.後台管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.後台管理.Location = new System.Drawing.Point(4, 22);
            this.後台管理.Name = "後台管理";
            this.後台管理.Padding = new System.Windows.Forms.Padding(3);
            this.後台管理.Size = new System.Drawing.Size(557, 666);
            this.後台管理.TabIndex = 1;
            this.後台管理.Text = "後台管理";
            this.後台管理.UseVisualStyleBackColor = true;
            // 
            // btn店家資料管理
            // 
            this.btn店家資料管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn店家資料管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn店家資料管理.Location = new System.Drawing.Point(191, 312);
            this.btn店家資料管理.Name = "btn店家資料管理";
            this.btn店家資料管理.Size = new System.Drawing.Size(174, 43);
            this.btn店家資料管理.TabIndex = 1;
            this.btn店家資料管理.Text = "店家資料管理";
            this.btn店家資料管理.UseVisualStyleBackColor = false;
            this.btn店家資料管理.Click += new System.EventHandler(this.btn店家資料管理_Click);
            // 
            // btn學生資料管理
            // 
            this.btn學生資料管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn學生資料管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn學生資料管理.Location = new System.Drawing.Point(191, 219);
            this.btn學生資料管理.Name = "btn學生資料管理";
            this.btn學生資料管理.Size = new System.Drawing.Size(174, 43);
            this.btn學生資料管理.TabIndex = 0;
            this.btn學生資料管理.Text = "學生資料管理";
            this.btn學生資料管理.UseVisualStyleBackColor = false;
            this.btn學生資料管理.Click += new System.EventHandler(this.btn學生資料管理_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn送出訂單);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(583, 604);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "最終確認";
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn送出訂單.Location = new System.Drawing.Point(17, 39);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(106, 58);
            this.btn送出訂單.TabIndex = 16;
            this.btn送出訂單.Text = "送出訂單";
            this.btn送出訂單.UseVisualStyleBackColor = false;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // lv商品訂購清單
            // 
            this.lv商品訂購清單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lv商品訂購清單.Location = new System.Drawing.Point(583, 34);
            this.lv商品訂購清單.Name = "lv商品訂購清單";
            this.lv商品訂購清單.Size = new System.Drawing.Size(539, 559);
            this.lv商品訂購清單.TabIndex = 1;
            this.lv商品訂購清單.UseCompatibleStateImageBehavior = false;
            this.lv商品訂購清單.View = System.Windows.Forms.View.Details;
            this.lv商品訂購清單.SelectedIndexChanged += new System.EventHandler(this.lv商品訂購清單_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(728, 669);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "註:金額收齊後再送出!!";
            // 
            // Form主頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 727);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lv商品訂購清單);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form主頁";
            this.Text = "Form主頁";
            this.Load += new System.EventHandler(this.Form主頁_Load);
            this.tabControl1.ResumeLayout(false);
            this.便當訂購.ResumeLayout(false);
            this.便當訂購.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.後台管理.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 便當訂購;
        private System.Windows.Forms.Button btn送出訂單;
        private System.Windows.Forms.TextBox tb商品單價;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn減1;
        private System.Windows.Forms.Button btn加1;
        private System.Windows.Forms.TextBox tb訂購份數;
        private System.Windows.Forms.ComboBox cobox訂購內容;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobox店家稱呼;
        private System.Windows.Forms.TextBox tb連絡電話;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage 後台管理;
        private System.Windows.Forms.Button btn店家資料管理;
        private System.Windows.Forms.Button btn學生資料管理;
        private System.Windows.Forms.CheckedListBox clb訂購者;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cobox值日生;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn點餐確定;
        private System.Windows.Forms.Button btn刪除點餐;
        private System.Windows.Forms.ListView lv商品訂購清單;
        private System.Windows.Forms.TextBox tb值日生教室;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb總額;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb現在時間;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
    }
}