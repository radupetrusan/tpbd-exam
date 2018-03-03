namespace Calculator_Salariu
{
    partial class CalculatorSalarii
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.evidentaTab = new System.Windows.Forms.TabPage();
            this.tiparireTab = new System.Windows.Forms.TabPage();
            this.configurareTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modificareParametriiButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.impozitTextBox = new System.Windows.Forms.TextBox();
            this.cassTextBox = new System.Windows.Forms.TextBox();
            this.casTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parolaActualaTextBox = new System.Windows.Forms.TextBox();
            this.parolaNouaTextBox = new System.Windows.Forms.TextBox();
            this.parolaNouaConfirmaTextBox = new System.Windows.Forms.TextBox();
            this.schimbaParolaButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.configurareTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.evidentaTab);
            this.tabControl.Controls.Add(this.tiparireTab);
            this.tabControl.Controls.Add(this.configurareTab);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1094, 681);
            this.tabControl.TabIndex = 0;
            // 
            // evidentaTab
            // 
            this.evidentaTab.Location = new System.Drawing.Point(4, 22);
            this.evidentaTab.Name = "evidentaTab";
            this.evidentaTab.Padding = new System.Windows.Forms.Padding(3);
            this.evidentaTab.Size = new System.Drawing.Size(1086, 655);
            this.evidentaTab.TabIndex = 1;
            this.evidentaTab.Text = "Evidență";
            this.evidentaTab.UseVisualStyleBackColor = true;
            // 
            // tiparireTab
            // 
            this.tiparireTab.Location = new System.Drawing.Point(4, 22);
            this.tiparireTab.Name = "tiparireTab";
            this.tiparireTab.Size = new System.Drawing.Size(1086, 655);
            this.tiparireTab.TabIndex = 2;
            this.tiparireTab.Text = "Tipărire";
            this.tiparireTab.UseVisualStyleBackColor = true;
            // 
            // configurareTab
            // 
            this.configurareTab.Controls.Add(this.groupBox2);
            this.configurareTab.Controls.Add(this.modificareParametriiButton);
            this.configurareTab.Controls.Add(this.groupBox1);
            this.configurareTab.Location = new System.Drawing.Point(4, 22);
            this.configurareTab.Name = "configurareTab";
            this.configurareTab.Size = new System.Drawing.Size(1086, 655);
            this.configurareTab.TabIndex = 3;
            this.configurareTab.Text = "Configurare";
            this.configurareTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schimbaParolaButton);
            this.groupBox2.Controls.Add(this.parolaNouaConfirmaTextBox);
            this.groupBox2.Controls.Add(this.parolaNouaTextBox);
            this.groupBox2.Controls.Add(this.parolaActualaTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(433, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifcă parola";
            // 
            // modificareParametriiButton
            // 
            this.modificareParametriiButton.Location = new System.Drawing.Point(433, 243);
            this.modificareParametriiButton.Name = "modificareParametriiButton";
            this.modificareParametriiButton.Size = new System.Drawing.Size(240, 23);
            this.modificareParametriiButton.TabIndex = 1;
            this.modificareParametriiButton.Text = "Modificare parametrii";
            this.modificareParametriiButton.UseVisualStyleBackColor = true;
            this.modificareParametriiButton.Click += new System.EventHandler(this.modificareParametriiButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.impozitTextBox);
            this.groupBox1.Controls.Add(this.cassTextBox);
            this.groupBox1.Controls.Add(this.casTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(433, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrii";
            // 
            // impozitTextBox
            // 
            this.impozitTextBox.Enabled = false;
            this.impozitTextBox.Location = new System.Drawing.Point(96, 117);
            this.impozitTextBox.Name = "impozitTextBox";
            this.impozitTextBox.Size = new System.Drawing.Size(100, 20);
            this.impozitTextBox.TabIndex = 7;
            // 
            // cassTextBox
            // 
            this.cassTextBox.Enabled = false;
            this.cassTextBox.Location = new System.Drawing.Point(96, 79);
            this.cassTextBox.Name = "cassTextBox";
            this.cassTextBox.Size = new System.Drawing.Size(100, 20);
            this.cassTextBox.TabIndex = 6;
            // 
            // casTextBox
            // 
            this.casTextBox.Enabled = false;
            this.casTextBox.Location = new System.Drawing.Point(96, 41);
            this.casTextBox.Name = "casTextBox";
            this.casTextBox.Size = new System.Drawing.Size(100, 20);
            this.casTextBox.TabIndex = 5;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.toolStripSeparator1,
            this.ajutorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.despreToolStripMenuItem.Text = "Despre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parolă actuală";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmă parolă nouă";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parolă nouă";
            // 
            // parolaActualaTextBox
            // 
            this.parolaActualaTextBox.Location = new System.Drawing.Point(126, 42);
            this.parolaActualaTextBox.Name = "parolaActualaTextBox";
            this.parolaActualaTextBox.PasswordChar = '*';
            this.parolaActualaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaActualaTextBox.TabIndex = 6;
            // 
            // parolaNouaTextBox
            // 
            this.parolaNouaTextBox.Location = new System.Drawing.Point(126, 76);
            this.parolaNouaTextBox.Name = "parolaNouaTextBox";
            this.parolaNouaTextBox.PasswordChar = '*';
            this.parolaNouaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaNouaTextBox.TabIndex = 7;
            // 
            // parolaNouaConfirmaTextBox
            // 
            this.parolaNouaConfirmaTextBox.Location = new System.Drawing.Point(125, 112);
            this.parolaNouaConfirmaTextBox.Name = "parolaNouaConfirmaTextBox";
            this.parolaNouaConfirmaTextBox.PasswordChar = '*';
            this.parolaNouaConfirmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaNouaConfirmaTextBox.TabIndex = 8;
            // 
            // schimbaParolaButton
            // 
            this.schimbaParolaButton.Location = new System.Drawing.Point(15, 158);
            this.schimbaParolaButton.Name = "schimbaParolaButton";
            this.schimbaParolaButton.Size = new System.Drawing.Size(210, 23);
            this.schimbaParolaButton.TabIndex = 9;
            this.schimbaParolaButton.Text = "Schimbă parola";
            this.schimbaParolaButton.UseVisualStyleBackColor = true;
            this.schimbaParolaButton.Click += new System.EventHandler(this.schimbaParolaButton_Click);
            // 
            // CalculatorSalarii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 720);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CalculatorSalarii";
            this.Text = "Calculator salarii";
            this.tabControl.ResumeLayout(false);
            this.configurareTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage evidentaTab;
        private System.Windows.Forms.TabPage tiparireTab;
        private System.Windows.Forms.TabPage configurareTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button modificareParametriiButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox impozitTextBox;
        private System.Windows.Forms.TextBox cassTextBox;
        private System.Windows.Forms.TextBox casTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button schimbaParolaButton;
        private System.Windows.Forms.TextBox parolaNouaConfirmaTextBox;
        private System.Windows.Forms.TextBox parolaNouaTextBox;
        private System.Windows.Forms.TextBox parolaActualaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

