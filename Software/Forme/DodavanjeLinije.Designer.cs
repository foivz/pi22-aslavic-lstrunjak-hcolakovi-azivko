namespace Forme
{
    partial class DodavanjeLinije
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dodajLinijuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.brojLinijeTextBox = new System.Windows.Forms.TextBox();
            this.polazisteComboBox = new System.Windows.Forms.ComboBox();
            this.odredisteComboBox = new System.Windows.Forms.ComboBox();
            this.datumPolaskaTextBox = new System.Windows.Forms.TextBox();
            this.udaljenostTextBox = new System.Windows.Forms.TextBox();
            this.prijevozniciComboBox = new System.Windows.Forms.ComboBox();
            this.brojMjestaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj linije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polazište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odredište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum i vrijeme polaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Udaljenost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Autoprijevoznik:";
            // 
            // dodajLinijuButton
            // 
            this.dodajLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajLinijuButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLinijuButton.Location = new System.Drawing.Point(264, 518);
            this.dodajLinijuButton.Name = "dodajLinijuButton";
            this.dodajLinijuButton.Size = new System.Drawing.Size(117, 52);
            this.dodajLinijuButton.TabIndex = 12;
            this.dodajLinijuButton.Text = "Dodaj liniju";
            this.dodajLinijuButton.UseVisualStyleBackColor = true;
            this.dodajLinijuButton.Click += new System.EventHandler(this.dodajLinijuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odustaniButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustaniButton.Location = new System.Drawing.Point(403, 518);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(117, 52);
            this.odustaniButton.TabIndex = 13;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(33, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dodavanje nove linije!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Broj mjesta:";
            // 
            // brojLinijeTextBox
            // 
            this.brojLinijeTextBox.Location = new System.Drawing.Point(264, 107);
            this.brojLinijeTextBox.Name = "brojLinijeTextBox";
            this.brojLinijeTextBox.Size = new System.Drawing.Size(256, 28);
            this.brojLinijeTextBox.TabIndex = 22;
            // 
            // polazisteComboBox
            // 
            this.polazisteComboBox.FormattingEnabled = true;
            this.polazisteComboBox.Items.AddRange(new object[] {
            "Zagreb",
            "Varaždin",
            "Čakovec",
            "Split",
            "Osijek",
            "Rijeka",
            "Zadar",
            "Makarska",
            "Slavonski Brod",
            "Dubrovnik",
            "Karlovac",
            "Pula",
            "Rovinj",
            "Požega",
            "Šibenik",
            "Bjelovar",
            "Zaprešić"});
            this.polazisteComboBox.Location = new System.Drawing.Point(264, 155);
            this.polazisteComboBox.Name = "polazisteComboBox";
            this.polazisteComboBox.Size = new System.Drawing.Size(256, 29);
            this.polazisteComboBox.TabIndex = 23;
            // 
            // odredisteComboBox
            // 
            this.odredisteComboBox.FormattingEnabled = true;
            this.odredisteComboBox.Items.AddRange(new object[] {
            "Zagreb",
            "Varaždin",
            "Čakovec",
            "Split",
            "Osijek",
            "Rijeka",
            "Zadar",
            "Makarska",
            "Slavonski Brod",
            "Dubrovnik",
            "Karlovac",
            "Pula",
            "Rovinj",
            "Požega",
            "Šibenik",
            "Bjelovar",
            "Zaprešić"});
            this.odredisteComboBox.Location = new System.Drawing.Point(264, 214);
            this.odredisteComboBox.Name = "odredisteComboBox";
            this.odredisteComboBox.Size = new System.Drawing.Size(256, 29);
            this.odredisteComboBox.TabIndex = 24;
            // 
            // datumPolaskaTextBox
            // 
            this.datumPolaskaTextBox.Location = new System.Drawing.Point(264, 276);
            this.datumPolaskaTextBox.Name = "datumPolaskaTextBox";
            this.datumPolaskaTextBox.Size = new System.Drawing.Size(256, 28);
            this.datumPolaskaTextBox.TabIndex = 25;
            // 
            // udaljenostTextBox
            // 
            this.udaljenostTextBox.Location = new System.Drawing.Point(264, 341);
            this.udaljenostTextBox.Name = "udaljenostTextBox";
            this.udaljenostTextBox.Size = new System.Drawing.Size(256, 28);
            this.udaljenostTextBox.TabIndex = 26;
            // 
            // prijevozniciComboBox
            // 
            this.prijevozniciComboBox.FormattingEnabled = true;
            this.prijevozniciComboBox.Location = new System.Drawing.Point(264, 404);
            this.prijevozniciComboBox.Name = "prijevozniciComboBox";
            this.prijevozniciComboBox.Size = new System.Drawing.Size(256, 29);
            this.prijevozniciComboBox.TabIndex = 27;
            // 
            // brojMjestaTextBox
            // 
            this.brojMjestaTextBox.Location = new System.Drawing.Point(264, 459);
            this.brojMjestaTextBox.Name = "brojMjestaTextBox";
            this.brojMjestaTextBox.Size = new System.Drawing.Size(256, 28);
            this.brojMjestaTextBox.TabIndex = 28;
            // 
            // DodavanjeLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(573, 607);
            this.Controls.Add(this.brojMjestaTextBox);
            this.Controls.Add(this.prijevozniciComboBox);
            this.Controls.Add(this.udaljenostTextBox);
            this.Controls.Add(this.datumPolaskaTextBox);
            this.Controls.Add(this.odredisteComboBox);
            this.Controls.Add(this.polazisteComboBox);
            this.Controls.Add(this.brojLinijeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajLinijuButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DodavanjeLinije";
            this.Text = "Dodavanje nove linije";
            this.Load += new System.EventHandler(this.DodavanjeLinije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodajLinijuButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox brojLinijeTextBox;
        private System.Windows.Forms.ComboBox polazisteComboBox;
        private System.Windows.Forms.ComboBox odredisteComboBox;
        private System.Windows.Forms.TextBox datumPolaskaTextBox;
        private System.Windows.Forms.TextBox udaljenostTextBox;
        private System.Windows.Forms.ComboBox prijevozniciComboBox;
        private System.Windows.Forms.TextBox brojMjestaTextBox;
    }
}