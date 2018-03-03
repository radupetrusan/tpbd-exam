namespace Calculator_Salariu.UI.CalculatorSalarii.Forms
{
    partial class ModificaParametrii
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.impozitNumeric = new System.Windows.Forms.NumericUpDown();
            this.cassNumeric = new System.Windows.Forms.NumericUpDown();
            this.casNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.salvareButton = new System.Windows.Forms.Button();
            this.anulareButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impozitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.impozitNumeric);
            this.groupBox1.Controls.Add(this.cassNumeric);
            this.groupBox1.Controls.Add(this.casNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrii";
            // 
            // impozitNumeric
            // 
            this.impozitNumeric.Location = new System.Drawing.Point(96, 118);
            this.impozitNumeric.Name = "impozitNumeric";
            this.impozitNumeric.Size = new System.Drawing.Size(63, 20);
            this.impozitNumeric.TabIndex = 13;
            // 
            // cassNumeric
            // 
            this.cassNumeric.Location = new System.Drawing.Point(96, 80);
            this.cassNumeric.Name = "cassNumeric";
            this.cassNumeric.Size = new System.Drawing.Size(63, 20);
            this.cassNumeric.TabIndex = 12;
            // 
            // casNumeric
            // 
            this.casNumeric.Location = new System.Drawing.Point(96, 42);
            this.casNumeric.Name = "casNumeric";
            this.casNumeric.Size = new System.Drawing.Size(63, 20);
            this.casNumeric.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Impozit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CASS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parolă";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Location = new System.Drawing.Point(55, 184);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = '*';
            this.parolaTextBox.Size = new System.Drawing.Size(197, 20);
            this.parolaTextBox.TabIndex = 8;
            this.parolaTextBox.TextChanged += new System.EventHandler(this.parolaTextBox_TextChanged);
            // 
            // salvareButton
            // 
            this.salvareButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.salvareButton.Enabled = false;
            this.salvareButton.Location = new System.Drawing.Point(96, 234);
            this.salvareButton.Name = "salvareButton";
            this.salvareButton.Size = new System.Drawing.Size(75, 23);
            this.salvareButton.TabIndex = 9;
            this.salvareButton.Text = "Salvare";
            this.salvareButton.UseVisualStyleBackColor = true;
            this.salvareButton.Click += new System.EventHandler(this.salvareButton_Click);
            // 
            // anulareButton
            // 
            this.anulareButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.anulareButton.Location = new System.Drawing.Point(177, 234);
            this.anulareButton.Name = "anulareButton";
            this.anulareButton.Size = new System.Drawing.Size(75, 23);
            this.anulareButton.TabIndex = 10;
            this.anulareButton.Text = "Anulare";
            this.anulareButton.UseVisualStyleBackColor = true;
            // 
            // ModificaParametrii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 269);
            this.Controls.Add(this.anulareButton);
            this.Controls.Add(this.salvareButton);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificaParametrii";
            this.Text = "Modifică parametrii";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impozitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Button salvareButton;
        private System.Windows.Forms.Button anulareButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown impozitNumeric;
        private System.Windows.Forms.NumericUpDown cassNumeric;
        private System.Windows.Forms.NumericUpDown casNumeric;
    }
}