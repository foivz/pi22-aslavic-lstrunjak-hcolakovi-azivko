namespace Forme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odaberiLinijuButton = new System.Windows.Forms.Button();
            this.autoprijevoznikTextBox = new System.Windows.Forms.TextBox();
            this.udaljenostTextBox = new System.Windows.Forms.TextBox();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.umirovljenikRdioButton = new System.Windows.Forms.RadioButton();
            this.studentskaRadioButton = new System.Windows.Forms.RadioButton();
            this.regularnaRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prtljagaCheckBox = new System.Windows.Forms.CheckBox();
            this.povratnaKartaCheckBox = new System.Windows.Forms.CheckBox();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odaberiLinijuButton);
            this.groupBox1.Controls.Add(this.autoprijevoznikTextBox);
            this.groupBox1.Controls.Add(this.udaljenostTextBox);
            this.groupBox1.Controls.Add(this.odredisteTextBox);
            this.groupBox1.Controls.Add(this.polazisteTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabrana linija:";
            // 
            // odaberiLinijuButton
            // 
            this.odaberiLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaberiLinijuButton.Location = new System.Drawing.Point(390, 34);
            this.odaberiLinijuButton.Name = "odaberiLinijuButton";
            this.odaberiLinijuButton.Size = new System.Drawing.Size(170, 78);
            this.odaberiLinijuButton.TabIndex = 8;
            this.odaberiLinijuButton.Text = "Odaberi drugu liniju";
            this.odaberiLinijuButton.UseVisualStyleBackColor = true;
            this.odaberiLinijuButton.Click += new System.EventHandler(this.odaberiLinijuButton_Click);
            // 
            // autoprijevoznikTextBox
            // 
            this.autoprijevoznikTextBox.Enabled = false;
            this.autoprijevoznikTextBox.Location = new System.Drawing.Point(168, 176);
            this.autoprijevoznikTextBox.Name = "autoprijevoznikTextBox";
            this.autoprijevoznikTextBox.Size = new System.Drawing.Size(200, 29);
            this.autoprijevoznikTextBox.TabIndex = 7;
            // 
            // udaljenostTextBox
            // 
            this.udaljenostTextBox.Enabled = false;
            this.udaljenostTextBox.Location = new System.Drawing.Point(168, 129);
            this.udaljenostTextBox.Name = "udaljenostTextBox";
            this.udaljenostTextBox.Size = new System.Drawing.Size(200, 29);
            this.udaljenostTextBox.TabIndex = 6;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Enabled = false;
            this.odredisteTextBox.Location = new System.Drawing.Point(168, 83);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(200, 29);
            this.odredisteTextBox.TabIndex = 5;
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Enabled = false;
            this.polazisteTextBox.Location = new System.Drawing.Point(168, 34);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(200, 29);
            this.polazisteTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autoprijevoznik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost (km):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.umirovljenikRdioButton);
            this.groupBox2.Controls.Add(this.studentskaRadioButton);
            this.groupBox2.Controls.Add(this.regularnaRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(23, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta karte:";
            // 
            // umirovljenikRdioButton
            // 
            this.umirovljenikRdioButton.AutoSize = true;
            this.umirovljenikRdioButton.Location = new System.Drawing.Point(285, 50);
            this.umirovljenikRdioButton.Name = "umirovljenikRdioButton";
            this.umirovljenikRdioButton.Size = new System.Drawing.Size(135, 26);
            this.umirovljenikRdioButton.TabIndex = 2;
            this.umirovljenikRdioButton.Text = "Umirovljenik";
            this.umirovljenikRdioButton.UseVisualStyleBackColor = true;
            // 
            // studentskaRadioButton
            // 
            this.studentskaRadioButton.AutoSize = true;
            this.studentskaRadioButton.Location = new System.Drawing.Point(152, 50);
            this.studentskaRadioButton.Name = "studentskaRadioButton";
            this.studentskaRadioButton.Size = new System.Drawing.Size(123, 26);
            this.studentskaRadioButton.TabIndex = 1;
            this.studentskaRadioButton.Text = "Studentska";
            this.studentskaRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularnaRadioButton
            // 
            this.regularnaRadioButton.AutoSize = true;
            this.regularnaRadioButton.Checked = true;
            this.regularnaRadioButton.Location = new System.Drawing.Point(20, 50);
            this.regularnaRadioButton.Name = "regularnaRadioButton";
            this.regularnaRadioButton.Size = new System.Drawing.Size(116, 26);
            this.regularnaRadioButton.TabIndex = 0;
            this.regularnaRadioButton.TabStop = true;
            this.regularnaRadioButton.Text = "Regularna";
            this.regularnaRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prtljagaCheckBox);
            this.groupBox3.Controls.Add(this.povratnaKartaCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(23, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ostale opcije:";
            // 
            // prtljagaCheckBox
            // 
            this.prtljagaCheckBox.AutoSize = true;
            this.prtljagaCheckBox.Location = new System.Drawing.Point(212, 47);
            this.prtljagaCheckBox.Name = "prtljagaCheckBox";
            this.prtljagaCheckBox.Size = new System.Drawing.Size(97, 26);
            this.prtljagaCheckBox.TabIndex = 1;
            this.prtljagaCheckBox.Text = "Prtljaga";
            this.prtljagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // povratnaKartaCheckBox
            // 
            this.povratnaKartaCheckBox.AutoSize = true;
            this.povratnaKartaCheckBox.Location = new System.Drawing.Point(41, 47);
            this.povratnaKartaCheckBox.Name = "povratnaKartaCheckBox";
            this.povratnaKartaCheckBox.Size = new System.Drawing.Size(154, 26);
            this.povratnaKartaCheckBox.TabIndex = 0;
            this.povratnaKartaCheckBox.Text = "Povratna karta";
            this.povratnaKartaCheckBox.UseVisualStyleBackColor = true;
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kupiKartuButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kupiKartuButton.Location = new System.Drawing.Point(156, 549);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(148, 76);
            this.kupiKartuButton.TabIndex = 3;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odustaniButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustaniButton.Location = new System.Drawing.Point(345, 549);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(148, 76);
            this.odustaniButton.TabIndex = 4;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // KupiKartuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(645, 658);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KupiKartuForm";
            this.Text = "Kupovina karte";
            this.Load += new System.EventHandler(this.KupiKartuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button odaberiLinijuButton;
        private System.Windows.Forms.TextBox autoprijevoznikTextBox;
        private System.Windows.Forms.TextBox udaljenostTextBox;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton umirovljenikRdioButton;
        private System.Windows.Forms.RadioButton studentskaRadioButton;
        private System.Windows.Forms.RadioButton regularnaRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox prtljagaCheckBox;
        private System.Windows.Forms.CheckBox povratnaKartaCheckBox;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}