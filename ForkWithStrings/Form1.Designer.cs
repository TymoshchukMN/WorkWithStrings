namespace WorkWithStrings
{
    partial class Form1
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
            this.workType = new System.Windows.Forms.GroupBox();
            this.cBLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.rbCompText = new System.Windows.Forms.RadioButton();
            this.rbCheckSymbosl = new System.Windows.Forms.RadioButton();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.workType.SuspendLayout();
            this.SuspendLayout();
            // 
            // workType
            // 
            this.workType.Controls.Add(this.cBLanguage);
            this.workType.Controls.Add(this.lbLanguage);
            this.workType.Controls.Add(this.rbCompText);
            this.workType.Controls.Add(this.rbCheckSymbosl);
            this.workType.Location = new System.Drawing.Point(12, 12);
            this.workType.Name = "workType";
            this.workType.Size = new System.Drawing.Size(442, 100);
            this.workType.TabIndex = 0;
            this.workType.TabStop = false;
            this.workType.Text = "Тип работы";
            // 
            // cBLanguage
            // 
            this.cBLanguage.FormattingEnabled = true;
            this.cBLanguage.Items.AddRange(new object[] {
            "RU",
            "EN",
            "UA"});
            this.cBLanguage.Location = new System.Drawing.Point(299, 16);
            this.cBLanguage.Name = "cBLanguage";
            this.cBLanguage.Size = new System.Drawing.Size(121, 21);
            this.cBLanguage.TabIndex = 3;
            this.cBLanguage.Text = "EN";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(170, 20);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(123, 13);
            this.lbLanguage.TabIndex = 2;
            this.lbLanguage.Text = "Основной язык текста";
            // 
            // rbCompText
            // 
            this.rbCompText.AutoSize = true;
            this.rbCompText.Location = new System.Drawing.Point(6, 42);
            this.rbCompText.Name = "rbCompText";
            this.rbCompText.Size = new System.Drawing.Size(123, 17);
            this.rbCompText.TabIndex = 1;
            this.rbCompText.TabStop = true;
            this.rbCompText.Text = "Сравнение текстов";
            this.rbCompText.UseVisualStyleBackColor = true;
            this.rbCompText.CheckedChanged += new System.EventHandler(this.RbCompText_CheckedChanged);
            // 
            // rbCheckSymbosl
            // 
            this.rbCheckSymbosl.AutoSize = true;
            this.rbCheckSymbosl.Location = new System.Drawing.Point(6, 20);
            this.rbCheckSymbosl.Name = "rbCheckSymbosl";
            this.rbCheckSymbosl.Size = new System.Drawing.Size(128, 17);
            this.rbCheckSymbosl.TabIndex = 0;
            this.rbCheckSymbosl.TabStop = true;
            this.rbCheckSymbosl.Text = "Проверка символов";
            this.rbCheckSymbosl.UseVisualStyleBackColor = true;
            this.rbCheckSymbosl.CheckedChanged += new System.EventHandler(this.RbCheckSymbosl_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBoxSource.Location = new System.Drawing.Point(18, 135);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBox1";
            this.textBoxSource.Size = new System.Drawing.Size(380, 130);
            this.textBoxSource.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 135);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 130);
            this.textBox2.TabIndex = 2;
            // 
            // btProcess
            // 
            this.btProcess.Location = new System.Drawing.Point(521, 50);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(75, 25);
            this.btProcess.TabIndex = 3;
            this.btProcess.Text = "Обработать";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.BtProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат";
            // 
            // textBox3
            // 
            this.textBoxResult.Location = new System.Drawing.Point(18, 324);
            this.textBoxResult.Name = "textBox3";
            this.textBoxResult.Size = new System.Drawing.Size(380, 101);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 634);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.workType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.workType.ResumeLayout(false);
            this.workType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox workType;
        private System.Windows.Forms.RadioButton rbCompText;
        private System.Windows.Forms.RadioButton rbCheckSymbosl;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.RichTextBox textBoxResult;
    }
}

