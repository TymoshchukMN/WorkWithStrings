namespace ForkWithStrings
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
            this.rbCompText = new System.Windows.Forms.RadioButton();
            this.rbCheckSymbosl = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workType.SuspendLayout();
            this.SuspendLayout();
            // 
            // workType
            // 
            this.workType.Controls.Add(this.rbCompText);
            this.workType.Controls.Add(this.rbCheckSymbosl);
            this.workType.Location = new System.Drawing.Point(12, 12);
            this.workType.Name = "workType";
            this.workType.Size = new System.Drawing.Size(388, 100);
            this.workType.TabIndex = 0;
            this.workType.TabStop = false;
            this.workType.Text = "Тип работы";
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
            this.rbCompText.CheckedChanged += new System.EventHandler(this.rbCompText_CheckedChanged);
            // 
            // rbCheckSymbosl
            // 
            this.rbCheckSymbosl.AutoSize = true;
            this.rbCheckSymbosl.Location = new System.Drawing.Point(6, 19);
            this.rbCheckSymbosl.Name = "rbCheckSymbosl";
            this.rbCheckSymbosl.Size = new System.Drawing.Size(128, 17);
            this.rbCheckSymbosl.TabIndex = 0;
            this.rbCheckSymbosl.TabStop = true;
            this.rbCheckSymbosl.Text = "Проверка символов";
            this.rbCheckSymbosl.UseVisualStyleBackColor = true;
            this.rbCheckSymbosl.CheckedChanged += new System.EventHandler(this.rbCheckSymbosl_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 130);
            this.textBox1.TabIndex = 1;
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
            this.btProcess.Location = new System.Drawing.Point(460, 50);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(75, 25);
            this.btProcess.TabIndex = 3;
            this.btProcess.Text = "Обработать";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 324);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(382, 162);
            this.textBox3.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

