namespace WindowsFormsApplication便當訂購系統
{
    partial class Form登入
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form登入));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb帳號 = new System.Windows.Forms.TextBox();
            this.tb密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn重置 = new System.Windows.Forms.Button();
            this.lbl訊息 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb時間 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(149, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎使用便當購";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(108, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(95, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "帳號";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb帳號
            // 
            this.tb帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb帳號.Location = new System.Drawing.Point(233, 260);
            this.tb帳號.Multiline = true;
            this.tb帳號.Name = "tb帳號";
            this.tb帳號.Size = new System.Drawing.Size(163, 36);
            this.tb帳號.TabIndex = 3;
            // 
            // tb密碼
            // 
            this.tb密碼.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb密碼.Location = new System.Drawing.Point(233, 329);
            this.tb密碼.Multiline = true;
            this.tb密碼.Name = "tb密碼";
            this.tb密碼.PasswordChar = '*';
            this.tb密碼.Size = new System.Drawing.Size(163, 36);
            this.tb密碼.TabIndex = 4;
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(68, 536);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(119, 63);
            this.btn登入.TabIndex = 5;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn重置
            // 
            this.btn重置.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn重置.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重置.Location = new System.Drawing.Point(437, 536);
            this.btn重置.Name = "btn重置";
            this.btn重置.Size = new System.Drawing.Size(119, 63);
            this.btn重置.TabIndex = 6;
            this.btn重置.Text = "重置";
            this.btn重置.UseVisualStyleBackColor = false;
            this.btn重置.Click += new System.EventHandler(this.btn重置_Click);
            // 
            // lbl訊息
            // 
            this.lbl訊息.BackColor = System.Drawing.Color.Transparent;
            this.lbl訊息.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訊息.Location = new System.Drawing.Point(231, 433);
            this.lbl訊息.Name = "lbl訊息";
            this.lbl訊息.Size = new System.Drawing.Size(165, 76);
            this.lbl訊息.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb時間
            // 
            this.lb時間.AutoSize = true;
            this.lb時間.BackColor = System.Drawing.Color.Transparent;
            this.lb時間.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb時間.Location = new System.Drawing.Point(455, 9);
            this.lb時間.Name = "lb時間";
            this.lb時間.Size = new System.Drawing.Size(85, 19);
            this.lb時間.TabIndex = 8;
            this.lb時間.Text = "現在時間";
            // 
            // Form登入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(658, 733);
            this.Controls.Add(this.lb時間);
            this.Controls.Add(this.lbl訊息);
            this.Controls.Add(this.btn重置);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.tb密碼);
            this.Controls.Add(this.tb帳號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form登入";
            this.Text = "登入頁面";
            this.Load += new System.EventHandler(this.Form登入_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb帳號;
        private System.Windows.Forms.TextBox tb密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn重置;
        private System.Windows.Forms.Label lbl訊息;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb時間;
    }
}

