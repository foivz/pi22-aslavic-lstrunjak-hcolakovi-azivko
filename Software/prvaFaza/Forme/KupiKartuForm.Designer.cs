
namespace Hasan
{
    partial class KupiKartuForm
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
            this.linijaGroupBox = new System.Windows.Forms.GroupBox();
            this.odaberiDruguLinijuButton = new System.Windows.Forms.Button();
            this.autoprijevoznikTextBox = new System.Windows.Forms.TextBox();
            this.udaljenostTextBox = new System.Windows.Forms.TextBox();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vrstaKarteGroupBox = new System.Windows.Forms.GroupBox();
            this.umirovljenikRadioButton = new System.Windows.Forms.RadioButton();
            this.regularnaRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.detaljiGroupBox = new System.Windows.Forms.GroupBox();
            this.prtljagaCheckBox = new System.Windows.Forms.CheckBox();
            this.povratnaCheckBox = new System.Windows.Forms.CheckBox();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.linijaGroupBox.SuspendLayout();
            this.vrstaKarteGroupBox.SuspendLayout();
            this.detaljiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // linijaGroupBox
            // 
            this.linijaGroupBox.Controls.Add(this.odaberiDruguLinijuButton);
            this.linijaGroupBox.Controls.Add(this.autoprijevoznikTextBox);
            this.linijaGroupBox.Controls.Add(this.udaljenostTextBox);
            this.linijaGroupBox.Controls.Add(this.datumTextBox);
            this.linijaGroupBox.Controls.Add(this.odredisteTextBox);
            this.linijaGroupBox.Controls.Add(this.polazisteTextBox);
            this.linijaGroupBox.Controls.Add(this.label5);
            this.linijaGroupBox.Controls.Add(this.label4);
            this.linijaGroupBox.Controls.Add(this.label3);
            this.linijaGroupBox.Controls.Add(this.label2);
            this.linijaGroupBox.Controls.Add(this.label1);
            this.linijaGroupBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linijaGroupBox.Location = new System.Drawing.Point(28, 22);
            this.linijaGroupBox.Name = "linijaGroupBox";
            this.linijaGroupBox.Size = new System.Drawing.Size(469, 239);
            this.linijaGroupBox.TabIndex = 0;
            this.linijaGroupBox.TabStop = false;
            this.linijaGroupBox.Text = "Linije";
            // 
            // odaberiDruguLinijuButton
            // 
            this.odaberiDruguLinijuButton.Location = new System.Drawing.Point(330, 38);
            this.odaberiDruguLinijuButton.Name = "odaberiDruguLinijuButton";
            this.odaberiDruguLinijuButton.Size = new System.Drawing.Size(120, 70);
            this.odaberiDruguLinijuButton.TabIndex = 3;
            this.odaberiDruguLinijuButton.Text = "Odaberi drugu liniju";
            this.odaberiDruguLinijuButton.UseVisualStyleBackColor = true;
            this.odaberiDruguLinijuButton.Click += new System.EventHandler(this.odaberiDruguLinijuButton_Click);
            // 
            // autoprijevoznikTextBox
            // 
            this.autoprijevoznikTextBox.Enabled = false;
            this.autoprijevoznikTextBox.Location = new System.Drawing.Point(141, 196);
            this.autoprijevoznikTextBox.Name = "autoprijevoznikTextBox";
            this.autoprijevoznikTextBox.Size = new System.Drawing.Size(165, 28);
            this.autoprijevoznikTextBox.TabIndex = 9;
            // 
            // udaljenostTextBox
            // 
            this.udaljenostTextBox.Enabled = false;
            this.udaljenostTextBox.Location = new System.Drawing.Point(141, 159);
            this.udaljenostTextBox.Name = "udaljenostTextBox";
            this.udaljenostTextBox.Size = new System.Drawing.Size(165, 28);
            this.udaljenostTextBox.TabIndex = 8;
            // 
            // datumTextBox
            // 
            this.datumTextBox.Enabled = false;
            this.datumTextBox.Location = new System.Drawing.Point(141, 115);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(165, 28);
            this.datumTextBox.TabIndex = 7;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Enabled = false;
            this.odredisteTextBox.Location = new System.Drawing.Point(141, 79);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(165, 28);
            this.odredisteTextBox.TabIndex = 6;
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Enabled = false;
            this.polazisteTextBox.Location = new System.Drawing.Point(141, 38);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(165, 28);
            this.polazisteTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autoprijevoznik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Udaljenost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum polaska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // vrstaKarteGroupBox
            // 
            this.vrstaKarteGroupBox.Controls.Add(this.umirovljenikRadioButton);
            this.vrstaKarteGroupBox.Controls.Add(this.regularnaRadioButton);
            this.vrstaKarteGroupBox.Controls.Add(this.studentRadioButton);
            this.vrstaKarteGroupBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrstaKarteGroupBox.Location = new System.Drawing.Point(28, 277);
            this.vrstaKarteGroupBox.Name = "vrstaKarteGroupBox";
            this.vrstaKarteGroupBox.Size = new System.Drawing.Size(469, 86);
            this.vrstaKarteGroupBox.TabIndex = 1;
            this.vrstaKarteGroupBox.TabStop = false;
            this.vrstaKarteGroupBox.Text = "Vrsta karte";
            // 
            // umirovljenikRadioButton
            // 
            this.umirovljenikRadioButton.AutoSize = true;
            this.umirovljenikRadioButton.Location = new System.Drawing.Point(330, 42);
            this.umirovljenikRadioButton.Name = "umirovljenikRadioButton";
            this.umirovljenikRadioButton.Size = new System.Drawing.Size(102, 25);
            this.umirovljenikRadioButton.TabIndex = 2;
            this.umirovljenikRadioButton.TabStop = true;
            this.umirovljenikRadioButton.Text = "Umirovljenik";
            this.umirovljenikRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularnaRadioButton
            // 
            this.regularnaRadioButton.AutoSize = true;
            this.regularnaRadioButton.Checked = true;
            this.regularnaRadioButton.Location = new System.Drawing.Point(39, 42);
            this.regularnaRadioButton.Name = "regularnaRadioButton";
            this.regularnaRadioButton.Size = new System.Drawing.Size(90, 25);
            this.regularnaRadioButton.TabIndex = 1;
            this.regularnaRadioButton.TabStop = true;
            this.regularnaRadioButton.Text = "Regularna";
            this.regularnaRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(185, 42);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(74, 25);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // detaljiGroupBox
            // 
            this.detaljiGroupBox.Controls.Add(this.prtljagaCheckBox);
            this.detaljiGroupBox.Controls.Add(this.povratnaCheckBox);
            this.detaljiGroupBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaljiGroupBox.Location = new System.Drawing.Point(28, 380);
            this.detaljiGroupBox.Name = "detaljiGroupBox";
            this.detaljiGroupBox.Size = new System.Drawing.Size(469, 86);
            this.detaljiGroupBox.TabIndex = 2;
            this.detaljiGroupBox.TabStop = false;
            this.detaljiGroupBox.Text = "Ostale opcije";
            // 
            // prtljagaCheckBox
            // 
            this.prtljagaCheckBox.AutoSize = true;
            this.prtljagaCheckBox.Location = new System.Drawing.Point(185, 40);
            this.prtljagaCheckBox.Name = "prtljagaCheckBox";
            this.prtljagaCheckBox.Size = new System.Drawing.Size(77, 25);
            this.prtljagaCheckBox.TabIndex = 1;
            this.prtljagaCheckBox.Text = "Prtljaga";
            this.prtljagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // povratnaCheckBox
            // 
            this.povratnaCheckBox.AutoSize = true;
            this.povratnaCheckBox.Location = new System.Drawing.Point(47, 40);
            this.povratnaCheckBox.Name = "povratnaCheckBox";
            this.povratnaCheckBox.Size = new System.Drawing.Size(81, 25);
            this.povratnaCheckBox.TabIndex = 0;
            this.povratnaCheckBox.Text = "Povratna";
            this.povratnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kupiKartuButton.Location = new System.Drawing.Point(149, 489);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(108, 58);
            this.kupiKartuButton.TabIndex = 3;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustaniButton.Location = new System.Drawing.Point(284, 489);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(108, 58);
            this.odustaniButton.TabIndex = 4;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // KupiKartuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 568);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.detaljiGroupBox);
            this.Controls.Add(this.vrstaKarteGroupBox);
            this.Controls.Add(this.linijaGroupBox);
            this.Name = "KupiKartuForm";
            this.Text = "Kupi kartu";
            this.Load += new System.EventHandler(this.KupiKartuForm_Load);
            this.linijaGroupBox.ResumeLayout(false);
            this.linijaGroupBox.PerformLayout();
            this.vrstaKarteGroupBox.ResumeLayout(false);
            this.vrstaKarteGroupBox.PerformLayout();
            this.detaljiGroupBox.ResumeLayout(false);
            this.detaljiGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox linijaGroupBox;
        private System.Windows.Forms.Button odaberiDruguLinijuButton;
        private System.Windows.Forms.TextBox autoprijevoznikTextBox;
        private System.Windows.Forms.TextBox udaljenostTextBox;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox vrstaKarteGroupBox;
        private System.Windows.Forms.RadioButton umirovljenikRadioButton;
        private System.Windows.Forms.RadioButton regularnaRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.GroupBox detaljiGroupBox;
        private System.Windows.Forms.CheckBox prtljagaCheckBox;
        private System.Windows.Forms.CheckBox povratnaCheckBox;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}