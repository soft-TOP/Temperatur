namespace Temperatur
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownTempA = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEinheitA = new System.Windows.Forms.ComboBox();
            this.numericUpDownRechne = new System.Windows.Forms.NumericUpDown();
            this.labelGleich = new System.Windows.Forms.Label();
            this.comboBoxEinheitB = new System.Windows.Forms.ComboBox();
            this.numericUpDownTempB = new System.Windows.Forms.NumericUpDown();
            this.labelEinheitVon = new System.Windows.Forms.Label();
            this.labelNach = new System.Windows.Forms.Label();
            this.labelErgebnisEinheit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRechne = new System.Windows.Forms.ComboBox();
            this.numericUpDownRechneErgebnis = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRechne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRechneErgebnis)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTempA
            // 
            this.numericUpDownTempA.DecimalPlaces = 2;
            this.numericUpDownTempA.Location = new System.Drawing.Point(11, 30);
            this.numericUpDownTempA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTempA.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownTempA.Name = "numericUpDownTempA";
            this.numericUpDownTempA.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTempA.TabIndex = 0;
            this.numericUpDownTempA.ValueChanged += new System.EventHandler(this.numericUpDownTempA_ValueChanged);
            // 
            // comboBoxEinheitA
            // 
            this.comboBoxEinheitA.DisplayMember = "Kelvin";
            this.comboBoxEinheitA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEinheitA.FormattingEnabled = true;
            this.comboBoxEinheitA.Location = new System.Drawing.Point(68, 29);
            this.comboBoxEinheitA.Name = "comboBoxEinheitA";
            this.comboBoxEinheitA.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEinheitA.TabIndex = 1;
            this.comboBoxEinheitA.ValueMember = "Kelvin";
            this.comboBoxEinheitA.SelectedIndexChanged += new System.EventHandler(this.comboBoxEinheitA_SelectedIndexChanged);
            // 
            // numericUpDownRechne
            // 
            this.numericUpDownRechne.DecimalPlaces = 2;
            this.numericUpDownRechne.Location = new System.Drawing.Point(11, 94);
            this.numericUpDownRechne.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRechne.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownRechne.Name = "numericUpDownRechne";
            this.numericUpDownRechne.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownRechne.TabIndex = 0;
            this.numericUpDownRechne.ValueChanged += new System.EventHandler(this.numericUpDownRechne_ValueChanged);
            // 
            // labelGleich
            // 
            this.labelGleich.AutoSize = true;
            this.labelGleich.Location = new System.Drawing.Point(232, 33);
            this.labelGleich.Name = "labelGleich";
            this.labelGleich.Size = new System.Drawing.Size(13, 13);
            this.labelGleich.TabIndex = 2;
            this.labelGleich.Text = "=";
            // 
            // comboBoxEinheitB
            // 
            this.comboBoxEinheitB.DisplayMember = "Kelvin";
            this.comboBoxEinheitB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEinheitB.FormattingEnabled = true;
            this.comboBoxEinheitB.Location = new System.Drawing.Point(308, 30);
            this.comboBoxEinheitB.Name = "comboBoxEinheitB";
            this.comboBoxEinheitB.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEinheitB.TabIndex = 1;
            this.comboBoxEinheitB.ValueMember = "Kelvin";
            this.comboBoxEinheitB.SelectedIndexChanged += new System.EventHandler(this.comboBoxEinheitB_SelectedIndexChanged);
            // 
            // numericUpDownTempB
            // 
            this.numericUpDownTempB.DecimalPlaces = 2;
            this.numericUpDownTempB.Enabled = false;
            this.numericUpDownTempB.Location = new System.Drawing.Point(251, 30);
            this.numericUpDownTempB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTempB.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownTempB.Name = "numericUpDownTempB";
            this.numericUpDownTempB.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTempB.TabIndex = 0;
            this.numericUpDownTempB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // labelEinheitVon
            // 
            this.labelEinheitVon.AutoSize = true;
            this.labelEinheitVon.Location = new System.Drawing.Point(79, 13);
            this.labelEinheitVon.Name = "labelEinheitVon";
            this.labelEinheitVon.Size = new System.Drawing.Size(25, 13);
            this.labelEinheitVon.TabIndex = 3;
            this.labelEinheitVon.Text = "von";
            // 
            // labelNach
            // 
            this.labelNach.AutoSize = true;
            this.labelNach.Location = new System.Drawing.Point(319, 13);
            this.labelNach.Name = "labelNach";
            this.labelNach.Size = new System.Drawing.Size(31, 13);
            this.labelNach.TabIndex = 3;
            this.labelNach.Text = "nach";
            // 
            // labelErgebnisEinheit
            // 
            this.labelErgebnisEinheit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErgebnisEinheit.AutoSize = true;
            this.labelErgebnisEinheit.Location = new System.Drawing.Point(308, 96);
            this.labelErgebnisEinheit.Name = "labelErgebnisEinheit";
            this.labelErgebnisEinheit.Size = new System.Drawing.Size(13, 13);
            this.labelErgebnisEinheit.TabIndex = 7;
            this.labelErgebnisEinheit.Text = "[]";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // comboBoxRechne
            // 
            this.comboBoxRechne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRechne.DisplayMember = "Kelvin";
            this.comboBoxRechne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRechne.FormattingEnabled = true;
            this.comboBoxRechne.Location = new System.Drawing.Point(68, 93);
            this.comboBoxRechne.Name = "comboBoxRechne";
            this.comboBoxRechne.Size = new System.Drawing.Size(158, 21);
            this.comboBoxRechne.TabIndex = 5;
            this.comboBoxRechne.ValueMember = "Kelvin";
            this.comboBoxRechne.SelectedIndexChanged += new System.EventHandler(this.comboBoxRechne_SelectedIndexChanged_1);
            // 
            // numericUpDownRechneErgebnis
            // 
            this.numericUpDownRechneErgebnis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownRechneErgebnis.DecimalPlaces = 2;
            this.numericUpDownRechneErgebnis.Enabled = false;
            this.numericUpDownRechneErgebnis.Location = new System.Drawing.Point(251, 94);
            this.numericUpDownRechneErgebnis.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRechneErgebnis.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownRechneErgebnis.Name = "numericUpDownRechneErgebnis";
            this.numericUpDownRechneErgebnis.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownRechneErgebnis.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 170);
            this.Controls.Add(this.labelErgebnisEinheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRechne);
            this.Controls.Add(this.numericUpDownRechneErgebnis);
            this.Controls.Add(this.labelNach);
            this.Controls.Add(this.labelEinheitVon);
            this.Controls.Add(this.labelGleich);
            this.Controls.Add(this.numericUpDownRechne);
            this.Controls.Add(this.comboBoxEinheitB);
            this.Controls.Add(this.comboBoxEinheitA);
            this.Controls.Add(this.numericUpDownTempB);
            this.Controls.Add(this.numericUpDownTempA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRechne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRechneErgebnis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTempA;
        private System.Windows.Forms.ComboBox comboBoxEinheitA;
        private System.Windows.Forms.NumericUpDown numericUpDownRechne;
        private System.Windows.Forms.Label labelGleich;
        private System.Windows.Forms.ComboBox comboBoxEinheitB;
        private System.Windows.Forms.NumericUpDown numericUpDownTempB;
        private System.Windows.Forms.Label labelEinheitVon;
        private System.Windows.Forms.Label labelNach;
        private System.Windows.Forms.Label labelErgebnisEinheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRechne;
        private System.Windows.Forms.NumericUpDown numericUpDownRechneErgebnis;
    }
}

