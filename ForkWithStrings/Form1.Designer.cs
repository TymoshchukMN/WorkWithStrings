using System.Windows.Forms;

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
            this.textComparable = new System.Windows.Forms.TextBox();
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
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(20, 135);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSource.Size = new System.Drawing.Size(450, 230);
            this.textBoxSource.TabIndex = 1;
            // 
            // textComparable
            // 
            this.textComparable.Location = new System.Drawing.Point(513, 135);
            this.textComparable.Multiline = true;
            this.textComparable.Name = "textComparable";
            this.textComparable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textComparable.Size = new System.Drawing.Size(450, 230);
            this.textComparable.TabIndex = 2;
            // 
            // btProcess
            // 
            this.btProcess.BackColor = System.Drawing.Color.LightGreen;
            this.btProcess.Location = new System.Drawing.Point(500, 45);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(105, 35);
            this.btProcess.TabIndex = 3;
            this.btProcess.Text = "Обработать";
            this.btProcess.UseVisualStyleBackColor = false;
            this.btProcess.Click += new System.EventHandler(this.BtProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(20, 394);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(943, 281);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(982, 692);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.textComparable);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.workType);
            this.Name = "Form1";
            this.Text = "Обработчик текста";
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
        private System.Windows.Forms.TextBox textComparable;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.RichTextBox textBoxResult;
    }
}

