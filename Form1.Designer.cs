namespace pwgentoo
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
            this.components = new System.ComponentModel.Container();
            this.edPasswordLen = new System.Windows.Forms.TextBox();
            this.edCountPosswords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chUsePunktuation = new System.Windows.Forms.CheckBox();
            this.chUseEntropy = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.moPasswords = new System.Windows.Forms.TextBox();
            this.chClear = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chStrongly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // edPasswordLen
            // 
            this.edPasswordLen.Location = new System.Drawing.Point(24, 47);
            this.edPasswordLen.Name = "edPasswordLen";
            this.edPasswordLen.Size = new System.Drawing.Size(58, 20);
            this.edPasswordLen.TabIndex = 0;
            this.edPasswordLen.Text = "10";
            // 
            // edCountPosswords
            // 
            this.edCountPosswords.Location = new System.Drawing.Point(24, 101);
            this.edCountPosswords.Name = "edCountPosswords";
            this.edCountPosswords.Size = new System.Drawing.Size(56, 20);
            this.edCountPosswords.TabIndex = 1;
            this.edCountPosswords.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длинна пароля :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество паролей :";
            // 
            // chUsePunktuation
            // 
            this.chUsePunktuation.AutoSize = true;
            this.chUsePunktuation.Location = new System.Drawing.Point(166, 31);
            this.chUsePunktuation.Name = "chUsePunktuation";
            this.chUsePunktuation.Size = new System.Drawing.Size(221, 17);
            this.chUsePunktuation.TabIndex = 4;
            this.chUsePunktuation.Text = "Использовать не буквенные символы";
            this.chUsePunktuation.UseVisualStyleBackColor = true;
            // 
            // chUseEntropy
            // 
            this.chUseEntropy.AutoSize = true;
            this.chUseEntropy.Location = new System.Drawing.Point(166, 54);
            this.chUseEntropy.Name = "chUseEntropy";
            this.chUseEntropy.Size = new System.Drawing.Size(135, 17);
            this.chUseEntropy.TabIndex = 5;
            this.chUseEntropy.Text = "Все символы разные";
            this.chUseEntropy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Генерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moPasswords
            // 
            this.moPasswords.Location = new System.Drawing.Point(24, 175);
            this.moPasswords.Multiline = true;
            this.moPasswords.Name = "moPasswords";
            this.moPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.moPasswords.Size = new System.Drawing.Size(312, 150);
            this.moPasswords.TabIndex = 7;
            // 
            // chClear
            // 
            this.chClear.AutoSize = true;
            this.chClear.Location = new System.Drawing.Point(234, 152);
            this.chClear.Name = "chClear";
            this.chClear.Size = new System.Drawing.Size(71, 17);
            this.chClear.TabIndex = 8;
            this.chClear.Text = "Очищать";
            this.chClear.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chStrongly
            // 
            this.chStrongly.AutoSize = true;
            this.chStrongly.Location = new System.Drawing.Point(166, 77);
            this.chStrongly.Name = "chStrongly";
            this.chStrongly.Size = new System.Drawing.Size(131, 17);
            this.chStrongly.TabIndex = 9;
            this.chStrongly.Text = "Выводить стойкость";
            this.chStrongly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 352);
            this.Controls.Add(this.chStrongly);
            this.Controls.Add(this.chClear);
            this.Controls.Add(this.moPasswords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chUseEntropy);
            this.Controls.Add(this.chUsePunktuation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edCountPosswords);
            this.Controls.Add(this.edPasswordLen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pwgen Password generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edPasswordLen;
        private System.Windows.Forms.TextBox edCountPosswords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chUsePunktuation;
        private System.Windows.Forms.CheckBox chUseEntropy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox moPasswords;
        private System.Windows.Forms.CheckBox chClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chStrongly;
    }
}

