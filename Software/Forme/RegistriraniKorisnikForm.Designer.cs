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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNav = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.popisLinijaDataGridView.Location = new System.Drawing.Point(158, 161);
            this.popisLinijaDataGridView.Name = "popisLinijaDataGridView";
            this.popisLinijaDataGridView.RowHeadersWidth = 51;
            this.popisLinijaDataGridView.RowTemplate.Height = 24;
            this.popisLinijaDataGridView.Size = new System.Drawing.Size(584, 386);
            this.popisLinijaDataGridView.TabIndex = 0;
            // 
            // odjaviSeButton
            // 
            this.odjaviSeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.odjaviSeButton.FlatAppearance.BorderSize = 0;
            this.odjaviSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjaviSeButton.Location = new System.Drawing.Point(917, 581);
            this.odjaviSeButton.Name = "odjaviSeButton";
            this.odjaviSeButton.Size = new System.Drawing.Size(142, 60);
            this.odjaviSeButton.TabIndex = 3;
            this.odjaviSeButton.Text = "Odjavi se";
            this.odjaviSeButton.UseVisualStyleBackColor = false;
            this.odjaviSeButton.Click += new System.EventHandler(this.odjaviSeButton_Click);
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.kupiKartuButton.FlatAppearance.BorderSize = 0;
            this.kupiKartuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kupiKartuButton.Location = new System.Drawing.Point(158, 570);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(247, 71);
            this.kupiKartuButton.TabIndex = 4;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = false;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.profilButton.FlatAppearance.BorderSize = 0;
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Location = new System.Drawing.Point(917, 55);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(167, 79);
            this.profilButton.TabIndex = 5;
            this.profilButton.Text = "Profil";
            this.profilButton.UseVisualStyleBackColor = false;
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
            this.polazisteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.polazisteTextBox.ForeColor = System.Drawing.Color.White;
            this.polazisteTextBox.Location = new System.Drawing.Point(259, 61);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(251, 32);
            this.polazisteTextBox.TabIndex = 8;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.odredisteTextBox.ForeColor = System.Drawing.Color.White;
            this.odredisteTextBox.Location = new System.Drawing.Point(259, 107);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(251, 32);
            this.odredisteTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(154, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Polazište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(154, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Odredište:";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.filtrirajButton.FlatAppearance.BorderSize = 0;
            this.filtrirajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrirajButton.Location = new System.Drawing.Point(25, 138);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(242, 38);
            this.filtrirajButton.TabIndex = 12;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = false;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.filtrirajButton);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(770, 161);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(289, 203);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filtriraj linije po datumu";
            // 
            // pretraziButton
            // 
            this.pretraziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.pretraziButton.FlatAppearance.BorderSize = 0;
            this.pretraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretraziButton.Location = new System.Drawing.Point(545, 74);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(142, 60);
            this.pretraziButton.TabIndex = 14;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = false;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // prikazDetaljaButton
            // 
            this.prikazDetaljaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.prikazDetaljaButton.FlatAppearance.BorderSize = 0;
            this.prikazDetaljaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikazDetaljaButton.Location = new System.Drawing.Point(500, 570);
            this.prikazDetaljaButton.Name = "prikazDetaljaButton";
            this.prikazDetaljaButton.Size = new System.Drawing.Size(242, 71);
            this.prikazDetaljaButton.TabIndex = 15;
            this.prikazDetaljaButton.Text = "Prikaži detalje";
            this.prikazDetaljaButton.UseVisualStyleBackColor = false;
            this.prikazDetaljaButton.Click += new System.EventHandler(this.prikazDetaljaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Forme.Properties.Resources.user_login_png_transparent_6_Transparent_Images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // buttonNav
            // 
            this.buttonNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.buttonNav.FlatAppearance.BorderSize = 0;
            this.buttonNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNav.Location = new System.Drawing.Point(127, 0);
            this.buttonNav.Name = "buttonNav";
            this.buttonNav.Size = new System.Drawing.Size(974, 30);
            this.buttonNav.TabIndex = 17;
            this.buttonNav.UseVisualStyleBackColor = false;
            this.buttonNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseDown);
            this.buttonNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseMove);
            this.buttonNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 663);
            this.panel1.TabIndex = 18;
            // 
            // RegistriraniKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1101, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonNav);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistriraniKorisnikForm";
            this.Text = "LinkBus";
            this.Load += new System.EventHandler(this.RegistriraniKorisnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNav;
        private System.Windows.Forms.Panel panel1;
    }
}