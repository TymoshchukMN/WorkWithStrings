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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.cBLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(20, 49);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSource.Size = new System.Drawing.Size(447, 130);
            this.textBoxSource.TabIndex = 1;
            // 
            // btProcess
            // 
            this.btProcess.BackColor = System.Drawing.Color.LightGreen;
            this.btProcess.Location = new System.Drawing.Point(362, 5);
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
            this.label1.Location = new System.Drawing.Point(17, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(20, 273);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(447, 124);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.Text = "";
            // 
            // cBLanguage
            // 
            this.cBLanguage.FormattingEnabled = true;
            this.cBLanguage.Items.AddRange(new object[] {
            "RU",
            "EN",
            "UA"});
            this.cBLanguage.Location = new System.Drawing.Point(152, 19);
            this.cBLanguage.Name = "cBLanguage";
            this.cBLanguage.Size = new System.Drawing.Size(121, 21);
            this.cBLanguage.TabIndex = 8;
            this.cBLanguage.Text = "EN";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(23, 22);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(123, 13);
            this.lbLanguage.TabIndex = 7;
            this.lbLanguage.Text = "Основной язык текста";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(20, 240);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(447, 20);
            this.tbMessage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 480);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.cBLanguage);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.textBoxSource);
            this.Name = "Form1";
            this.Text = "Обработчик текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBoxResult;
        private ComboBox cBLanguage;
        private Label lbLanguage;
        private TextBox tbMessage;
    }
}

