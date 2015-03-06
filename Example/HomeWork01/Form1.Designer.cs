namespace HomeWork01
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxStudentDiscount = new System.Windows.Forms.ComboBox();
            this.comboBoxBoyDiscount = new System.Windows.Forms.ComboBox();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.textBoxTicketNum = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxStudentDiscount
            // 
            this.comboBoxStudentDiscount.FormattingEnabled = true;
            this.comboBoxStudentDiscount.Location = new System.Drawing.Point(12, 12);
            this.comboBoxStudentDiscount.Name = "comboBoxStudentDiscount";
            this.comboBoxStudentDiscount.Size = new System.Drawing.Size(156, 20);
            this.comboBoxStudentDiscount.TabIndex = 0;
            // 
            // comboBoxBoyDiscount
            // 
            this.comboBoxBoyDiscount.FormattingEnabled = true;
            this.comboBoxBoyDiscount.Location = new System.Drawing.Point(194, 12);
            this.comboBoxBoyDiscount.Name = "comboBoxBoyDiscount";
            this.comboBoxBoyDiscount.Size = new System.Drawing.Size(156, 20);
            this.comboBoxBoyDiscount.TabIndex = 1;
            // 
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Location = new System.Drawing.Point(12, 70);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(156, 20);
            this.comboBoxTicketType.TabIndex = 2;
            // 
            // textBoxTicketNum
            // 
            this.textBoxTicketNum.Location = new System.Drawing.Point(194, 68);
            this.textBoxTicketNum.Name = "textBoxTicketNum";
            this.textBoxTicketNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxTicketNum.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(316, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 100);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 236);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTicketNum);
            this.Controls.Add(this.comboBoxTicketType);
            this.Controls.Add(this.comboBoxBoyDiscount);
            this.Controls.Add(this.comboBoxStudentDiscount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudentDiscount;
        private System.Windows.Forms.ComboBox comboBoxBoyDiscount;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.TextBox textBoxTicketNum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
    }
}

