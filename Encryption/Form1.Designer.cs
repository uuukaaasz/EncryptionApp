namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSym = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputSym = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultSym = new System.Windows.Forms.TextBox();
            this.buttonSynch = new System.Windows.Forms.Button();
            this.buttonSynchFile = new System.Windows.Forms.Button();
            this.buttonSynchClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAsynchClear = new System.Windows.Forms.Button();
            this.buttonAsynch = new System.Windows.Forms.Button();
            this.buttonAsynchFile = new System.Windows.Forms.Button();
            this.textBoxResultAsym = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInputAsym = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAsym = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSynchClear);
            this.groupBox1.Controls.Add(this.buttonSynch);
            this.groupBox1.Controls.Add(this.buttonSynchFile);
            this.groupBox1.Controls.Add(this.textBoxResultSym);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxInputSym);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxSym);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szyfrowanie symetryczne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co chcesz zrobić?";
            // 
            // comboBoxSynch
            // 
            this.comboBoxSym.FormattingEnabled = true;
            this.comboBoxSym.Items.AddRange(new object[] {
            "Zaszyfruj",
            "Odszyfruj"});
            this.comboBoxSym.Location = new System.Drawing.Point(19, 48);
            this.comboBoxSym.Name = "comboBoxSynch";
            this.comboBoxSym.Size = new System.Drawing.Size(257, 24);
            this.comboBoxSym.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wprowadź tekst";
            // 
            // textBoxInputSynch
            // 
            this.textBoxInputSym.Location = new System.Drawing.Point(19, 107);
            this.textBoxInputSym.Name = "textBoxInputSynch";
            this.textBoxInputSym.Size = new System.Drawing.Size(257, 22);
            this.textBoxInputSym.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wynik";
            // 
            // textBoxResultSynch
            // 
            this.textBoxResultSym.Location = new System.Drawing.Point(19, 163);
            this.textBoxResultSym.Name = "textBoxResultSynch";
            this.textBoxResultSym.Size = new System.Drawing.Size(257, 22);
            this.textBoxResultSym.TabIndex = 1;
            // 
            // buttonSynch
            // 
            this.buttonSynch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSynch.Location = new System.Drawing.Point(19, 225);
            this.buttonSynch.Name = "buttonSynch";
            this.buttonSynch.Size = new System.Drawing.Size(257, 58);
            this.buttonSynch.TabIndex = 1;
            this.buttonSynch.Text = "Wykonaj operację";
            this.buttonSynch.UseVisualStyleBackColor = true;
            this.buttonSynch.Click += new System.EventHandler(this.buttonSym_Click);
            // 
            // buttonSynchFile
            // 
            this.buttonSynchFile.Location = new System.Drawing.Point(19, 289);
            this.buttonSynchFile.Name = "buttonSynchFile";
            this.buttonSynchFile.Size = new System.Drawing.Size(257, 52);
            this.buttonSynchFile.TabIndex = 1;
            this.buttonSynchFile.Text = "Symetryczne szyfrowanie pliku";
            this.buttonSynchFile.UseVisualStyleBackColor = true;
            this.buttonSynchFile.Click += new System.EventHandler(this.buttonSymFile_Click);
            // 
            // buttonSynchClear
            // 
            this.buttonSynchClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSynchClear.Location = new System.Drawing.Point(19, 346);
            this.buttonSynchClear.Name = "buttonSynchClear";
            this.buttonSynchClear.Size = new System.Drawing.Size(257, 58);
            this.buttonSynchClear.TabIndex = 4;
            this.buttonSynchClear.Text = "Wyczyść formularz";
            this.buttonSynchClear.UseVisualStyleBackColor = false;
            this.buttonSynchClear.Click += new System.EventHandler(this.buttonSymClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPublicKey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxPrivateKey);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonAsynchClear);
            this.groupBox2.Controls.Add(this.buttonAsynchFile);
            this.groupBox2.Controls.Add(this.buttonAsynch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxAsym);
            this.groupBox2.Controls.Add(this.textBoxResultAsym);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxInputAsym);
            this.groupBox2.Location = new System.Drawing.Point(337, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szyfrowanie asymetryczne";
            // 
            // buttonAsynchClear
            // 
            this.buttonAsynchClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAsynchClear.Location = new System.Drawing.Point(288, 352);
            this.buttonAsynchClear.Name = "buttonAsynchClear";
            this.buttonAsynchClear.Size = new System.Drawing.Size(194, 52);
            this.buttonAsynchClear.TabIndex = 13;
            this.buttonAsynchClear.Text = "Wyczyść formularz";
            this.buttonAsynchClear.UseVisualStyleBackColor = false;
            this.buttonAsynchClear.Click += new System.EventHandler(this.buttonAsymClear_Click);
            // 
            // buttonAsynch
            // 
            this.buttonAsynch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAsynch.Location = new System.Drawing.Point(22, 285);
            this.buttonAsynch.Name = "buttonAsynch";
            this.buttonAsynch.Size = new System.Drawing.Size(460, 61);
            this.buttonAsynch.TabIndex = 6;
            this.buttonAsynch.Text = "Wykonaj operację";
            this.buttonAsynch.UseVisualStyleBackColor = true;
            this.buttonAsynch.Click += new System.EventHandler(this.buttonAsym_Click);
            // 
            // buttonAsynchFile
            // 
            this.buttonAsynchFile.Location = new System.Drawing.Point(22, 352);
            this.buttonAsynchFile.Name = "buttonAsynchFile";
            this.buttonAsynchFile.Size = new System.Drawing.Size(260, 52);
            this.buttonAsynchFile.TabIndex = 7;
            this.buttonAsynchFile.Text = "Asymetryczne szyfrowanie pliku";
            this.buttonAsynchFile.UseVisualStyleBackColor = true;
            this.buttonAsynchFile.Click += new System.EventHandler(this.buttonAsymFile_Click);
            // 
            // textBoxResultAsynch
            // 
            this.textBoxResultAsym.Location = new System.Drawing.Point(22, 163);
            this.textBoxResultAsym.Name = "textBoxResultAsynch";
            this.textBoxResultAsym.Size = new System.Drawing.Size(460, 22);
            this.textBoxResultAsym.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wynik";
            // 
            // textBoxInputAsynch
            // 
            this.textBoxInputAsym.Location = new System.Drawing.Point(22, 107);
            this.textBoxInputAsym.Name = "textBoxInputAsynch";
            this.textBoxInputAsym.Size = new System.Drawing.Size(460, 22);
            this.textBoxInputAsym.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wprowadź tekst";
            // 
            // comboBoxAsynch
            // 
            this.comboBoxAsym.FormattingEnabled = true;
            this.comboBoxAsym.Items.AddRange(new object[] {
            "Zaszyfruj",
            "Odszyfruj"});
            this.comboBoxAsym.Location = new System.Drawing.Point(22, 48);
            this.comboBoxAsym.Name = "comboBoxAsynch";
            this.comboBoxAsym.Size = new System.Drawing.Size(460, 24);
            this.comboBoxAsym.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Co chcesz zrobić?";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(22, 225);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(214, 22);
            this.textBoxPrivateKey.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Klucz prywatny";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(268, 225);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(214, 22);
            this.textBoxPublicKey.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Klucz publiczny";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bezpieczne szyfrowanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSynchClear;
        private System.Windows.Forms.Button buttonSynch;
        private System.Windows.Forms.Button buttonSynchFile;
        private System.Windows.Forms.TextBox textBoxResultSym;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInputSym;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSym;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAsynchClear;
        private System.Windows.Forms.Button buttonAsynchFile;
        private System.Windows.Forms.Button buttonAsynch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAsym;
        private System.Windows.Forms.TextBox textBoxResultAsym;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInputAsym;
    }
}

