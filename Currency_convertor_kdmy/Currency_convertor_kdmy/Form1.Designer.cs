namespace Currency_convertor_kdmy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lb_from = new System.Windows.Forms.ListBox();
            this.lb_to = new System.Windows.Forms.ListBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.Location = new System.Drawing.Point(226, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(269, 36);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Currency convertor";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sum.Location = new System.Drawing.Point(163, 72);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(64, 26);
            this.lbl_sum.TabIndex = 1;
            this.lbl_sum.Text = "Sum:";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sum
            // 
            this.tb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sum.Location = new System.Drawing.Point(261, 67);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(201, 31);
            this.tb_sum.TabIndex = 2;
            this.tb_sum.Text = "1";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_from.Location = new System.Drawing.Point(37, 128);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(69, 26);
            this.lbl_from.TabIndex = 3;
            this.lbl_from.Text = "From:";
            this.lbl_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_to.Location = new System.Drawing.Point(399, 127);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(42, 26);
            this.lbl_to.TabIndex = 4;
            this.lbl_to.Text = "To:";
            this.lbl_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_from
            // 
            this.lb_from.FormattingEnabled = true;
            this.lb_from.Items.AddRange(new object[] {
            "USD",
            "UAH",
            "EUR",
            "GBP",
            "RUB"});
            this.lb_from.Location = new System.Drawing.Point(117, 129);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(171, 121);
            this.lb_from.TabIndex = 5;
            // 
            // lb_to
            // 
            this.lb_to.FormattingEnabled = true;
            this.lb_to.Items.AddRange(new object[] {
            "USD",
            "UAH",
            "EUR",
            "GBP",
            "RUB"});
            this.lb_to.Location = new System.Drawing.Point(447, 128);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(171, 121);
            this.lb_to.TabIndex = 6;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(277, 267);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(176, 42);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 92);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(658, 401);
            this.webBrowser1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_from);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Controls.Add(this.btn_convert);
            this.panel1.Controls.Add(this.lbl_sum);
            this.panel1.Controls.Add(this.lb_to);
            this.panel1.Controls.Add(this.tb_sum);
            this.panel1.Controls.Add(this.lbl_from);
            this.panel1.Controls.Add(this.lbl_to);
            this.panel1.Location = new System.Drawing.Point(21, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 317);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.ListBox lb_from;
        private System.Windows.Forms.ListBox lb_to;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
    }
}

