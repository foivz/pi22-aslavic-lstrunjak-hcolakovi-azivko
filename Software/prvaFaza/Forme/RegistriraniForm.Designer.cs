namespace Hasan
{
    partial class RegistriraniForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.pretraziLinijeGroupBox = new System.Windows.Forms.GroupBox();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.odabriteDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.odjaviSeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pretraziLinijeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upiši polaziste:";
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Location = new System.Drawing.Point(171, 27);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(293, 22);
            this.polazisteTextBox.TabIndex = 2;
            // 
            // pretraziLinijeGroupBox
            // 
            this.pretraziLinijeGroupBox.Controls.Add(this.filtrirajButton);
            this.pretraziLinijeGroupBox.Controls.Add(this.label2);
            this.pretraziLinijeGroupBox.Controls.Add(this.odabriteDatumDateTimePicker);
            this.pretraziLinijeGroupBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretraziLinijeGroupBox.Location = new System.Drawing.Point(681, 114);
            this.pretraziLinijeGroupBox.Name = "pretraziLinijeGroupBox";
            this.pretraziLinijeGroupBox.Size = new System.Drawing.Size(297, 214);
            this.pretraziLinijeGroupBox.TabIndex = 4;
            this.pretraziLinijeGroupBox.TabStop = false;
            this.pretraziLinijeGroupBox.Text = "Filtriraj linije:";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrirajButton.Location = new System.Drawing.Point(102, 146);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(96, 36);
            this.filtrirajButton.TabIndex = 2;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberite datum:";
            // 
            // odabriteDatumDateTimePicker
            // 
            this.odabriteDatumDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.odabriteDatumDateTimePicker.Location = new System.Drawing.Point(22, 85);
            this.odabriteDatumDateTimePicker.Name = "odabriteDatumDateTimePicker";
            this.odabriteDatumDateTimePicker.Size = new System.Drawing.Size(248, 32);
            this.odabriteDatumDateTimePicker.TabIndex = 0;
            this.odabriteDatumDateTimePicker.Value = new System.DateTime(2022, 5, 8, 15, 12, 0, 0);
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kupiKartuButton.Location = new System.Drawing.Point(45, 508);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(121, 67);
            this.kupiKartuButton.TabIndex = 5;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilButton.Location = new System.Drawing.Point(857, 25);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(121, 52);
            this.profilButton.TabIndex = 6;
            this.profilButton.Text = "Profil";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // odjaviSeButton
            // 
            this.odjaviSeButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjaviSeButton.Location = new System.Drawing.Point(857, 508);
            this.odjaviSeButton.Name = "odjaviSeButton";
            this.odjaviSeButton.Size = new System.Drawing.Size(121, 67);
            this.odjaviSeButton.TabIndex = 7;
            this.odjaviSeButton.Text = "Odjavi se";
            this.odjaviSeButton.UseVisualStyleBackColor = true;
            this.odjaviSeButton.Click += new System.EventHandler(this.odjaviSeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Upiši odrediste:";
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(171, 69);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(293, 22);
            this.odredisteTextBox.TabIndex = 9;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretraziButton.Location = new System.Drawing.Point(490, 34);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(114, 52);
            this.pretraziButton.TabIndex = 10;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // RegistriraniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 597);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.odredisteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odjaviSeButton);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.pretraziLinijeGroupBox);
            this.Controls.Add(this.polazisteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistriraniForm";
            this.Text = "Autobusni kolodvor";
            this.Load += new System.EventHandler(this.RegistriraniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pretraziLinijeGroupBox.ResumeLayout(false);
            this.pretraziLinijeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.GroupBox pretraziLinijeGroupBox;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker odabriteDatumDateTimePicker;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Button odjaviSeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.Button pretraziButton;
    }
}