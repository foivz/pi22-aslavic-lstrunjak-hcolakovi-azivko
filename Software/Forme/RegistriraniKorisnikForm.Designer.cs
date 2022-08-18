namespace Forme
{
    partial class RegistriraniKorisnikForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.popisLinijaDataGridView = new System.Windows.Forms.DataGridView();
            this.odjaviSeButton = new System.Windows.Forms.Button();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.prikazDetaljaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisLinijaDataGridView
            // 
            this.popisLinijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.popisLinijaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.popisLinijaDataGridView.Location = new System.Drawing.Point(50, 118);
            this.popisLinijaDataGridView.Name = "popisLinijaDataGridView";
            this.popisLinijaDataGridView.RowHeadersWidth = 51;
            this.popisLinijaDataGridView.RowTemplate.Height = 24;
            this.popisLinijaDataGridView.Size = new System.Drawing.Size(584, 386);
            this.popisLinijaDataGridView.TabIndex = 0;
            // 
            // odjaviSeButton
            // 
            this.odjaviSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjaviSeButton.Location = new System.Drawing.Point(809, 538);
            this.odjaviSeButton.Name = "odjaviSeButton";
            this.odjaviSeButton.Size = new System.Drawing.Size(142, 60);
            this.odjaviSeButton.TabIndex = 3;
            this.odjaviSeButton.Text = "Odjavi se";
            this.odjaviSeButton.UseVisualStyleBackColor = true;
            this.odjaviSeButton.Click += new System.EventHandler(this.odjaviSeButton_Click);
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kupiKartuButton.Location = new System.Drawing.Point(50, 527);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(137, 71);
            this.kupiKartuButton.TabIndex = 4;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Location = new System.Drawing.Point(809, 12);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(142, 60);
            this.profilButton.TabIndex = 5;
            this.profilButton.Text = "Profil";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum i vrijeme polaska:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(25, 84);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 32);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2022, 7, 5, 0, 0, 0, 0);
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Location = new System.Drawing.Point(151, 18);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(251, 32);
            this.polazisteTextBox.TabIndex = 8;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(151, 64);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(251, 32);
            this.odredisteTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(46, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Polazište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Odredište:";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrirajButton.Location = new System.Drawing.Point(25, 138);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(242, 38);
            this.filtrirajButton.TabIndex = 12;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.filtrirajButton);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(662, 118);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(289, 203);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filtriraj linije po datumu";
            // 
            // pretraziButton
            // 
            this.pretraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretraziButton.Location = new System.Drawing.Point(437, 31);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(142, 60);
            this.pretraziButton.TabIndex = 14;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // prikazDetaljaButton
            // 
            this.prikazDetaljaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikazDetaljaButton.Location = new System.Drawing.Point(497, 527);
            this.prikazDetaljaButton.Name = "prikazDetaljaButton";
            this.prikazDetaljaButton.Size = new System.Drawing.Size(137, 71);
            this.prikazDetaljaButton.TabIndex = 15;
            this.prikazDetaljaButton.Text = "Prikaži detalje";
            this.prikazDetaljaButton.UseVisualStyleBackColor = true;
            this.prikazDetaljaButton.Click += new System.EventHandler(this.prikazDetaljaButton_Click);
            // 
            // RegistriraniKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(988, 613);
            this.Controls.Add(this.prikazDetaljaButton);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odredisteTextBox);
            this.Controls.Add(this.polazisteTextBox);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.odjaviSeButton);
            this.Controls.Add(this.popisLinijaDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistriraniKorisnikForm";
            this.Text = "LinkBus";
            this.Load += new System.EventHandler(this.RegistriraniKorisnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisLinijaDataGridView;
        private System.Windows.Forms.Button odjaviSeButton;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.Button prikazDetaljaButton;
    }
}